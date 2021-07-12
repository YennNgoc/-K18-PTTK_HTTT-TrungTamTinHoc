create or alter trigger tr_insert_check_NgayDK
on DangKy
instead of insert
as
begin
	declare @mahv char(8)
	declare @malh char(8)
	declare @ngaydk date
	set @mahv = (select MaHV from inserted)
	set @malh = (select MaLop from inserted)
	set @ngaydk = getdate()

	if exists(select * from HocVien where MaHV = @mahv) 
	and exists (select * from Lop where MaLop = @malh and @ngaydk >= NgayMo and @ngaydk <= DATEADD(day, 7, NgayMo))
	begin
		insert into DangKy
		select * from inserted where NgayDangKy = @ngaydk and MaHV = @mahv and MaLop = @malh

		declare @sl int
		set @sl = (select Soluong from Lop where MaLop = @malh)
		update Lop
		set Soluong = (@sl + 1) where MaLop = @malh
	end
	else
		raiserror(N'Thông tin không hợp lệ!', 16, 1)
end
go

--drop trigger tr_insert_check_NgayDK
--go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	-- ngay thanh toan > ngay dang ky mon --> proc LapHD o file ThuNgan_func.sql
	-- note: su dung func tbDSHP o file ThuNgan_func.sql
	-- Role NV (thu ngan)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	-- ngay thi > ngay mo lop --> proc MoLichThi o file KhaoThi_func.sql
	-- note1: ngay mo mon (ngay 1 thang 6/8/10); ngay bat dau hoc (ngay 15 thang 6/8/10) + 3 thang = ngay ket thuc (ngay 15 thang 9/11/1(nam sau)); ngay thi (ngay 21 -> 28 thang 9/11/1(nam sau))
	-- note2: 3 ca thi --> sang (8h) + trua chieu (13h) + toi (18h)
	-- role: NV Khao Thi

---------------------------------------------------------------------------------------------------------------------------------------------------------------------

	-- max(lop) = 30 hoc vien
alter table Lop
add constraint Check_SL
check (SoLuong >=0 and SoLuong <= 30)
go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

	-- tong tien hoa don --> proc LapHD o file ThuNgan_func.sql

-------------------------------------------------------------------------------------------------------------------------------------------------------------------

	-- func tb_Mon: tra ve MaChungChi, MaNhomMH, MaMH, MaLop va Diem thi cua @mahv
create function tb_Mon
(
	@mahv char (8)
)
returns table 
as
return
	select ls.MaHV, nmh.MaChungChi, mh.MaNhomMH, lh.MaMH, ls.MaLop, ls.Diem from LichSuThi ls join Lop lh on ls.MaLop = lh.MaLop
	join MonHoc mh on lh.MaMH = mh.MaMH join NhomMonHoc nmh on mh.MaNhomMH = nmh.MaNhomMH
	where ls.MaHV = @mahv
go

--drop function tb_Mon
--go

select * from tb_Mon ('HV000001')
go

----------------------------------------------------------------------------------------------------------------------------------------------------------------

	-- func tb_TongSoMH_NMH(): tra ve tong so mon hoc cua nhom mon hoc
create function tb_TongSoMH_NMH()
returns table
as
return
	select mh.MaNhomMH, nmh.TenNhomMH, count(mh.MaMH) as SoMH from MonHoc mh join NhomMonHoc nmh on mh.MaNhomMH = nmh.MaNhomMH
	group by mh.MaNhomMH, nmh.TenNhomMH
go

select * from tb_TongSoMH_NMH()
go
--drop function tb_TongSoMH_NMH

-----------------------------------------------------------------------------------------------------------------------------------------------------------

	-- func tb_TongSoNMH_CC(): tra ve tong so nhom mon hoc cua chung chi
create function tb_TongSoNMH_CC()
returns table
as
return
	select nmh.MaChungChi, cc.TenChungChi, count(nmh.MaNhomMH) as SoNMH from NhomMonHoc nmh join ChungChi cc on nmh.MaChungChi = cc.MaChungChi
	group by nmh.MaChungChi, cc.TenChungChi
go

