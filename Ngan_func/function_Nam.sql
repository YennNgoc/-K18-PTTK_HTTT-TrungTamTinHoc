------NVQLHV
--Function: Hien thi danh sach hoc vien
Select * from HocVien;
go
--Function: Hien thi thong tin cua 1 hoc vien xac dinh
create or alter proc XemThongTinHV
@ma char(8)
as
begin
if(not exists (Select * from HocVien where MaHV=@ma))
RAISERROR('Khong tim thay hoc vien nay',1,1)
else
Select * from HocVien where MaHV=@ma
end;
go
--Function: Tra cuu HV khi HV quen ma
create or alter proc TraCuuHV
@cccd char(12),@Ten nvarchar(50),@ngaysinh date
as
begin
if(not exists(Select * from HocVien where CCCD=@cccd and HoTen=@Ten and NgaySinh=@ngaysinh))
RAISERROR('Khong tim thay hoc vien nay',1,1)
else
Select * from HocVien where CCCD=@cccd and HoTen=@Ten and NgaySinh=@ngaysinh
end;
go
--Function Cap Nhap Pass cua hoc vien
create or alter proc ResetPass
@pass varchar(20),@ma char(8)
as
begin
if(not exists(Select * from HocVien where MaHV=@ma))
RAISERROR('Khong tim thay hoc vien nay',1,1)
else if(@pass!=1)
RAISERROR('Ban reset sai roi',1,1)
else if(@pass=1 and exists(Select * from HocVien where MaHV=@ma))
begin
update HocVien set Password=@pass where MaHV=@ma
Select * from HocVien where MaHV=@ma
end
end;
go
--Function Them Hoc Vien (vi db email + ngay sinh la bat buoc ko dc null nen nho them hai textbox email,ngay sinh)
create or alter proc ThemHV
@ma char(8),@ten nvarchar(50), @pass varchar(20),@cccd char(12),@ngaysinh date,@email varchar(50),@sdt char(10)
as
begin
if(exists(Select * from HocVien where CCCD=@cccd and HoTen=@ten and NgaySinh=@ngaysinh))
RAISERROR('Da co hoc vien nay',1,1)
else if(@pass!=1)
RAISERROR('Ban nhap sai pass roi',1,1)
else if(exists(Select * from HocVien where MaHV=@ma))
RAISERROR('Da co hoc vien nay',1,1)
else if(exists(Select * from HocVien where Email=@email))
RAISERROR('Da co email nay',1,1)
else if(exists(Select * from HocVien where SDT=@sdt))
RAISERROR('Da co so dien thoai nay',1,1)
else
begin
insert into HocVien values(@ma,@pass,@ten,@cccd,@email,@sdt,@ngaysinh);
--waitfor delay '00:00:02'
--Select * from HocVien where MaHV=@ma
end
end;
go

create or alter proc XoaHV
@ma char(8)
as
begin
if(not exists(Select * from HocVien where MaHV=@ma))
RAISERROR('Da co loi xay ra!',16,1)
else
begin
delete from HocVien where MaHV=@ma;
end
end;
go
EXEC XoaHV "HV000100"
select * from HocVien
go



