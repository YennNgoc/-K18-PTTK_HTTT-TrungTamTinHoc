-- create ROLE
CREATE ROLE HocVien
CREATE ROLE NVQL_HocVien
CREATE ROLE NVQL_LopHoc
CREATE ROLE ThuNgan
CREATE ROLE Phong_KhaoThi
GO
-- grant priviledges to roles
GRANT SELECT ON HocVien TO HocVien
GRANT SELECT, INSERT, UPDATE, DELETE ON HocVien TO NVQL_HocVien
GRANT SELECT ON LichSuThi TO HocVien, Phong_KhaoThi
GRANT SELECT ON LichSuTotNghiep TO HocVien, Phong_KhaoThi
GRANT SELECT ON DangKy TO HocVien, NVQL_LopHoc
GRANT SELECT ON Lop TO HocVien, NVQL_LopHoc
GRANT SELECT ON MonHoc TO HocVien, NVQL_LopHoc
GRANT SELECT ON NhomMonHoc TO HocVien, NVQL_LopHoc
GRANT SELECT ON ChungChi TO HocVien, NVQL_LopHoc, Phong_KhaoThi
GRANT SELECT ON tbDiem TO HocVien, Phong_KhaoThi
GRANT SELECT ON tbDSHPDiem TO ThuNgan
GRANT SELECT ON NhanVien TO NVQL_LopHoc
GRANT SELECT, INSERT, UPDATE, DELETE ON HoaDon TO ThuNgan

-- EXEC HocVien - NVQL_HocVien
GRANT EXEC ON TraCuuThongTin TO HocVien, NVQL_HocVien
GRANT EXEC ON ChinhSuaThongTin TO HocVien, NVQL_HocVien
---------------------------------------
GRANT EXEC ON TraCuuDiem_HV TO HocVien
GRANT EXEC ON TraDiemTheoLop TO HocVien
GRANT EXEC ON DKHP TO HocVien
GRANT EXEC ON TraCuuLSTN TO HocVien
GRANT EXEC ON TraCuuDSLopMo TO HocVien
GRANT EXEC ON TraCuuKQDK TO HocVien
--------------------------------------
GRANT EXEC ON ThemHV TO NVQL_HocVien
GRANT EXEC ON XoaHV TO NVQL_HocVien
-- EXEC HocVien - NVQL_LopHoc
GRANT EXEC ON TraCuu TO NVQL_LopHoc
GRANT EXEC ON ThemHP TO NVQL_LopHoc
GRANT EXEC ON XoaHP TO NVQL_LopHoc
GRANT EXEC ON XemThongTinLop TO NVQL_LopHoc
GRANT EXEC ON CapNhapSL TO NVQL_LopHoc
GRANT EXEC ON ThemLop TO NVQL_LopHoc
GRANT EXEC ON LocLop TO NVQL_LopHoc
-- EXEC HocVien - NVQL_PhongKhaoThi
GRANT EXEC ON TraCuuDiem TO Phong_KhaoThi
GRANT EXEC ON TraCuuDiemTheoLH TO Phong_KhaoThi
GRANT EXEC ON TraCuuDiemTheoNMH TO Phong_KhaoThi
GRANT EXEC ON updateDiem TO Phong_KhaoThi
GRANT EXEC ON MoLichThi TO Phong_KhaoThi
GRANT EXEC ON XetToTNghiep TO Phong_KhaoThi
GRANT EXEC ON TotNghiep TO Phong_KhaoThi
-- EXEC HocVien - NVQL_ThuNgan
GRANT EXEC ON TraCuuHD TO ThuNgan
GRANT EXEC ON TraCuuDSHP TO ThuNgan
GRANT EXEC ON LapHD TO ThuNgan
GRANT EXEC ON tongHD_return TO ThuNgan
GO
-------------------------HOCVIEN
-- create user
CREATE USER [HV000004] WITH PASSWORD='Aloalo123'
GO
-- add role to users
ALTER ROLE HocVien ADD MEMBER HV000004
GO
-------------------------NVQL LOP HOC
-- create user
CREATE USER [QLLH0007] WITH PASSWORD='Quanly07'
GO
-- add role to users
ALTER ROLE NVQL_LopHoc ADD MEMBER QLLH0007
GO
-------------------------NVQL HOC VIEN
-- create user
CREATE USER [QLHV0003] WITH PASSWORD='Aloalo123'
GO
-- add role to users
ALTER ROLE NVQL_HocVien ADD MEMBER QLHV0003
GO
----------------------------NV Khao Thi
CREATE USER [NVKT0001] WITH PASSWORD='Aloalo123'
GO
-- add role to users
ALTER ROLE Phong_KhaoThi ADD MEMBER NVKT0001
GO
----------------------------NV Thu Ngan
CREATE USER [NVTN0002] WITH PASSWORD='Aloalo123'
GO
-- add role to users
ALTER ROLE ThuNgan ADD MEMBER NVTN0002
GO