select * from tb_TongSoNMH_CC()
go
--drop function tb_TongSoNMH_CC

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

	-- proc XetTN: xet tot nghiep cho hoc vien
	-- Role: QLHV

	-- vd: chung chi A co tong cong 3 Nhom mon hoc 1 2 3
	--		+ pass nhom 1: NgayNhan = getdate(1), MaHV = @mahv, MaChungChi = @macc, TrangThai = 'Da hoan thanh nhom 1'
	--		+ pass nhom 2: NgayNhan = getdate(2), MaHV = @mahv, MaChungChi = @macc, TrangThai = 'Da hoan thanh nhom 2'
	--		+ pass nhom 3: NgayNhan = getdate(2), MaHV = @mahv, MaChungChi = @macc, TrangThai = 'Da hoan thanh nhom 3'
	--					   NgayNhan = getdate(3), MaHV = @mahv, MaChungChi = @macc, TrangThai = 'Da hoan thanh chung chi A'
	
	-- xet dat MH: diem thi >=5
	select * from MonHoc where MaNhomMH = 'NHOMCA01'
	-- xet dat NMH: @somondat = @tongsomon (loop)
	--		+ @somondat: tong so mon ma hoc vien da dat, neu sinh vien hoc 2 lop khac nhau nhung cung 1 mon --> lay diem cao nhat
	--		+ @tongsomon: tong so mon trong NMH

	-- xet dat chung chi: 
	--		+ Lop KTV: dat tat ca cac nhom mon hoc cua chung chi @sonmhdat = @tongsonmh
	--			- @sonmhdat: tong so nhom hoc phan hoc vien da dat
	--			- @tongsonmh: tong so NMH trong chung chi
	--		+ Lop chung chi tin hoc: A (3 mon hoc), B (2 mon hoc)
	--		+ Lop chuyen de: khong co tot nghiep

	-- neu du dieu kien dat (nhom mon hoc), xet tb LichSuTotNghiep:
	--		+ neu khong co du lieu @mahv + @macc: insert into table voi TrangThai = 'Da hoan thanh nhom mon hoc @manmh'
	--		+ neu da ton tai du lieu @mahv + @macc: xet TrangThai cua NgayNhan max
	--			- neu TrangThai da co @manmh: skip
	--			- neu TrangThai chua co @manmh va chua dat chung chi: insert into table voi TrangThai + 'Da dat nhom mh @manmh'
	--			- neu TrangThai chua co @manmh va dat chung chi: insert into table voi TrangThai = 'Da dat chung chi @macc'



select * from NhomMonHoc
go


create or alter proc XetTN
	@mahv char(8),
	@macc char(8)
