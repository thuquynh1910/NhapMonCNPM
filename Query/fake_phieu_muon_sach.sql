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
  FROM [QUANLYSACH].[dbo].[PHIEUMUONSACH]

INSERT INTO PHIEUMUONSACH (MaDocGia, MaSach, NgayMuonSach) VALUES ('2', '3', '2022-1-2');

SELECT * FROM PHIEUMUONSACH

SELECT * FROM PHIEUMUONSACH WHERE MaPhieu = 2 

UPDATE PHIEUMUONSACH SET NgayTraSach = GETDATE() WHERE MaPhieu = 2 