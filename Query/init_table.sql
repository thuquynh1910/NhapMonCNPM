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
 MaSach char(10)primary key,
 TenSach char(30),
 Matheloai char(10),
 TacGia char(50),
 NhaXuatBan char(100),
 NamXuatBan int,
 NgayNhap datetime,
 )
 ALTER TABLE SACH ADD KhoangCachXuatBan int;
 ALTER TABLE SACH ADD MaTinhTrang char;


CREATE TABLE DOCGIA
(
 MaDocGia char(10)primary key,
 HoTen nvarchar(40),
 DiaChi nvarchar(50),
 email char(30),
 NgayLapThe datetime,
 MaLoaiDocGia char(1) NOT NULL,
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