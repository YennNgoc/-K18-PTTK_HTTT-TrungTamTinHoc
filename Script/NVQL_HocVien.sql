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




