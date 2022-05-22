SELECT * FROM SACH

INSERT INTO QUANLYSACH.dbo.SACH 
(TenSach, Matheloai, TacGia, NhaXuatBan, NamXuatBan, NgayNhap, KhoangCachXuatBan, MaTinhTrang)
OUTPUT INSERTED.MaSach
VALUES (N'Chiến Binh Cầu Vồng', 'TL0002', N'Andrea Hirata',N'Hội Nhà Văn' ,2020, '2022-5-21', 5, 'TT0003');

INSERT INTO QUANLYSACH.dbo.SACH 
(TenSach, Matheloai, TacGia, NhaXuatBan, NamXuatBan, NgayNhap, KhoangCachXuatBan, MaTinhTrang)
OUTPUT INSERTED.MaSach
VALUES (N'Bắt Trẻ Đồng Xanh', 'TL0002', N'Jerome David Salinger',N'Hội Nhà Văn' ,2020, '2022-5-21', 2, 'TT0003');

INSERT INTO QUANLYSACH.dbo.SACH 
(TenSach, Matheloai, TacGia, NhaXuatBan, NamXuatBan, NgayNhap, KhoangCachXuatBan, MaTinhTrang)
OUTPUT INSERTED.MaSach
VALUES (N'ĐÀM ĐẠO VỚI LÃO TỬ ', 'TL0002', N'Lưu Ngôn', N'Văn Học' ,2021, '2022-5-21', 1, 'TT0003');

INSERT INTO QUANLYSACH.dbo.SACH 
(TenSach, Matheloai, TacGia, NhaXuatBan, NamXuatBan, NgayNhap, KhoangCachXuatBan, MaTinhTrang)
OUTPUT INSERTED.MaSach
VALUES (N'Ly ca', 'TL0003', N'Đỗ Doãn Phương', N'Hội Nhà Văn' ,2021, '2022-5-21', 1, 'TT0003');

INSERT INTO QUANLYSACH.dbo.SACH 
(TenSach, Matheloai, TacGia, NhaXuatBan, NamXuatBan, NgayNhap, KhoangCachXuatBan, MaTinhTrang)
OUTPUT INSERTED.MaSach
VALUES (N'Thất Lạc Cõi Người ', 'TL0002', N'Dazai Osamu', N'Văn Học' ,2022, '2022-5-21', 0, 'TT0003');