-----------------------NVQLLH
--Them 1 textbox nhom hoc phan
--Tra cuu HP (theo ten, ma, nhom)
create or alter proc TraCuu
@mahp char(8),@tenhp varchar(50),@nhomhp char(8)
as
begin
if(@tenhp is null and @nhomhp is null and exists(Select * from MonHoc where MaMH=@mahp))
select * from MonHoc where MaMH=@mahp
else if(@mahp is null and @nhomhp is null and exists(Select * from MonHoc where TenMH=@tenhp))
Select * from MonHoc where TenMH=@tenhp
if (@mahp is NULL and @tenhp is NULL and exists(Select * from MonHoc where MaNhomMH=@nhomhp))
Select * from MonHoc where MaNhomMH=@nhomhp
else if((not exists(Select * from MonHoc where MaMH=@mahp) and @tenhp is null and @nhomhp is null) 
or (not exists(Select * from MonHoc where TenMH=@tenhp) and @mahp is null and @nhomhp is null)
or (not exists(Select * from MonHoc where MaNhomMH=@nhomhp) and @mahp is NULL and @tenhp is NULL)
or (not exists(Select * from MonHoc where TenMH=@tenhp and MaNhomMH=@nhomhp) and @tenhp is not null and @mahp is null and @nhomhp is not null))
RAISERROR('Khong co thong tin',16,1)
else if(@tenhp is not null and @mahp is null and @nhomhp is not null and exists(Select * from MonHoc where TenMH=@tenhp and MaNhomMH=@nhomhp))
begin
Select * from MonHoc where TenMH=@tenhp and MaNhomMH=@nhomhp
end
end;
go
Exec TraCuu NULL,NULL,"NHOMCA01"
go
--Xoa Hoc phan
create or alter proc XoaHP
@mahp char(8),@tenhp varchar(50),@nhomhp char(8)
as
begin
if(@tenhp is null or @nhomhp is null or @mahp is null)
RAISERROR('Hay nhap du thong tin',16,1)
else if(not exists(Select * from MonHoc where MaMH=@mahp and TenMH=@tenhp and MaNhomMH=@nhomhp))
RAISERROR('Khong ton tai mon hoc nay',16,1)
else if(exists(Select * from MonHoc where MaMH=@mahp and TenMH=@tenhp and MaNhomMH=@nhomhp))
delete from MonHoc where MaMH=@mahp
end;
go
--Them HP
create or alter proc ThemHP
@mahp char(8),@tenhp varchar(50),@nhomhp char(8)
as
begin
if(@tenhp is null or @nhomhp is null or @mahp is null)
RAISERROR('Hay nhap du thong tin',1,1)
else if(@tenhp is not null and @nhomhp is not null and @mahp is not null)
begin
insert into MonHoc values(@mahp,@tenhp,@nhomhp)
waitfor delay '00:00:03'
Select * from MonHoc where MaMH=@mahp
end
end;
--Hien thi danh sach
Select * from MonHoc;
go
--ThemLop
create or alter proc ThemLop
@malop char(8),@mamh char(8),@magv char(8),@ngaymo date,@sl int
as
begin
if(exists(Select * from Lop where MaLop=@malop))
RAISERROR('Da co lop hoc nay',1,1)
else if(not exists(Select * from MonHoc where MaMH=@mamh) or not exists (Select * from NhanVien where MaNV=@magv) or @sl>20)
RAISERROR('Nhap thong tin sai',1,1)
else if(exists(Select * from MonHoc where MaMH=@mamh) and exists (Select * from NhanVien where MaNV=@magv) and @sl<=20)
insert into Lop values(@malop,@ngaymo,@sl,@mamh,200000,@magv)
waitfor delay '00:00:03'
Select * from Lop where MaLop=@malop
end;
go
--XoaLop
create or alter proc XoaLop
@malop char(8)
as
begin
if(not exists(Select * from Lop where MaLop=@malop))
RAISERROR('Khong co lop hoc nay',1,1)
else if(exists(Select * from Lop where MaLop=@malop))
delete Lop where MaLop=@malop
end;
go
--TraCuuDSMH
Select * from MonHoc;
go
--CapNhapSL
create or alter proc CapNhapSL
@malop char(8),@slcp int
as
begin
declare @tsl int
set @tsl=(Select SoLuong from Lop where MaLop=@malop)
if(@tsl+@slcp>30)
RAISERROR('Vuot qua so luong cho phep',1,1)
else if(@tsl+@slcp<=30)
begin
update Lop set SoLuong=@tsl+@slcp where MaLop=@malop
waitfor delay '00:00:03'
Select * from Lop where MaLop=@malop
end
end;
go
--Xem ThongTinLop
create or alter proc XemThongTinLop
@malop char(8)
as
begin
if(not exists(Select * from Lop where MaLop=@malop))
RAISERROR('Khong co lop nay',1,1)
else
Select * from Lop where MaLop=@malop
end;
go
--Hien thi ds lop
Select * from Lop;
go