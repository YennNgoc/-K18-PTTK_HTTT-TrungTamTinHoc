use [TT_TinHoc]
go



	-- func tbDiem: xem diem theo ma hoc vien
create function tbDiem
(
	@mahv char(8)
)
returns table
as
return
	select ls.MaHV, ls.MaLop, lh.MaMH, mh.MaNhomMH, ls.NgayThi, ls.Diem  from LichSuThi ls
	join Lop lh on ls.MaLop = lh.MaLop
	join MonHoc mh on lh.MaMH = mh.MaMH
	where ls.MaHV = @mahv
go

--select * from tbDiem('HV000014')
--go

--drop function tbDiem
--go

-------------------------------------------------------------------------------------------------------------------------------------------

	-- a) procTraCuuDiem: tra cuu tat ca diem
create or alter proc TraCuuDiem
	@mahv char(8)
as
begin
	if exists (select * from HocVien where MaHV = @mahv)
	begin
		declare @dem int
		set @dem = (select count(*) from tbDiem (@mahv))
		if (@dem = 0)
			raiserror (N'Học viên chưa đăng ký lớp học nào!', 16, 1)
		else
			select * from tbDiem (@mahv)
	end
	else
		raiserror (N'Học viên không tồn tại', 16, 1)
end
go
--exec TraCuuDiem 'HV000001'
--go

-----------------------------------------------------------------------------------------------------------------------------------------------

	-- b) proc TraCuuDiemTheoLH: tra cuu diem theo ma lop
create or alter proc TraCuuDiemTheoLH
	@mahv char(8),
	@malop char(8)
as
begin
	if exists (select * from HocVien where MaHV = @mahv)
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
	else
		raiserror (N'Học viên không tồn tại', 16, 1)
end
go

--exec TraCuuDiemTheoLH 'HV000101', 'LOP00055'	
--go

----------------------------------------------------------------------------------------------------------------------------------------------------

	-- c) proc TraCuuDiemTheoMH: tra cuu diem theo ma mon hoc
create or alter proc TraCuuDiemTheoMH
	@mahv char(8),
	@mamh char(8)
as
begin
	if exists (select * from HocVien where MaHV = @mahv)
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
	else
		raiserror (N'Học viên không tồn tại', 16, 1)
end
go
--exec TraCuuDiemTheoMH 'HV000014', 'TKDH2D'
--go

--------------------------------------------------------------------------------------------------------------------------------------------------

	-- d) proc TraCuuDiemTheoNMH: tra cuu diem theo nhom mon hoc
create or alter proc TraCuuDiemTheoNMH
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
--exec TraCuuDiemTheoNMH 'HV000001', 'NMH00002'
--go

---------------------------------------------------------------------------------------------------------------------------------------------------------

	-- e) proc TraCuuDiemTheoHK: tra cuu diem theo hoc ky
create or alter proc TraCuuDiemTheoHK
	@mahv char(8),
	@mahk char(4)
as
begin
	if exists (select * from HocVien where MaHV = @mahv)
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
	else
		raiserror (N'Học viên không tồn tại', 16, 1)
end
go
--exec TraCuuDiemTheoHK 'HV000001', 'LOP1'
--go

---------------------------------------------------------------------------------------------------------------------------------------------------------
	
	-- proc updateDiem: chinh sua diem theo ma lop

create or alter proc updateDiem
	@mahv char(8),
	@malop char(8),
	@diem float
as
begin
	if exists (select * from HocVien where MaHV = @mahv)
	begin
		if exists (select * from Lop where MaLop = @malop)
		begin
			declare @dem int
			set @dem = (select count(*) from tbDiem(@mahv) where MaLop = @malop)
			if (@dem = 0)
				raiserror (N'Học viên chưa đăng ký lớp học này!', 16, 1)
			else
			begin
				select * from tbDiem(@mahv) where MaLop = @malop
				if (@diem < 0 or @diem > 10)
					raiserror (N'Điểm không hợp lệ!', 16, 1)
				else
				begin
					update LichSuThi
					set Diem = @diem where MaHV = @mahv and MaLop = @malop
					select * from tbDiem(@mahv) where MaLop = @malop
				end
			end
		end
		else 
			raiserror (N'Lớp học không tồn tại', 16, 1)
	end
	else
		raiserror (N'Học viên không tồn tại', 16, 1)
end
go

--exec updateDiem 'HV000014', 'LOP00046', 7
--go

