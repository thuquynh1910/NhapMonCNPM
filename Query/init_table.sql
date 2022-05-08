CREATE DATABASE QUANLYSACH;

-- Bảng thủ thư
-- Chứ tài khoản, mật khẩu
CREATE TABLE THUTHU 
(
	TaiKhoan char(30)primary key,
	MatKhau char(30),
	HoVaTen nvarchar(40),
	NgaySinh datetime,
	DiaChi nvarchar(100),
	Avatar VARBINARY(MAX)
)

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
 )


CREATE TABLE DOCGIA
(
 MaDocGia int NOT NULL IDENTITY(1, 1),
 HoTen nvarchar(40),
 DiaChi nvarchar(50),
 Email char(30),
 NgayLapThe datetime,
 NgayHetHan datetime,
 MaLoaiDocGia char(1) NOT NULL,
 PRIMARY KEY (MaDocGia)
)

CREATE TABLE QDTHEDOCGIA
(
TuoiToiThieu char(5),
TuoiToiDa char(5),
ThoiGianSuDung char(10)
)


CREATE TABLE LOAIDOCGIA
(
MaLoaiDocGia char(10) primary key,
TenLoaiDocGia char(10) ,
);

CREATE TABLE THELOAI
(
MaTheLoai char(10) primary key,
TenTheLoai char(20)
);

CREATE TABLE PHIEUMUONSACH
(
MaDocGia char(10)primary key,
MaSach char(10),
NgayMuonSach datetime,
NgayTraSach datetime
);

CREATE TABLE BAOCAOTRATRE
(
MaSach char(10)primary key,
NgayMuon datetime,
NgayTra datetime,
SoNgayTraTre int
)


CREATE TABLE QDMUONTRA
(
	SoSachMuonToiDa int,
	NgayMuonToiDa int
)

ALTER TABLE QDMUONTRA ADD TienPhat money;

CREATE TABLE BAOCAOLUOTMUON
(
Thang   smallint,
TenTheLoai varchar(40),
SoLuotMuon smallint,
TiLe    smallint,
TongLuotMuon smallint,
)

CREATE TABLE TINHTRANG
(
MaTinhTrang char (8),
TenTinhTrang varchar (50),
CONSTRAINT PK_TT PRIMARY KEY (MaTinhTrang)
)