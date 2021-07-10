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

	-- b) proc TraCuuDiemTheoLH: tra cuu diem theo ma lop (bo @mahv)

create or alter proc TraCuuDiemTheoLH
	@malop char(8)
as
begin
	if exists (select * from Lop where MaLop = @malop)
	begin
		if (select Soluong from Lop where MaLop = @malop) > 0
		begin
			if exists (select * from LichSuThi where MaLop = @malop)
				select * from LichSuThi where MaLop = @malop
		end
		else
			raiserror (N'Lớp học chưa có học viên!', 16, 1)
	end
	else
		raiserror (N'Lớp học không tồn tại', 16, 1)
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

---------------------------------------------------------------------------------------------------------------------------------------------------------

	-- proc MoLichThi: lap lich thi theo ma lop
	-- note1: ngay mo mon (ngay 1 thang 6/8/10); ngay bat dau hoc (ngay 15 thang 6/8/10) + 3 thang = ngay ket thuc (ngay 15 thang 9/11/1(nam sau)); ngay thi (ngay 21 -> 28 thang 9/11/1(nam sau))
	-- note2: 3 ca thi --> sang (8h) + trua chieu (13h) + toi (18h)

create or alter proc MoLichThi
	@malh char(8),
	@diadiem varchar(50),
	@ngaythi varchar (50) -- format: yyyy-mm-dd hh:mm:ss
as
begin
	if exists (select * from Lop where MaLop = @malh)
	begin
		if exists (select * from DangKy where MaLop = @malh) and (select Soluong from Lop where MaLop = @malh) > 0
		begin
			if exists (select * from LichSuThi where MaLop = @malh and NgayThi = cast(@ngaythi as datetime) and DiaDiem = @diadiem)
				raiserror (N'Lớp học này đã có lịch thi', 16, 1)
			else if exists (select * from LichSuThi where MaLop != @malh and NgayThi = cast(@ngaythi as datetime) and DiaDiem = @diadiem)
				raiserror (N'Thời gian và địa điểm thi bị trùng với lịch thi của lớp khác', 16, 1)
			else
			begin

				declare @ngaybatdauthi date
				set @ngaybatdauthi = (select dateadd(day, 20, dateadd(month, 3, NgayMo)) from Lop where MaLop = @malh)

				if ((cast(@ngaythi as date) >= @ngaybatdauthi) and (cast(@ngaythi as date) <= dateadd(day, 7, @ngaythi)))
				-- note: neu ngay thi trong khoang tu 21 --> 28
				begin
					declare @mahv char(8)
					declare c cursor for select MaHV from DangKy where MaLop = @malh
					open c
					fetch next from c into @mahv

					while (@@FETCH_STATUS = 0)
					begin
						insert into LichSuThi (MaHV, MaLop, NgayThi, DiaDiem)
						values (@mahv, @malh, cast(@ngaythi as datetime), @diadiem)

						fetch next from c into @mahv
					end
					close c
					deallocate c
				end
				else
					raiserror (N'Ngày thi phải từ ngày 21 --> 28 trong tháng!', 16, 1)
			end

		end
		else	
			raiserror (N'Lớp học này chưa có học viên đăng ký!', 16, 1)
	end
	else
		raiserror (N'Lớp học không tồn tại!', 16, 1)
end
go
	