as
begin
	if exists (select * from HocVien where MaHV = @mahv)
	begin
		-- note: lop ktv + lop chung chi tin hoc
		if (@macc is not null)
		begin
			if exists (select * from tb_Mon(@mahv) where MaChungChi = @macc)
			begin
				declare @somondat int
				declare @tongsomon int
				declare @tongsonmh int
				declare @dem int
				declare @trangthai varchar(50)
				declare @sonmhdat int
				declare @manmh char(8)

				-- note: lop ktv
				if (left(@macc, 5) = 'CCKTV')
				begin
					declare c1 cursor for select distinct MaNhomMH from tb_Mon(@mahv) where MaChungChi = @macc
				
					open c1
					fetch next from c1 into @manmh
					while(@@FETCH_STATUS = 0)
					begin
						-- dem so nhom mh dat
						set @sonmhdat = 0
						-- xet so mon dat cua NMH = tong cac mon co diem thi >=5, neu hoc 1 mon nhieu lan thi lay diem cao nhat
						set @somondat = (select count(*) from tb_Mon(@mahv) tb1 where tb1.MaNhomMH = @manmh and tb1.Diem >= 5 
										and tb1.Diem = (select max(tb2.Diem) from tb_Mon(@mahv) tb2 where tb2.MaMH = tb1.MaMH))
					
						-- xet tong so mon hoc cua 1 NMH
						set @tongsomon = (select SoMH from tb_TongSoMH_NMH() where MaNhomMH = @manmh)

						-- xet tong so nhom mon hoc cua 1 chung chi
						set @tongsonmh = (select SoNMH from tb_TongSoNMH_CC() where MaChungChi = @macc)
					
						-- xet so NMH dat
						if (@somondat = @tongsomon)
						begin
							set @dem = (select count(*) from LichSuTotNghiep where MaHV = @mahv and MaChungChi = @macc)

							if exists (select * from LichSuTotNghiep where MaHV = @mahv and MaChungChi = @macc and CHARINDEX(@manmh, TrangThai) <> 0) 
								raiserror (N'Học viên đã đạt nhóm học phần này!', 16, 1)
							else if exists (select * from LichSuTotNghiep where MaHV = @mahv and MaChungChi = @macc and CHARINDEX(@macc, TrangThai) <> 0) 
								raiserror (N'Học viên đã đạt chứng chỉ này!', 16, 1)
							else
							begin
								if (@dem = 0)
									set @sonmhdat = @sonmhdat + 1
								else
									set @sonmhdat = @sonmhdat + @dem + 1

								set @trangthai = N'Đã đạt nhóm học phần ' + cast(@manmh as varchar)
								insert into LichSuTotNghiep values (getdate(), @mahv, @trangthai)
								if (@somondat = @tongsonmh)
								begin
									set @trangthai = N'Đã hoàn thành chứng chỉ ' + cast(@macc as varchar)
									insert into LichSuTotNghiep values (getdate(), @mahv, @trangthai)
								end
							end
						end

						fetch next from c1 into @manmh
					end

					close c1
					deallocate c1
				end

				-- note: lop chung chi tin hoc
				else
				begin
					-- dem so nhom mh dat
					set @sonmhdat = 0
					-- xet so mon dat cua NMH = tong cac mon co diem thi >=5, neu hoc 1 mon nhieu lan thi lay diem cao nhat
					set @somondat = (select count(*) from tb_Mon(@mahv) tb1 where tb1.MaNhomMH = @manmh and tb1.Diem >= 5 
									and tb1.Diem = (select max(tb2.Diem) from tb_Mon(@mahv) tb2 where tb2.MaMH = tb1.MaMH))
					
					-- xet tong so mon hoc cua 1 NMH
					set @tongsomon = (select SoMH from tb_TongSoMH_NMH() where MaNhomMH = @manmh)

					-- xet tong so nhom mon hoc cua 1 chung chi
					set @tongsonmh = (select SoNMH from tb_TongSoNMH_CC() where MaChungChi = @macc)
					
					-- xet so NMH dat
					if (@somondat = @tongsomon)
					begin
						set @dem = (select count(*) from LichSuTotNghiep where MaHV = @mahv and MaChungChi = @macc)

						if exists (select * from LichSuTotNghiep where MaHV = @mahv and MaChungChi = @macc and CHARINDEX(@manmh, TrangThai) <> 0) 
							raiserror (N'Học viên đã đạt nhóm học phần này!', 16, 1)
						else if exists (select * from LichSuTotNghiep where MaHV = @mahv and MaChungChi = @macc and CHARINDEX(@macc, TrangThai) <> 0) 
							raiserror (N'Học viên đã đạt chứng chỉ này!', 16, 1)
						else
						begin
							if (@dem = 0)
								set @sonmhdat = @sonmhdat + 1
							else
								set @sonmhdat = @sonmhdat + @dem + 1

							set @trangthai = N'Đã đạt nhóm học phần ' + cast(@manmh as varchar)
							insert into LichSuTotNghiep values (getdate(), @mahv, @trangthai)
							if (@somondat = @tongsonmh)
							begin
								set @trangthai = N'Đã hoàn thành chứng chỉ ' + cast(@macc as varchar)
								insert into LichSuTotNghiep values (getdate(), @mahv, @trangthai)
							end
						end
					end
				end
			end

			else if exists (select * from ChungChi where MaChungChi = @macc)
				raiserror (N'Học viên chưa đăng ký học môn nào của chứng chỉ này!', 16, 1)

			else
				raiserror (N'Chứng chỉ không tồn tại!', 16, 1)

		end
	end
	else
		raiserror (N'Học viên này không tồn tại!', 16, 1)
end
go

--exec XetTN 'HV000014', 'CCKTVWEB'
--go

-----------------------------------------------------------------------------------------------------------------------------------

	-- proc themNhomMH: nhom chuyen de --> chung chi = null
create or alter proc themNhomMH
	@MaNhom char(8)
as
begin
	if (left(@MaNhom, 6) = 'NHOMCD')
	begin
		update NhomMonHoc
		set MaChungChi = null where MaNhomMH = @MaNhom
	end
end
go
