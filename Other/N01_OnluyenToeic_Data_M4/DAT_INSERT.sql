USE [TOIEC]
/****** DAT NGUYEN ******/
INSERT [dbo].[PHIEUBAITAPONLUYEN] ([id_PhieuBaiTap], [MaSV], [Lop], [DangCauHoi], [ThoiGianGiao], [ThoiGianNop], [DiemSo], [NhanXet]) VALUES (1, 1, N'Lớp TOEIC A1', N'Trắc nghiệm', CAST(N'2025-06-01T08:00:00.000' AS DateTime), CAST(N'2025-06-02T23:59:00.000' AS DateTime), 80, N'Cần cải thiện Part 1')
INSERT [dbo].[PHIEUBAITAPONLUYEN] ([id_PhieuBaiTap], [MaSV], [Lop], [DangCauHoi], [ThoiGianGiao], [ThoiGianNop], [DiemSo], [NhanXet]) VALUES (2, 2, N'Lớp TOEIC A2', N'Trắc nghiệm', CAST(N'2025-06-02T08:00:00.000' AS DateTime), CAST(N'2025-06-03T23:59:00.000' AS DateTime), 75, N'Tốt ở Part 5')
INSERT [dbo].[PHIEUBAITAPONLUYEN] ([id_PhieuBaiTap], [MaSV], [Lop], [DangCauHoi], [ThoiGianGiao], [ThoiGianNop], [DiemSo], [NhanXet]) VALUES (3, 3, N'Lớp TOEIC B1', N'Trắc nghiệm', CAST(N'2025-06-03T08:00:00.000' AS DateTime), CAST(N'2025-06-04T23:59:00.000' AS DateTime), 90, N'Xuất sắc Part 7')
INSERT [dbo].[PHIEUBAITAPONLUYEN] ([id_PhieuBaiTap], [MaSV], [Lop], [DangCauHoi], [ThoiGianGiao], [ThoiGianNop], [DiemSo], [NhanXet]) VALUES (4, 4, N'Lớp TOEIC B2', N'Trắc nghiệm', CAST(N'2025-06-04T08:00:00.000' AS DateTime), CAST(N'2025-06-05T23:59:00.000' AS DateTime), 70, N'Cần luyện thêm Part 2')
INSERT [dbo].[PHIEUBAITAPONLUYEN] ([id_PhieuBaiTap], [MaSV], [Lop], [DangCauHoi], [ThoiGianGiao], [ThoiGianNop], [DiemSo], [NhanXet]) VALUES (5, 5, N'Lớp TOEIC C1', N'Trắc nghiệm', CAST(N'2025-06-05T08:00:00.000' AS DateTime), CAST(N'2025-06-06T23:59:00.000' AS DateTime), 85, N'Ổn định ở Part 6')
GO
INSERT [dbo].[PHIEUDANGKYTOIEC] ([MaPhieu], [UserID], [TenDonVi], [HoVaTen], [GioiTinh], [NgaySinh], [CCCD], [SoDienThoai], [DiaChiLienHe], [Email], [NoiCongTac], [NgayGioDangKy], [GioThi], [NgayKiemTraKetQua], [LePhiThi], [NgayDangKy]) VALUES (1, 1, N'ĐH Ngoại ngữ', N'Nguyễn Văn A', N'Nam', CAST(N'2000-01-01' AS Date), CAST(123456789012 AS Numeric(12, 0)), CAST(1234567890 AS Numeric(10, 0)), N'123 Đường Láng, Hà Nội', N'a.nguyen@example.com', N'Công ty ABC', CAST(N'2025-06-01T10:00:00.000' AS DateTime), CAST(N'2025-06-15T08:00:00.000' AS DateTime), CAST(N'2025-06-30' AS Date), CAST(1500000.00 AS Decimal(10, 2)), CAST(N'2025-06-01' AS Date))
INSERT [dbo].[PHIEUDANGKYTOIEC] ([MaPhieu], [UserID], [TenDonVi], [HoVaTen], [GioiTinh], [NgaySinh], [CCCD], [SoDienThoai], [DiaChiLienHe], [Email], [NoiCongTac], [NgayGioDangKy], [GioThi], [NgayKiemTraKetQua], [LePhiThi], [NgayDangKy]) VALUES (2, 2, N'ĐH Kinh tế', N'Trần Thị B', N'Nữ', CAST(N'2000-02-02' AS Date), CAST(234567890123 AS Numeric(12, 0)), CAST(2345678901 AS Numeric(10, 0)), N'456 Đường Giải Phóng, Hà Nội', N'b.tran@example.com', N'Công ty XYZ', CAST(N'2025-06-02T10:00:00.000' AS DateTime), CAST(N'2025-06-15T08:00:00.000' AS DateTime), CAST(N'2025-06-30' AS Date), CAST(1500000.00 AS Decimal(10, 2)), CAST(N'2025-06-02' AS Date))
INSERT [dbo].[PHIEUDANGKYTOIEC] ([MaPhieu], [UserID], [TenDonVi], [HoVaTen], [GioiTinh], [NgaySinh], [CCCD], [SoDienThoai], [DiaChiLienHe], [Email], [NoiCongTac], [NgayGioDangKy], [GioThi], [NgayKiemTraKetQua], [LePhiThi], [NgayDangKy]) VALUES (3, 3, N'ĐH Bách khoa', N'Lê Văn C', N'Nam', CAST(N'2000-03-03' AS Date), CAST(345678901234 AS Numeric(12, 0)), CAST(3456789012 AS Numeric(10, 0)), N'789 Đường Nguyễn Trãi, Hà Nội', N'c.le@example.com', N'Công ty DEF', CAST(N'2025-06-03T10:00:00.000' AS DateTime), CAST(N'2025-06-15T08:00:00.000' AS DateTime), CAST(N'2025-06-30' AS Date), CAST(1500000.00 AS Decimal(10, 2)), CAST(N'2025-06-03' AS Date))
INSERT [dbo].[PHIEUDANGKYTOIEC] ([MaPhieu], [UserID], [TenDonVi], [HoVaTen], [GioiTinh], [NgaySinh], [CCCD], [SoDienThoai], [DiaChiLienHe], [Email], [NoiCongTac], [NgayGioDangKy], [GioThi], [NgayKiemTraKetQua], [LePhiThi], [NgayDangKy]) VALUES (4, 4, N'ĐH Sư phạm', N'Phạm Thị D', N'Nữ', CAST(N'2000-04-04' AS Date), CAST(456789012345 AS Numeric(12, 0)), CAST(4567890123 AS Numeric(10, 0)), N'101 Đường Cầu Giấy, Hà Nội', N'd.pham@example.com', N'Công ty GHI', CAST(N'2025-06-04T10:00:00.000' AS DateTime), CAST(N'2025-06-15T08:00:00.000' AS DateTime), CAST(N'2025-06-30' AS Date), CAST(1500000.00 AS Decimal(10, 2)), CAST(N'2025-06-04' AS Date))
INSERT [dbo].[PHIEUDANGKYTOIEC] ([MaPhieu], [UserID], [TenDonVi], [HoVaTen], [GioiTinh], [NgaySinh], [CCCD], [SoDienThoai], [DiaChiLienHe], [Email], [NoiCongTac], [NgayGioDangKy], [GioThi], [NgayKiemTraKetQua], [LePhiThi], [NgayDangKy]) VALUES (5, 5, N'ĐH Y Hà Nội', N'Hoàng Văn E', N'Nam', CAST(N'2000-05-05' AS Date), CAST(567890123456 AS Numeric(12, 0)), CAST(5678901234 AS Numeric(10, 0)), N'202 Đường Tây Sơn, Hà Nội', N'e.hoang@example.com', N'Công ty JKL', CAST(N'2025-06-05T10:00:00.000' AS DateTime), CAST(N'2025-06-15T08:00:00.000' AS DateTime), CAST(N'2025-06-30' AS Date), CAST(1500000.00 AS Decimal(10, 2)), CAST(N'2025-06-05' AS Date))
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [Lop], [Email], [NgaySinh], [DiaChi], [CCCD], [TenDangNhapSv], [MatKhauSV]) VALUES (1, N'Nguyễn Thị An', N'Lớp TOEIC A1', N'an.nguyen@example.com', CAST(N'2002-01-01' AS Date), N'123 Đường Láng, Hà Nội', CAST(123456789012 AS Numeric(12, 0)), N'sv_an', N'password123')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [Lop], [Email], [NgaySinh], [DiaChi], [CCCD], [TenDangNhapSv], [MatKhauSV]) VALUES (2, N'Trần Văn Bình', N'Lớp TOEIC A2', N'binh.tran@example.com', CAST(N'2002-02-02' AS Date), N'456 Đường Giải Phóng, Hà Nội', CAST(234567890123 AS Numeric(12, 0)), N'sv_binh', N'password123')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [Lop], [Email], [NgaySinh], [DiaChi], [CCCD], [TenDangNhapSv], [MatKhauSV]) VALUES (3, N'Lê Thị Cúc', N'Lớp TOEIC B1', N'cuc.le@example.com', CAST(N'2002-03-03' AS Date), N'789 Đường Nguyễn Trãi, Hà Nội', CAST(345678901234 AS Numeric(12, 0)), N'sv_cuc', N'password123')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [Lop], [Email], [NgaySinh], [DiaChi], [CCCD], [TenDangNhapSv], [MatKhauSV]) VALUES (4, N'Phạm Văn Dũng', N'Lớp TOEIC B2', N'dung.pham@example.com', CAST(N'2002-04-04' AS Date), N'101 Đường Cầu Giấy, Hà Nội', CAST(456789012345 AS Numeric(12, 0)), N'sv_dung', N'password123')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [Lop], [Email], [NgaySinh], [DiaChi], [CCCD], [TenDangNhapSv], [MatKhauSV]) VALUES (5, N'Hoàng Thị Em', N'Lớp TOEIC C1', N'em.hoang@example.com', CAST(N'2002-05-05' AS Date), N'202 Đường Tây Sơn, Hà Nội', CAST(567890123456 AS Numeric(12, 0)), N'sv_em', N'password123')
GO
INSERT [dbo].[THAMGIA] ([MaDD], [MaSV], [TGThamGia]) VALUES (1, 1, CAST(N'2025-06-01T10:00:00.000' AS DateTime))
INSERT [dbo].[THAMGIA] ([MaDD], [MaSV], [TGThamGia]) VALUES (2, 2, CAST(N'2025-06-02T10:00:00.000' AS DateTime))
INSERT [dbo].[THAMGIA] ([MaDD], [MaSV], [TGThamGia]) VALUES (3, 3, CAST(N'2025-06-03T10:00:00.000' AS DateTime))
INSERT [dbo].[THAMGIA] ([MaDD], [MaSV], [TGThamGia]) VALUES (4, 4, CAST(N'2025-06-04T10:00:00.000' AS DateTime))
INSERT [dbo].[THAMGIA] ([MaDD], [MaSV], [TGThamGia]) VALUES (5, 5, CAST(N'2025-06-05T10:00:00.000' AS DateTime))
GO
INSERT [dbo].[THONGKELOP] ([id_Thongke], [id_Lop], [TongHocVien], [TrungBinhDiem], [SoTren450], [SoTren600], [NhanXet], [DotThiThu]) VALUES (1, 1, 30, 400, 10, 2, N'Cần cải thiện Listening', N'Đợt 1/2025')
INSERT [dbo].[THONGKELOP] ([id_Thongke], [id_Lop], [TongHocVien], [TrungBinhDiem], [SoTren450], [SoTren600], [NhanXet], [DotThiThu]) VALUES (2, 2, 25, 450, 15, 5, N'Tốt ở Reading', N'Đợt 2/2025')
INSERT [dbo].[THONGKELOP] ([id_Thongke], [id_Lop], [TongHocVien], [TrungBinhDiem], [SoTren450], [SoTren600], [NhanXet], [DotThiThu]) VALUES (3, 3, 20, 500, 18, 8, N'Xuất sắc Part 7', N'Đợt 3/2025')
INSERT [dbo].[THONGKELOP] ([id_Thongke], [id_Lop], [TongHocVien], [TrungBinhDiem], [SoTren450], [SoTren600], [NhanXet], [DotThiThu]) VALUES (4, 4, 28, 420, 12, 3, N'Cần luyện thêm Part 2', N'Đợt 4/2025')
INSERT [dbo].[THONGKELOP] ([id_Thongke], [id_Lop], [TongHocVien], [TrungBinhDiem], [SoTren450], [SoTren600], [NhanXet], [DotThiThu]) VALUES (5, 5, 22, 480, 16, 6, N'Ổn định Part 6', N'Đợt 5/2025')
GO
INSERT [dbo].[TRANGTHAICH] ([MaTT_CH], [TenTT_CH]) VALUES (1, N'Chờ duyệt')
INSERT [dbo].[TRANGTHAICH] ([MaTT_CH], [TenTT_CH]) VALUES (2, N'Đã duyệt')
INSERT [dbo].[TRANGTHAICH] ([MaTT_CH], [TenTT_CH]) VALUES (3, N'Từ chối')
INSERT [dbo].[TRANGTHAICH] ([MaTT_CH], [TenTT_CH]) VALUES (4, N'Cần chỉnh sửa')
INSERT [dbo].[TRANGTHAICH] ([MaTT_CH], [TenTT_CH]) VALUES (5, N'Hoàn tất')
GO
INSERT [dbo].[TRANGTHAIDETHI] ([MaTrangThaiDe], [TenTrangThaiDe]) VALUES (1, N'Chờ duyệt')
INSERT [dbo].[TRANGTHAIDETHI] ([MaTrangThaiDe], [TenTrangThaiDe]) VALUES (2, N'Đã duyệt')
INSERT [dbo].[TRANGTHAIDETHI] ([MaTrangThaiDe], [TenTrangThaiDe]) VALUES (3, N'Từ chối')
INSERT [dbo].[TRANGTHAIDETHI] ([MaTrangThaiDe], [TenTrangThaiDe]) VALUES (4, N'Cần chỉnh sửa')
INSERT [dbo].[TRANGTHAIDETHI] ([MaTrangThaiDe], [TenTrangThaiDe]) VALUES (5, N'Xuất bản')
GO
INSERT [dbo].[TRANGTHAITL] ([MaTT_Tl], [KyHieuTT_TL], [TenTT_TL], [MoTaTT_TL]) VALUES (1, N'CD', N'Chờ duyệt', N'Tài liệu đang chờ kiểm duyệt')
INSERT [dbo].[TRANGTHAITL] ([MaTT_Tl], [KyHieuTT_TL], [TenTT_TL], [MoTaTT_TL]) VALUES (2, N'DD', N'Đã duyệt', N'Tài liệu đã được phê duyệt')
INSERT [dbo].[TRANGTHAITL] ([MaTT_Tl], [KyHieuTT_TL], [TenTT_TL], [MoTaTT_TL]) VALUES (3, N'TC', N'Từ chối', N'Tài liệu bị từ chối')
INSERT [dbo].[TRANGTHAITL] ([MaTT_Tl], [KyHieuTT_TL], [TenTT_TL], [MoTaTT_TL]) VALUES (4, N'CS', N'Cần chỉnh sửa', N'Tài liệu cần chỉnh sửa')
INSERT [dbo].[TRANGTHAITL] ([MaTT_Tl], [KyHieuTT_TL], [TenTT_TL], [MoTaTT_TL]) VALUES (5, N'HT', N'Hoàn tất', N'Tài liệu đã hoàn tất')
GO
INSERT [dbo].[TT_LICHTHITOIEC] ([MaTT_LichThi], [LichThiID], [NgayThi], [GioThuTuc], [GioBatDauLamBai], [LoaiBaiThi]) VALUES (1, 1, CAST(N'2025-06-15' AS Date), CAST(N'2025-06-15T07:00:00.000' AS DateTime), CAST(N'2025-06-15T08:00:00.000' AS DateTime), N'TOEIC Listening & Reading')
INSERT [dbo].[TT_LICHTHITOIEC] ([MaTT_LichThi], [LichThiID], [NgayThi], [GioThuTuc], [GioBatDauLamBai], [LoaiBaiThi]) VALUES (2, 2, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-16T07:00:00.000' AS DateTime), CAST(N'2025-06-16T08:00:00.000' AS DateTime), N'TOEIC Listening & Reading')
INSERT [dbo].[TT_LICHTHITOIEC] ([MaTT_LichThi], [LichThiID], [NgayThi], [GioThuTuc], [GioBatDauLamBai], [LoaiBaiThi]) VALUES (3, 3, CAST(N'2025-06-17' AS Date), CAST(N'2025-06-17T07:00:00.000' AS DateTime), CAST(N'2025-06-17T08:00:00.000' AS DateTime), N'TOEIC Listening & Reading')
INSERT [dbo].[TT_LICHTHITOIEC] ([MaTT_LichThi], [LichThiID], [NgayThi], [GioThuTuc], [GioBatDauLamBai], [LoaiBaiThi]) VALUES (4, 4, CAST(N'2025-06-18' AS Date), CAST(N'2025-06-18T07:00:00.000' AS DateTime), CAST(N'2025-06-18T08:00:00.000' AS DateTime), N'TOEIC Listening & Reading')
INSERT [dbo].[TT_LICHTHITOIEC] ([MaTT_LichThi], [LichThiID], [NgayThi], [GioThuTuc], [GioBatDauLamBai], [LoaiBaiThi]) VALUES (5, 5, CAST(N'2025-06-19' AS Date), CAST(N'2025-06-19T07:00:00.000' AS DateTime), CAST(N'2025-06-19T08:00:00.000' AS DateTime), N'TOEIC Listening & Reading')
GO

