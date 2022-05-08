-- Bảng sách
/*CREATE TABLE SACH
(
CREATE TABLE SACH
(
 MaSach int NOT NULL IDENTITY(1, 1),
 TenSach nvarchar(30),
 Matheloai char(1),
 TacGia nvarchar(50),
 NhaXuatBan nvarchar(100),
 NamXuatBan int,
 NgayNhap datetime,
 KhoangCachXuatBan int,
 MaTinhTrang char(1)
 )*/

 /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [MaSach]
      ,[TenSach]
      ,[Matheloai]
      ,[TacGia]
      ,[NhaXuatBan]
      ,[NamXuatBan]
      ,[NgayNhap]
      ,[KhoangCachXuatBan]
      ,[MaTinhTrang]
  FROM [QUANLYSACH].[dbo].[SACH]

INSERT INTO QUANLYSACH.dbo.SACH 
(TenSach, Matheloai, TacGia, NhaXuatBan, NamXuatBan, NgayNhap, KhoangCachXuatBan, MaTinhTrang)
VALUES (N'Nhà Giả Kim','A',N'Paulo Coelho',N'Nhã Nam',2017,'2022-6-5',5,'T');