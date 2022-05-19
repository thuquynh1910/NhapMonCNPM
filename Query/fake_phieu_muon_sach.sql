/*
CREATE TABLE PHIEUMUONSACH
(
MaPhieu int NOT NULL IDENTITY(1, 1),
MaDocGia int NOT NULL,
MaSach int NOT NULL,
NgayMuonSach datetime,
NgayTraSach datetime,
PRIMARY KEY (MaPhieu),
FOREIGN KEY (MaSach) REFERENCES dbo.SACH(MaSach),
FOREIGN KEY (MaDocGia) REFERENCES dbo.DOCGIA(MaDocGia)
);
*/

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [MaPhieu]
      ,[MaDocGia]
      ,[MaSach]
      ,[NgayMuonSach]
      ,[NgayTraSach]
  FROM [QUANLYSACH].[dbo].[PHIEUMUONSACH]

INSERT INTO QUANLYSACH.dbo.PHIEUMUONSACH
( 
MaDocGia, 
MaSach, 
NgayMuonSach, 
NgayTraSach
)
VALUES 
(
'2', 
'3', 
'2022-5-6',
'2022-8-6'
);

SELECT * FROM QUANLYSACH.dbo.PHIEUMUONSACH
