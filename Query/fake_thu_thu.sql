-- Bảng thủ thư
/* CREATE TABLE THUTHU 
(
	TaiKhoan char(30)primary key,
	MatKhau char(30),
	HoVaTen char(40),
	NgaySinh datetime,
	DiaChi char(100),
) */

-- Hiển thị top 100 tài khoản
SELECT TOP (100) [TaiKhoan]
      ,[MatKhau], [HoVaTen], [NgaySinh],[DiaChi]
  FROM [QUANLYSACH].[dbo].[THUTHU]

-- Tại fake tài khoản
INSERT INTO QUANLYSACH.dbo.THUTHU (TaiKhoan, MatKhau, HoVaTen, NgaySinh, DiaChi)
VALUES ('admin@gmail.com', 'Admin123', N'Trần Thu Quỳnh', '2002-10-9', N'Tân Kiều, Ninh Đa, Ninh Hòa, Khánh Hòa');

-- Check đăng nhập
SELECT * FROM THUTHU WHERE TaiKhoan='admin@gmail.com' AND MatKhau='Admin123'
-- SELECT FROM THUTHU WHERE TaiKhoan='" + email + "' AND MatKhau='" + password + "'