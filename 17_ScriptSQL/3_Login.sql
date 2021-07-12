execute sp_configure 'contained database authentication',1
Reconfigure
go
USE [master]
GO
ALTER DATABASE [TT_TinHoc] SET CONTAINMENT = PARTIAL WITH NO_WAIT
GO
USE [TT_TinHoc]
GO
CREATE USER [admin] WITH PASSWORD='Admin123'
GO
ALTER ROLE db_owner ADD MEMBER admin
GO
-- test
--Select name,principal_id from sys.database_principals 
--select * from  sys.database_role_members 
--GO
--select CURRENT_USER
