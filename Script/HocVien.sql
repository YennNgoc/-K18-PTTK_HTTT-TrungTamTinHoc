use [TT_TinHoc]
go


	-- note: cac proc tra cuu diem su dung func tbDiem o file KhaoThi_func.sql
	-- a) procTraCuuDiem: tra cuu tat ca diem
create or alter proc TraCuuDiem_HV
	@mahv char(8)
as
begin
	declare @dem int
	set @dem = (select count(*) from tbDiem (@mahv))
	if (@dem = 0)
		raiserror (N'Học viên chưa đăng ký lớp học nào!', 16, 1)
	else
		select * from tbDiem (@mahv)
	
end
go
--exec TraCuuDiem_HV 'HV000001'
--go

-----------------------------------------------------------------------------------------------------------------------------------------------

	-- b) proc TraCuuDiemTheoLH_HV: tra cuu diem theo ma lop
create or alter proc TraCuuDiemTheoLH_HV
	@mahv char(8),
	@malop char(8)
as
begin
	if exists (select * from Lop where MaLop = @malop)
	begin
		declare @dem int
		set @dem = (select count(*) from tbDiem(@mahv) where MaLop = @malop)
		if (@dem = 0)
			raiserror (N'Học viên chưa đăng ký lớp học này!', 16, 1)
		else
			select * from tbDiem(@mahv) where MaLop = @malop
	end
	else 
		raiserror (N'Lớp học không tồn tại', 16, 1)
end
go

--exec TraCuuDiemTheoLH_HV 'HV000014', 'LOP00046'	
--go

----------------------------------------------------------------------------------------------------------------------------------------------------

	-- c) proc TraCuuDiemTheoMH_HV: tra cuu diem theo ma mon hoc
create or alter proc TraCuuDiemTheoMH_HV
	@mahv char(8),
	@mamh char(8)
as
begin
	if exists (select * from MonHoc where MaMH = @mamh)
	begin
		declare @dem int
		set @dem = (select count(*) from tbDiem(@mahv) where MaMH = @mamh)
		if (@dem = 0)
			raiserror (N'Học viên chưa đăng ký môn học này!', 16, 1)
		else
			select * from tbDiem(@mahv) where MaMH = @mamh
	end
	else
		raiserror (N'Môn học không tồn tại', 16, 1)

end
go
--exec TraCuuDiemTheoMH_HV 'HV000014', 'TKDH2D'
--go

--------------------------------------------------------------------------------------------------------------------------------------------------

	-- d) proc TraCuuDiemTheoNMH_HV: tra cuu diem theo nhom mon hoc
create or alter proc TraCuuDiemTheoNMH_HV
	@mahv char(8),
	@manmh char(8)
as
begin
	if exists (select * from HocVien where MaHV = @mahv)
	begin
		if exists (select * from NhomMonHoc where MaNhomMH = @manmh)
		begin
			declare @dem int
			set @dem = (select count(*) from tbDiem(@mahv) where MaNhomMH = @manmh)
			if (@dem = 0)
				raiserror (N'Học viên chưa đăng ký nhóm môn học này!', 16, 1)
			else
				select * from tbDiem(@mahv) where MaNhomMH = @manmh
		end
		else
			raiserror (N'Nhóm môn học không tồn tại!', 16, 1)
	end
	else
		raiserror (N'Học viên không tồn tại', 16, 1)
end
go
--exec TraCuuDiemTheoNMH_HV 'HV000001', 'NMH00002'
--go

---------------------------------------------------------------------------------------------------------------------------------------------------------

	-- e) proc TraCuuDiemTheoHK_HV: tra cuu diem theo hoc ky
create or alter proc TraCuuDiemTheoHK_HV
	@mahv char(8),
	@mahk char(4)
as
begin
	if exists (select * from Lop where left(MaLop, 4) = @mahk)
	begin
		declare @dem int
		set @dem = (select count(*) from tbDiem(@mahv) where left(MaLop, 4) = @mahk)
		if (@dem = 0)
			raiserror (N'Học viên chưa đăng ký lớp trong học kỳ này!', 16, 1)
		else
			select * from tbDiem(@mahv) where left(MaLop, 4) = @mahk
	end
	else
		raiserror (N'Học kỳ không tồn tại!', 16, 1)
end
go
--exec TraCuuDiemTheoHK_HV 'HV000001', 'LOP0'
--go

-----------------------------------------------------------------------------------------------------------------------------------
	
	-- tra cuu thong tin
create or alter proc TraCuuThongTin
	@mahv char(8)
as
begin
	select top 1 * from HocVien where MaHV = @mahv
end
go
--exec TraCuuThongTin HV000004
--go

