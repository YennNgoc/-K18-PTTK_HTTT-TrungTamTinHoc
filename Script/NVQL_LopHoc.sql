-----------------------NVQLLH
--Tra cuu HP (theo ma, nhom)
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
--Exec TraCuu "THVP0001",NULL,NULL
--go
--Xoa Hoc phan
create or alter proc XoaHP
@mahp char(8),@tenhp varchar(50),@nhomhp char(8)
as
begin
if(@nhomhp is null or @mahp is null)
RAISERROR('Hay nhap du thong tin',16,1)
else if(not exists(Select * from MonHoc where MaMH=@mahp and MaNhomMH=@nhomhp))
RAISERROR('Khong ton tai mon hoc nay',16,1)
else if(exists(Select * from MonHoc where MaMH=@mahp and MaNhomMH=@nhomhp))
delete from MonHoc where MaMH=@mahp
end;
go
--Them HP
create or alter proc ThemHP
@mahp char(8),@tenhp varchar(50),@nhomhp char(8)
as
begin
if(@tenhp is null or @nhomhp is null or @mahp is null)
RAISERROR('Hay nhap du thong tin',16,1)
else if(@tenhp is not null and @nhomhp is not null and @mahp is not null)
begin
insert into MonHoc values(@mahp,@tenhp,@nhomhp)
end
end;
--Hien thi danh sach
--Select * from MonHoc;
go

------------------------------------------------------------------- Lop
--ThemLop
create or alter proc ThemLop
@malop char(8),@mamh char(8),@magv char(8),@ngaymo date,@sl int
as
begin
if(exists(Select * from Lop where MaLop=@malop))
RAISERROR('Da co lop hoc nay',16,1)
else if(not exists(Select * from MonHoc where MaMH=@mamh) or not exists (Select * from NhanVien where MaNV=@magv) or @sl>20)
RAISERROR('Nhap thong tin sai',16,1)
else if(exists(Select * from MonHoc where MaMH=@mamh) and exists (Select * from NhanVien where MaNV=@magv) and @sl<=20)
insert into Lop values(@malop,@ngaymo,@sl,@mamh,200000,@magv)
--waitfor delay '00:00:03'
--Select * from Lop where MaLop=@malop
end;
go
--XoaLop
create or alter proc XoaLop
@malop char(8)
as
begin
if(not exists(Select * from Lop where MaLop=@malop))
RAISERROR('Khong co lop hoc nay',16,1)
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
RAISERROR('Vuot qua so luong cho phep',16,1)
else if(@tsl+@slcp<=30)
begin
update Lop set SoLuong=@tsl+@slcp where MaLop=@malop
--waitfor delay '00:00:03'
--Select * from Lop where MaLop=@malop
end
end;
go
--Xem ThongTinLop
create or alter proc XemThongTinLop
@malop char(8)
as
begin
if(not exists(Select * from Lop where MaLop=@malop))
RAISERROR('Khong co lop nay',16,1)
else
Select * from Lop where MaLop=@malop
end;
go
--Hien thi ds lop
--exec XemThongTinLop "20010001"
--Select * from Lop;
go
create or alter proc LocLop
@hocki int,
@nam char(4)
as
begin
declare @namloc as char(2)
set @namloc=substring(@nam,3,2)
Select * from Lop where 
(substring(MaLop,1,2)=@namloc and @hocki is null)  or 
(substring(MaLop,4,1)=@hocki and @namloc is null) or 
(substring(MaLop,1,2)=@namloc and substring(MaLop,3,2)=@hocki); 
end;
go
--exec LocLop 2, "2020"