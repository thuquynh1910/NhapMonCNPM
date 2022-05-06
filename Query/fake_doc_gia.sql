-- Bảng độc giả

/* CREATE TABLE DOCGIA
(
 MaDocGia char(10)primary key,
 HoTen nvarchar(40),
 DiaChi nvarchar(50),
 email char(30),
 NgayLapThe datetime,
 MaLoaiDocGia char(1) NOT NULL,
) */

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (100) [MaDocGia]
      ,[HoTen]
      ,[DiaChi]
      ,[email]
      ,[NgayLapThe]
      ,[MaLoaiDocGia]
  FROM [QUANLYSACH].[dbo].[DOCGIA]

-- Tạo fake độc giả
INSERT INTO QUANLYSACH.dbo.DOCGIA 
( 
HoTen, 
DiaChi, 
email, 
NgayLapThe, 
MaLoaiDocGia
)
VALUES 
(
N'Trần Anh Tú', 
N'Tân Kiều, Ninh Đa, Ninh Hòa, Khánh Hòa', 
'ichimoku.0902@gmail.com',
'2022-5-6',
'X' 
);