-----------------------------------------------------------------------------------------------------------------------------------
	
	-- chinh sua thong tin
	-- note: hoc vien khong the sua ho ten va ma hoc vien
create or alter proc ChinhSuaThongTin
	@mahv char(8),
	@hoten nvarchar(50),
	@pw varchar(20),
	@cccd char(12),
	@email varchar(50),
	@sdt char(10),
	@ngaysinh date
as
begin
	--exec TraCuuThongTin @mahv

	update HocVien
	set HoTen=@hoten, Password = @pw, CCCD = @cccd, Email = @email, SDT = @sdt, NgaySinh = @ngaysinh
	where MaHV = @mahv

	select * from HocVien where MaHV = @mahv
end
go
--exec ChinhSuaThongTin HV000004, 'Scottie Antliff','Hocvien04', '02613455040', 'santliff3@timesonline.co.uk', '0903043089', '2000-11-20'
--go

-----------------------------------------------------------------------------------------------------------------------------------
	
	-- tra cuu DS lop mo
create or alter proc TraCuuDSLopMo
	@malh char(8)
as
begin
	if exists (select * from Lop where MaLop = @malh)
	begin
		declare @ngaymodk date
		set @ngaymodk = (select NgayMo from Lop where MaLop = @malh)
		if (cast(GETDATE() as date) > DATEADD(day, 7, @ngaymodk))
			raiserror (N'Đã hết hạn mở lớp này!', 16, 1)
		else
			select * from Lop where MaLop = @malh
	end
	else
	begin
		raiserror (N'Lớp học không tồn tại!', 16, 1)
	end
end
go
-- proc TraCuuDSLopMo

create or alter proc TraCuuDSLopMo
as
begin
	declare @ngaytracuu date -- lay tgian hien tai khi tra cuu DS lop mo
	set @ngaytracuu = getdate()
	
	select * from Lop
	where @ngaytracuu between NgayMo and dateadd(day, 7, NgayMo)
end
go

create or alter proc TraCuuDSLopMo
	@mahk char(4)
as
begin
	if exists (select * from Lop where left(MaLop, 4) = @mahk)
	begin
		declare @ngaymodk date
		set @ngaymodk = (select max(NgayMo) from Lop where left(MaLop, 4) = @mahk)

		if (cast(GETDATE() as date) > DATEADD(day, 7, @ngaymodk))
			raiserror (N'Đã hết hạn đăng ký học phần!', 16, 1)
		else
			select * from Lop where left(MaLop, 4) = @mahk
	end
	else
	begin
		raiserror (N'Sai mã học kỳ!', 16, 1)
	end
end
go

--exec TraCuuDSLopMo '2101'
--go

-----------------------------------------------------------------------------------------------------------------------------------
	
	-- dang ky hoc phan
create or alter proc DKHP
	@mahv char(8),
	@malh char(8)
as
begin
	if exists (select * from Lop where MaLop = @malh)
	begin
		declare @ngaymodk date
		declare @ngaydk date
		set @ngaymodk = (select NgayMo from Lop where MaLop = @malh)
		set @ngaydk = cast(GETDATE() as date)

		if (cast(GETDATE() as date) > DATEADD(day, 7, @ngaymodk))
			raiserror (N'Đã hết hạn mở lớp này!', 16, 1)
		else
		begin
			insert into DangKy values (@ngaydk, @mahv, @malh, null)
			select * from DangKy where MaHV = @mahv and MaLop = @malh
		end
	end
	else
		raiserror (N'Lớp học không tồn tại!', 16, 1)
end
go

--exec DKHP 'HV000014', 'LOP00001'
--go

-----------------------------------------------------------------------------------------------------------------------------------
	
	-- tra cuu lich su tot nghiep
create or alter proc TraCuuLSTN
	@mahv char(8)
as
begin
	if exists (select * from LichSuTotNghiep where MaHV = @mahv)
		select * from LichSuTotNghiep where MaHV = @mahv
	else 
		raiserror ('Khong co ket qua phu hop!',16,1)
end
go
--exec TraCuuLSTN 'HV000004'
--go
create or alter proc TraCuuKQDK
	@mahv char(8)
as
begin
	select * from DangKy where MaHV = @mahv
	
end
go

exec TraCuuKQDK "HV000001"

go
create or alter proc TraDiemTheoLop
@mahv char(8),
@hocki int,
@nam char(4)
as
begin
declare @namloc as char(2)
set @namloc=substring(@nam,3,2)
Select * from LichSuThi where MaHV =@mahv and
(substring(MaLop,1,2)=@namloc and @hocki is null)  or 
(substring(MaLop,4,1)=@hocki and @namloc is null) or 
(substring(MaLop,1,2)=@namloc and substring(MaLop,3,2)=@hocki); 
end;
go

