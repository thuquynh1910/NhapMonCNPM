-- CREATE TABLE
CREATE DATABASE QUANLYSACH;

-- DELETE DATABASE
/*
USER master;
GO
DROP DATABASE QUANLYSACH;
GO
*/

CREATE TABLE THUTHU 
(
	TaiKhoan CHAR(30) PRIMARY KEY,
	MatKhau CHAR(30),
	HoVaTen NVARCHAR(40),
	NgaySinh DATETIME,
	DiaChi NVARCHAR(100),
	Avatar VARBINARY(MAX)
)

-- Tạo fake tài khoản
INSERT INTO QUANLYSACH.dbo.THUTHU (TaiKhoan, MatKhau, HoVaTen, NgaySinh, DiaChi)
VALUES ('admin@gmail.com', 'Admin123', N'Trần Thu Quỳnh', '2002-10-9', N'Tân Kiều, Ninh Đa, Ninh Hòa, Khánh Hòa');




/* -------------------------------------------------------------------------  */

-- Tạo bảng loại độc giả
CREATE TABLE LOAIDOCGIA
(
MaLoaiDocGia CHAR(6) PRIMARY KEY CONSTRAINT IDLOAIDOCGIA DEFAULT DBO.AUTO_IDLOAIDOCGIA(),
TenLoaiDocGia char(10) ,
);

-- Hàm thêm loại độc giả
INSERT INTO LOAIDOCGIA (TenLoaiDocGia) VALUES ('X')
INSERT INTO LOAIDOCGIA (TenLoaiDocGia) VALUES ('Y')

-- In bảng loại độc giả
-- SELECT * FROM LOAIDOCGIA




/* -------------------------------------------------------------------------  */
-- Tạo bảng độc giả
CREATE TABLE DOCGIA
(
	 MaDocGia CHAR(6) PRIMARY KEY CONSTRAINT IDDOCGIA DEFAULT DBO.AUTO_IDDOCGIA(),
	 HoTen NVARCHAR(40),
	 NgaySinh DATETIME,
	 DiaChi NVARCHAR(50),
	 Email CHAR(30),
	 NgayLapThe DATETIME,
	 MaLoaiDocGia CHAR(6) NOT NULL,
	 FOREIGN KEY (MaLoaiDocGia) REFERENCES dbo.LOAIDOCGIA(MaLoaiDocGia),
)

-- Hàm thêm độc giả
INSERT INTO QUANLYSACH.dbo.DOCGIA 
( 
HoTen, 
NgaySinh,
DiaChi, 
email, 
NgayLapThe, 
MaLoaiDocGia
)
VALUES 
(
N'Trần Anh Tú', 
'2001-9-2',
N'Tân Kiều, Ninh Đa, Ninh Hòa, Khánh Hòa', 
'ichimoku.0902@gmail.com',
'2022-9-2',
'LD0001'
);

-- In bảng loại độc giả
-- SELECT * FROM DOCGIA

-- Hiển thị độc giả với tên loại độc giả
/*
SELECT DG.MaDocGia, DG.HoTen, DG.NgaySinh, DG.DiaChi, DG.Email, DG.NgayLapThe, DG.MaLoaiDocGia, LDG.TenLoaiDocGia, 
FROM DOCGIA DG INNER JOIN LOAIDOCGIA LDG
ON DG.MaLoaiDocGia = LDG.MaLoaiDocGia
*/
-- Kiểm tra độc giả có thể mượn thêm sách hay không
SELECT DG.MaDocGia, PMS.NgayTraSach
FROM DOCGIA DG INNER JOIN PHIEUMUONSACH PMS
ON DG.MaDocGia = PMS.MaDocGia
WHERE PMS.NgayTraSach IS NULL AND PMS.NgayMuonSach > '2022-1-1'

/* -------------------------------------------------------------------------  */

-- Tạo bảng quy định thẻ độc giả
CREATE TABLE QDTHEDOCGIA (
	TuoiToiThieu INT NOT NULL,
	TuoiToiDa INT NOT NULL,
	ThoiGianSuDung INT NOT NULL,
)

-- Đặt quy định mặc định
INSERT INTO QUANLYSACH.dbo.QDTHEDOCGIA(TuoiToiThieu, TuoiToiDa, ThoiGianSuDung) VALUES (18, 55, 90);

-- In bảng QDTHEDOCGIA
-- SELECT * FROM QDTHEDOCGIA



/* -------------------------------------------------------------------------  */

-- Tạo bảng loại độc giả
CREATE TABLE THELOAI
(
MaTheLoai CHAR(6) PRIMARY KEY CONSTRAINT IDTHELOAI DEFAULT DBO.AUTO_IDTHELOAI(),
TenTheLoai NVARCHAR(30) ,
);

