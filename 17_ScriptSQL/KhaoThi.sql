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

--select * from tbDiem('HV000004')
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
					declare c cursor for select MaHV from DangKy where MaLop = @malh and MaHD is not null
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
					raiserror (N'Ngày thi không hợp lệ!', 16, 1)
			end

		end
		else	
			raiserror (N'Lớp học này chưa có học viên đăng ký!', 16, 1)
	end
	else
		raiserror (N'Lớp học không tồn tại!', 16, 1)
end
go
-------------------------------------------------------------
create or alter proc XetToTNghiep
@mahv char(8),
@manhommh char(8)
as
begin
declare @dat as int
Select A.MaHV,B.MaMH,max(A.Diem) from LichSuThi A,Lop B,MonHoc C,NhomMonHoc D where A.MaHV=@mahv and D.MaNhomMH=@manhommh
and A.MaLop=B.MaLop and B.MaMH=C.MaMH and C.MaNhomMH=D.MaNhomMH 
group by A.MaHV,B.MaMH
having max(A.Diem)>=5
set @dat=@@rowcount
declare @result int
if(@dat>=3 and @manhommh='NHOMCA01')
begin
set @result=1
return @result
end;
else if(@dat<3 and @manhommh='NHOMCA01')
begin
set @result=0
return @result
end;
else if((@dat>=2 and @manhommh='NHOMCB01') or(@dat>=2 and @manhommh='NHOMCB02'))
begin
set @result=2
return @result
end;
else if((@dat<2 and @manhommh='NHOMCB01') or(@dat<2 and @manhommh='NHOMCB02'))
begin
set @result=2
return @result
end;
end;
go

--Proc insert tot nghiep
create or alter proc TotNghiep
@masv char(8),
@machungchi char(8),
@ngaynhan datetime
as
begin
declare @manhom char(8)
set @manhom=(Select MaNhomMH from NhomMonHoc where MaChungChi=@machungchi)
declare @ketqua int
exec @ketqua=XetToTNghiep @masv,@manhom
if(@ketqua=1 or @ketqua=2)
begin
insert into LichSuTotNghiep values (@ngaynhan,@masv,@machungchi)
raiserror (N'Đủ điều kiện tốt nghiệp!', 16, 1)
end;
else
raiserror (N'Chưa đủ điều kiện tốt nghiệp!', 16, 1)
end;
go
----Test
exec TotNghiep 'HV000001','CCA00001','1/1/2021'
exec TotNghiep 'HV000002','CCA00001','1/1/2021'

delete  from LichSuTotNghiep
select * FROM LichSuTotNghiep




