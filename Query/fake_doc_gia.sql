-- Bảng độc giả

/* CREATE TABLE DOCGIA
(
 MaDocGia int NOT NULL IDENTITY(1, 1),
 HoTen nvarchar(40),
 DiaChi nvarchar(50),
 Email char(30),
 NgayLapThe datetime,
 NgayHetHan datetime,
 MaLoaiDocGia char(1) NOT NULL,
 PRIMARY KEY (MaDocGia)
) */

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [MaDocGia]
      ,[HoTen]
      ,[DiaChi]
      ,[Email]
      ,[NgayLapThe]
      ,[NgayHetHan]
      ,[MaLoaiDocGia]
  FROM [QUANLYSACH].[dbo].[DOCGIA]

-- Tạo fake độc giả
INSERT INTO QUANLYSACH.dbo.DOCGIA 
( 
HoTen, 
DiaChi, 
email, 
NgayLapThe, 
NgayHetHan,
MaLoaiDocGia
)
VALUES 
(
N'Trần Anh Tú', 
N'Tân Kiều, Ninh Đa, Ninh Hòa, Khánh Hòa', 
'ichimoku.0902@gmail.com',
'2022-5-6',
'2022-11-6',
'T' 
);

SELECT * FROM QUANLYSACH.dbo.DOCGIA

SELECT [MaDocGia] FROM QUANLYSACH.dbo.DOCGIA WHERE NgayHetHan <= GETDATE()