-- Hàm thêm loại độc giả
INSERT INTO THELOAI (TenTheLoai) VALUES ('A')
INSERT INTO THELOAI (TenTheLoai) VALUES ('B')
INSERT INTO THELOAI (TenTheLoai) VALUES ('C')

-- In bảng thể loại
-- SELECT * FROM THELOAI

/* -------------------------------------------------------------------------  */

-- Tạo bảng 
CREATE TABLE TINHTRANG
(
MaTinhTrang CHAR(6) PRIMARY KEY CONSTRAINT IDTINHTRANG DEFAULT DBO.AUTO_IDTINHTRANG(),
TenTinhTrang NVARCHAR(30) ,
);

-- Hàm thêm loại độc giả
INSERT INTO TINHTRANG (TenTinhTrang) VALUES (N'Quá Hạn')
INSERT INTO TINHTRANG (TenTinhTrang) VALUES (N'Đã Mượn')
INSERT INTO TINHTRANG (TenTinhTrang) VALUES (N'Chưa cho mượn')

-- In bảng 
-- SELECT * FROM TINHTRANG




/* -------------------------------------------------------------------------  */

CREATE TABLE SACH
(
	MaSach CHAR(6) PRIMARY KEY CONSTRAINT IDSACH DEFAULT DBO.AUTO_IDSACH(),
	TenSach NVARCHAR(60),
	MaTheLoai CHAR(6) NOT NULL,
	TacGia NVARCHAR(50),
	NhaXuatBan NVARCHAR(100),
	NamXuatBan INT,
	NgayNhap DATETIME,
	KhoangCachXuatBan INT,
	MaTinhTrang CHAR(6) NOT NULL,
	FOREIGN KEY (MaTheLoai) REFERENCES dbo.THELOAI(MaTheLoai),
	FOREIGN KEY (MaTinhTrang) REFERENCES dbo.TINHTRANG(MaTinhTrang),
)

INSERT INTO QUANLYSACH.dbo.SACH 
(TenSach, Matheloai, TacGia, NhaXuatBan, NamXuatBan, NgayNhap, KhoangCachXuatBan, MaTinhTrang)
OUTPUT INSERTED.MaSach
VALUES (N'Nhà Giả Kim','TL0001',N'Paulo Coelho',N'Nhã Nam',2017,'2022-6-5', 5, 'TT0003');

-- In bảng sách
-- SELECT * FROM SACH

SELECT * FROM SACH WHERE MaTinhTrang = 'TT0003'


/* -------------------------------------------------------------------------  */

-- Tạo bảng
CREATE TABLE QDMUONTRA (
	SoSachMuonToiDa INT NOT NULL,
	NgayMuonToiDa INT NOT NULL,
)

-- Đặt quy định mặc định
INSERT INTO QUANLYSACH.dbo.QDMUONTRA(SoSachMuonToiDa, NgayMuonToiDa) VALUES (4, 5);

-- In bảng 
-- SELECT * FROM QDMUONTRA


/* -------------------------------------------------------------------------  */

-- Tạo bảng
CREATE TABLE PHIEUMUONSACH
(
	MaPhieu CHAR(6) PRIMARY KEY CONSTRAINT IDPHIEUMUONSACH DEFAULT DBO.AUTO_IDPHIEUMUONSACH(),
	MaDocGia CHAR(6) NOT NULL,
	MaSach CHAR(6) NOT NULL,
	NgayMuonSach DATETIME,
	NgayTraSach DATETIME,
	FOREIGN KEY (MaSach) REFERENCES dbo.SACH(MaSach),
	FOREIGN KEY (MaDocGia) REFERENCES dbo.DOCGIA(MaDocGia)
);

INSERT INTO PHIEUMUONSACH (MaDocGia, MaSach, NgayMuonSach) OUTPUT INSERTED.MaPhieu  VALUES ('DG0001', 'SA0001', '2022-1-2');
UPDATE SACH 
SET SACH.MaTinhTrang = 'TT0002'
WHERE SACH.MaSach = 'SA0001'

-- In bảng 
-- SELECT * FROM PHIEUMUONSACH

-- Trả sách
UPDATE PHIEUMUONSACH
SET PHIEUMUONSACH.NgayTraSach = GETDATE()
WHERE PHIEUMUONSACH.MaPhieu = 'PM0001'

UPDATE SACH 
SET SACH.MaTinhTrang = 'TT0003'
WHERE SACH.MaSach = 'SA0001'

SELECT * FROM SACH