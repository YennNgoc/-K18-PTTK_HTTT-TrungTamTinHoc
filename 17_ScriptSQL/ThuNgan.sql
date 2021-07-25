-- func tbHD: xem hoa don theo ma nhan vien
create function tbHD
(
	@manv char(8)
)
returns table
as
return
	select hd.MaHD, dk.MaHV, dk.MaLop, hd.NgayLapHD, hd.TongTien, hd.MaNV from HoaDon hd join DangKy dk on hd.MaHD = dk.MaHD where hd.MaNV = @manv
go

--select * from tbHD('NV000021') where MaHD = 'HD000072'
--go

--drop function tbHD
--go

-------------------------------------------------------------------------------------------------------------------------------------------------------

	-- func tbHP: xem DSHP theo ma hoc vien + hoc ky de lap hoa don
create or alter function tbDSHP
(
	@mahv char(8),
	@mahk char(4)
)
returns table
as
return
	select dk.MaHV, dk.MaLop, lh.MaMH, mh.MaNhomMH, dk.NgayDangKy, lh.HocPhi, dk.MaHD from DangKy dk left join Lop lh on dk.MaLop = lh.MaLop 
	left join MonHoc mh on lh.MaMH = mh.MaMH
	where dk.MaHV = @mahv and left(dk.MaLop, 4) = @mahk --and dk.MaHD=null
go

--select * from tbDSHP('HV000004', '2102')
--go

--drop function tbDSHP
--go

--------------------------------------------------------------------------------------------------------------------------------------------------------

	-- a) proc TraCuuHD: xem tat ca hoa don
create or alter proc TraCuuHD
	@manv char(8)
as
begin
	if exists(select * from HoaDon where MaNV = @manv)
	begin
		select * from HoaDon where MaNV = @manv
	end
	else
		raiserror (N'Nhân viên này chưa lập hóa đơn nào!', 16, 1)
end
go
--exec TraCuuHD 'NV000029'
--go

---------------------------------------------------------------------------------------------------------------------------
	
	-- b) proc TraCuuHDTheoHD: xem HD theo ma hoa don
create or alter proc TraCuuHDTheoHD
	@manv char(8),
	@mahd char(8)
as
begin
	if exists (select * from HoaDon where MaNV = @manv)
	begin 
		declare @dem int
		set @dem = (select count(*) from tbHD(@manv) where MaHD = @mahd)
		if (@dem = 0)
			raiserror (N'Sai mã hóa đơn!', 16, 1)
		else
			select * from tbHD(@manv) where MaHD = @mahd
	end
	else
		raiserror (N'Nhân viên này chưa lập hóa đơn nào!', 16, 1)
end
go

--exec TraCuuHDTheoHD 'NV000029', 'HD000020'
--go

---------------------------------------------------------------------------------------------------------------------------
	
	-- c) proc TraCuuHDTheoHV: xem HD theo ma hoc vien
create or alter proc TraCuuHDTheoHV
	@manv char(8),
	@mahv char(8)
as
begin
	if exists (select * from HoaDon where MaNV = @manv)
	begin 
		declare @dem int
		set @dem = (select count(*) from tbHD(@manv) where MaHV = @mahv)
		if (@dem = 0)
			raiserror (N'Sai mã học viên!', 16, 1)
		else
			select * from tbHD(@manv) where MaHV = @mahv
	end
	else
		raiserror (N'Nhân viên này chưa lập hóa đơn nào!', 16, 1)
end
go

--exec TraCuuHDTheoHV 'NV000029', 'HV000020'
--go

---------------------------------------------------------------------------------------------------------------------------
	
	--proc TraCuuDSHP: tra cuu DSHP cua hoc vien de lap hoa don
create or alter proc TraCuuDSHP
	@mahv char(8),
	@mahk char(4)
as 
begin
	if exists (select * from HocVien where MaHV = @mahv)
	begin
		declare @dem int
		set @dem = (select count(*) from tbDSHP(@mahv, @mahk))
		print (@dem)
		if (@dem = 0)
			raiserror (N'Không có dữ liệu!', 16, 1)
		else
			select * from tbDSHP(@mahv, @mahk)
	end
	else 
		raiserror (N'Học viên không tồn tại!', 16, 1)
end
go

--exec TraCuuDSHP 'HV000004', '21010001'
--go

----------------------------------------------------------------------------------------------------------------------------

	-- proc LapHD: lap hoa don theo ma hoc vien + hoc ky
create or alter proc LapHD
	@manv char(8),
	@mahv char(8),
	@mahk char(4)
as 
begin
	if exists (select * from HocVien where MaHV = @mahv)
	begin
		declare @dem int
		set @dem = (select count(*) from tbDSHP(@mahv, @mahk))
		print (@dem)
		if (@dem = 0)
			raiserror (N'Không có dữ liệu!', 16, 1)
		else
		begin
			declare @num int
			declare @mahd char(8) -- note: mahd cuoi cung truoc khi lap bang + 1. VD: HD000014 -> mahd vua lap: HD000015
			declare @tong money
			declare @ngaylaphd date -- note: ngay lap hd la ngay chon dky mon cuoi cung

			set @num = (select max(cast(right(MaHD, 6) as int)) from HoaDon)
			set @mahd = 'HD' + right('000000' + cast((@num + 1) as varchar(6)), 6)
			set @tong = (select sum(HocPhi) from tbDSHP(@mahv, @mahk))
			set @ngaylaphd = (select max(NgayDangKy) from tbDSHP(@mahv, @mahk))

			insert into HoaDon values (@mahd, @ngaylaphd, @tong, @manv)
			update DangKy
			set MaHD = @mahd where MaHV = @mahv and left(MaLop, 4) = @mahk
			select * from tbDSHP(@mahv, @mahk)
		end
	end
	else 
		raiserror (N'Học viên không tồn tại!', 16, 1)
end
go
---------------------------------Tong HD return
create or alter proc tongHD_return

	@mahv char(8),
	@mahk char(4)
	--,@sum money output
as 
begin
		--declare @tong money
		select sum(HocPhi) from tbDSHP(@mahv, @mahk) where MaHD IS null

		--return @tong
end
go
DECLARE @TONG MONEY
exec tongHD_return '2102','HV000004'
print (Tong)

select sum(HocPhi) from tbDSHP('HV000004', '2102') where MaHD IS null
DELETE FROM LichSuThi where MaHV='HV000001' and Diem=0
