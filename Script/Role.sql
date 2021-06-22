--test
--select CURRENT_USER
-- create ROLE
CREATE ROLE HocVien
CREATE ROLE NVQL_HocVien
CREATE ROLE NVQL_LopHoc
CREATE ROLE ThuNgan
CREATE ROLE Phong_KhaoThi
GO
-- grant priviledges to roles
GRANT SELECT ON HocVien TO HocVien
GRANT SELECT ON LichSuThi TO HocVien
GRANT SELECT ON LichSuTotNghiep TO HocVien
GRANT SELECT ON DangKy TO HocVien, NVQL_LopHoc
GRANT SELECT ON Lop TO HocVien, NVQL_LopHoc
GRANT SELECT ON MonHoc TO HocVien, NVQL_LopHoc
GRANT SELECT ON NhomMonHoc TO HocVien, NVQL_LopHoc
GRANT SELECT ON ChungChi TO HocVien, NVQL_LopHoc

-------------------------HOCVIEN
-- create user
CREATE USER [HV000006] WITH PASSWORD='H881frGF5OZF'
GO

-- add role to users
ALTER ROLE HocVien ADD MEMBER HV000006
GO

-------------------------NVQL LOP HOC
-- create user
CREATE USER [QLLH0001] WITH PASSWORD='H2CPk4tIK'
GO

-- add role to users
ALTER ROLE NVQL_LopHoc ADD MEMBER QLLH0001
GO