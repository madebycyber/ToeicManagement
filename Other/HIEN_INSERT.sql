
/****** HIEN LE ******/
INSERT [dbo].[BAITHI] ([MaBT], [NgayLap], [TenBaiThi], [NgayThi], [TGLamBai], [TongDiem]) VALUES (1, CAST(N'2025-06-01' AS Date), N'TOEIC Test 1', CAST(N'2025-06-15' AS Date), N'120       ', N'990       ')
INSERT [dbo].[BAITHI] ([MaBT], [NgayLap], [TenBaiThi], [NgayThi], [TGLamBai], [TongDiem]) VALUES (2, CAST(N'2025-06-05' AS Date), N'TOEIC Test 2', CAST(N'2025-06-20' AS Date), N'120       ', N'850       ')
INSERT [dbo].[BAITHI] ([MaBT], [NgayLap], [TenBaiThi], [NgayThi], [TGLamBai], [TongDiem]) VALUES (3, CAST(N'2025-06-10' AS Date), N'TOEIC Test 3', CAST(N'2025-06-25' AS Date), N'120       ', N'900       ')
INSERT [dbo].[BAITHI] ([MaBT], [NgayLap], [TenBaiThi], [NgayThi], [TGLamBai], [TongDiem]) VALUES (4, CAST(N'2025-06-12' AS Date), N'TOEIC Test 4', CAST(N'2025-06-30' AS Date), N'120       ', N'950       ')
INSERT [dbo].[BAITHI] ([MaBT], [NgayLap], [TenBaiThi], [NgayThi], [TGLamBai], [TongDiem]) VALUES (5, CAST(N'2025-06-15' AS Date), N'TOEIC Test 5', CAST(N'2025-07-05' AS Date), N'120       ', N'870       ')
INSERT INTO [dbo].[BAITHI] ([MaBT], [NgayLap], [TenBaiThi], [NgayThi], [TGLamBai], [TongDiem])
VALUES
    (6, CAST(N'2025-06-06' AS Date), N'TOEIC Test 6', CAST(N'2025-06-20' AS Date), N'135       ', N'965       '),
    (7, CAST(N'2025-06-07' AS Date), N'TOEIC Test 7', CAST(N'2025-06-21' AS Date), N'140       ', N'960       '),
    (8, CAST(N'2025-06-08' AS Date), N'TOEIC Test 8', CAST(N'2025-06-22' AS Date), N'145       ', N'955       '),
    (9, CAST(N'2025-06-09' AS Date), N'TOEIC Test 9', CAST(N'2025-06-23' AS Date), N'150       ', N'950       '),
    (10, CAST(N'2025-06-10' AS Date), N'TOEIC Test 10', CAST(N'2025-06-24' AS Date), N'155       ', N'945       '),
    (11, CAST(N'2025-06-11' AS Date), N'TOEIC Test 11', CAST(N'2025-06-25' AS Date), N'160       ', N'940       '),
    (12, CAST(N'2025-06-12' AS Date), N'TOEIC Test 12', CAST(N'2025-06-26' AS Date), N'165       ', N'935       '),
    (13, CAST(N'2025-06-13' AS Date), N'TOEIC Test 13', CAST(N'2025-06-27' AS Date), N'170       ', N'930       '),
    (14, CAST(N'2025-06-14' AS Date), N'TOEIC Test 14', CAST(N'2025-06-28' AS Date), N'175       ', N'925       '),
    (15, CAST(N'2025-06-15' AS Date), N'TOEIC Test 15', CAST(N'2025-06-29' AS Date), N'180       ', N'920       '),
    (16, CAST(N'2025-06-16' AS Date), N'TOEIC Test 16', CAST(N'2025-06-30' AS Date), N'185       ', N'915       '),
    (17, CAST(N'2025-06-17' AS Date), N'TOEIC Test 17', CAST(N'2025-06-01' AS Date), N'190       ', N'910       '),
    (18, CAST(N'2025-06-18' AS Date), N'TOEIC Test 18', CAST(N'2025-06-02' AS Date), N'195       ', N'905       '),
    (19, CAST(N'2025-06-19' AS Date), N'TOEIC Test 19', CAST(N'2025-06-03' AS Date), N'200       ', N'900       '),
    (20, CAST(N'2025-06-20' AS Date), N'TOEIC Test 20', CAST(N'2025-06-04' AS Date), N'205       ', N'895       '),
    (21, CAST(N'2025-06-21' AS Date), N'TOEIC Test 21', CAST(N'2025-06-05' AS Date), N'210       ', N'890       '),
    (22, CAST(N'2025-06-22' AS Date), N'TOEIC Test 22', CAST(N'2025-06-06' AS Date), N'215       ', N'885       '),
    (23, CAST(N'2025-06-23' AS Date), N'TOEIC Test 23', CAST(N'2025-06-07' AS Date), N'220       ', N'880       '),
    (24, CAST(N'2025-06-24' AS Date), N'TOEIC Test 24', CAST(N'2025-06-08' AS Date), N'225       ', N'875       '),
    (25, CAST(N'2025-06-25' AS Date), N'TOEIC Test 25', CAST(N'2025-06-09' AS Date), N'230       ', N'870       '),
    (26, CAST(N'2025-06-26' AS Date), N'TOEIC Test 26', CAST(N'2025-06-10' AS Date), N'235       ', N'865       '),
    (27, CAST(N'2025-06-27' AS Date), N'TOEIC Test 27', CAST(N'2025-06-11' AS Date), N'240       ', N'860       '),
    (28, CAST(N'2025-06-28' AS Date), N'TOEIC Test 28', CAST(N'2025-06-12' AS Date), N'245       ', N'855       '),
    (29, CAST(N'2025-06-29' AS Date), N'TOEIC Test 29', CAST(N'2025-06-13' AS Date), N'250       ', N'850       '),
    (30, CAST(N'2025-06-30' AS Date), N'TOEIC Test 30', CAST(N'2025-06-14' AS Date), N'255       ', N'845       ');
GO

INSERT [dbo].[DONDENGHITAODD] ([MaDDN], [TenNguoiDN], [ChucVu], [DonVi], [NgayVietDon], [TenDienDanDeXuat], [MucDich], [NoiDung], [HinhThucTrienKhai], [LoiIchKyVong]) VALUES (1, N'Nguyễn Văn A', N'Giảng viên', N'Khoa Ngoại ngữ', CAST(N'2025-06-01' AS Date), N'Thảo luận TOEIC Listening', N'Hỗ trợ học viên', N'Tạo không gian thảo luận', N'Trực tuyến', N'Nâng cao kỹ năng Listening')
INSERT [dbo].[DONDENGHITAODD] ([MaDDN], [TenNguoiDN], [ChucVu], [DonVi], [NgayVietDon], [TenDienDanDeXuat], [MucDich], [NoiDung], [HinhThucTrienKhai], [LoiIchKyVong]) VALUES (2, N'Trần Thị B', N'Giảng viên', N'Khoa Ngoại ngữ', CAST(N'2025-06-02' AS Date), N'Thảo luận TOEIC Reading', N'Chia sẻ tài liệu', N'Tạo diễn đàn nhóm', N'Trực tiếp', N'Cải thiện kỹ năng Reading')
INSERT [dbo].[DONDENGHITAODD] ([MaDDN], [TenNguoiDN], [ChucVu], [DonVi], [NgayVietDon], [TenDienDanDeXuat], [MucDich], [NoiDung], [HinhThucTrienKhai], [LoiIchKyVong]) VALUES (3, N'Lê Văn C', N'Giảng viên', N'Khoa Ngoại ngữ', CAST(N'2025-06-03' AS Date), N'Mẹo thi TOEIC', N'Chia sẻ kinh nghiệm', N'Tổ chức thảo luận', N'Trực tuyến', N'Tăng điểm TOEIC')
INSERT [dbo].[DONDENGHITAODD] ([MaDDN], [TenNguoiDN], [ChucVu], [DonVi], [NgayVietDon], [TenDienDanDeXuat], [MucDich], [NoiDung], [HinhThucTrienKhai], [LoiIchKyVong]) VALUES (4, N'Phạm Thị D', N'Giảng viên', N'Khoa Ngoại ngữ', CAST(N'2025-06-04' AS Date), N'Tài liệu TOEIC', N'Cung cấp tài liệu', N'Tạo kho tài liệu', N'Trực tuyến', N'Hỗ trợ học tập')
INSERT [dbo].[DONDENGHITAODD] ([MaDDN], [TenNguoiDN], [ChucVu], [DonVi], [NgayVietDon], [TenDienDanDeXuat], [MucDich], [NoiDung], [HinhThucTrienKhai], [LoiIchKyVong]) VALUES (5, N'Hoàng Văn E', N'Giảng viên', N'Khoa Ngoại ngữ', CAST(N'2025-06-05' AS Date), N'Hỏi đáp TOEIC', N'Hỗ trợ học viên', N'Tạo kênh hỏi đáp', N'Trực tuyến', N'Giải đáp thắc mắc')
GO

INSERT [dbo].[DIENDAN] ([MaDD], [TieuDe], [NguoiTao], [SoBaiViet], [TrangThai], [HanhDong], [GhiChu], [MaDDN]) VALUES (1, N'Thảo luận TOEIC Listening', N'Nguyễn Văn A', 10, N'Hoạt động', N'Mở', N'Diễn đàn chính', 1)
INSERT [dbo].[DIENDAN] ([MaDD], [TieuDe], [NguoiTao], [SoBaiViet], [TrangThai], [HanhDong], [GhiChu], [MaDDN]) VALUES (2, N'Thảo luận TOEIC Reading', N'Trần Thị B', 8, N'Hoạt động', N'Mở', N'Diễn đàn phụ', 2)
INSERT [dbo].[DIENDAN] ([MaDD], [TieuDe], [NguoiTao], [SoBaiViet], [TrangThai], [HanhDong], [GhiChu], [MaDDN]) VALUES (3, N'Mẹo thi TOEIC', N'Lê Văn C', 15, N'Hoạt động', N'Mở', N'Chia sẻ kinh nghiệm', 3)
INSERT [dbo].[DIENDAN] ([MaDD], [TieuDe], [NguoiTao], [SoBaiViet], [TrangThai], [HanhDong], [GhiChu], [MaDDN]) VALUES (4, N'Tài liệu TOEIC', N'Phạm Thị D', 5, N'Hoạt động', N'Mở', N'Tài liệu mới', 4)
INSERT [dbo].[DIENDAN] ([MaDD], [TieuDe], [NguoiTao], [SoBaiViet], [TrangThai], [HanhDong], [GhiChu], [MaDDN]) VALUES (5, N'Hỏi đáp TOEIC', N'Hoàng Văn E', 12, N'Hoạt động', N'Mở', N'Hỗ trợ học viên', 5)
GO


INSERT [dbo].[BAIVIET] ([MaBV], [TenBV], [NoiDung], [MaDD], [MaNguoiTao]) VALUES (1, N'Bí kíp đạt 900 TOEIC', N'Nội dung chia sẻ kinh nghiệm...', 1, 1)
INSERT [dbo].[BAIVIET] ([MaBV], [TenBV], [NoiDung], [MaDD], [MaNguoiTao]) VALUES (2, N'Mẹo làm bài Listening Part 1', N'Nội dung hướng dẫn chi tiết...', 2, 2)
INSERT [dbo].[BAIVIET] ([MaBV], [TenBV], [NoiDung], [MaDD], [MaNguoiTao]) VALUES (3, N'Hướng dẫn Reading Part 5', N'Nội dung phân tích câu hỏi...', 3, 3)
INSERT [dbo].[BAIVIET] ([MaBV], [TenBV], [NoiDung], [MaDD], [MaNguoiTao]) VALUES (4, N'Tài liệu TOEIC mới nhất', N'Nội dung giới thiệu tài liệu...', 4, 4)
INSERT [dbo].[BAIVIET] ([MaBV], [TenBV], [NoiDung], [MaDD], [MaNguoiTao]) VALUES (5, N'Thảo luận Part 7', N'Nội dung thảo luận nhóm...', 5, 5)
GO
INSERT [dbo].[CHITIETBAITHI] ([MaBT], [MaSV], [PhanThi], [SoCauDung], [DiemSo]) VALUES (1, 1, N'Listening', 45, 450)
INSERT [dbo].[CHITIETBAITHI] ([MaBT], [MaSV], [PhanThi], [SoCauDung], [DiemSo]) VALUES (2, 2, N'Reading', 40, 400)
INSERT [dbo].[CHITIETBAITHI] ([MaBT], [MaSV], [PhanThi], [SoCauDung], [DiemSo]) VALUES (3, 3, N'Listening', 48, 480)
INSERT [dbo].[CHITIETBAITHI] ([MaBT], [MaSV], [PhanThi], [SoCauDung], [DiemSo]) VALUES (4, 4, N'Reading', 42, 420)
INSERT [dbo].[CHITIETBAITHI] ([MaBT], [MaSV], [PhanThi], [SoCauDung], [DiemSo]) VALUES (5, 5, N'Listening', 47, 470)
INSERT INTO [dbo].[CHITIETBAITHI] ([MaBT], [MaSV], [PhanThi], [SoCauDung], [DiemSo])
VALUES
    (2, 1, N'Reading', 48, 480),
    (3, 1, N'Speaking', 50, 500),
    (4, 1, N'Writing', 52, 520),
    (5, 1, N'Listening', 55, 550),
    (6, 1, N'Reading', 58, 580),
    (7, 1, N'Speaking', 60, 600),
    (8, 1, N'Writing', 62, 620),
    (9, 1, N'Listening', 65, 650),
    (10, 1, N'Reading', 68, 680),
    (11, 1, N'Speaking', 70, 700),
    (12, 1, N'Writing', 72, 720),
    (13, 1, N'Listening', 75, 750),
    (14, 1, N'Reading', 78, 780),
    (15, 1, N'Speaking', 80, 800),
    (16, 1, N'Writing', 82, 820),
    (17, 1, N'Listening', 85, 850),
    (18, 1, N'Reading', 88, 880),
    (19, 1, N'Speaking', 90, 900),
    (20, 1, N'Writing', 92, 920),
    (21, 1, N'Listening', 95, 950),
    (22, 1, N'Reading', 97, 970),
    (23, 1, N'Speaking', 100, 1000),
    (24, 1, N'Writing', 98, 980),
    (25, 1, N'Listening', 96, 960),
    (26, 1, N'Reading', 94, 940),
    (27, 1, N'Speaking', 92, 920),
    (28, 1, N'Writing', 90, 900),
    (29, 1, N'Listening', 88, 880),
    (30, 1, N'Reading', 86, 860);
GO
INSERT [dbo].[CHUDETL] ([MaChuDeTL], [TenChuDeTL], [MoTaChuDeTL]) VALUES (1, N'Listening Part 1', N'Chủ đề câu hỏi mô tả hình ảnh')
INSERT [dbo].[CHUDETL] ([MaChuDeTL], [TenChuDeTL], [MoTaChuDeTL]) VALUES (2, N'Listening Part 2', N'Chủ đề câu hỏi trả lời')
INSERT [dbo].[CHUDETL] ([MaChuDeTL], [TenChuDeTL], [MoTaChuDeTL]) VALUES (3, N'Reading Part 5', N'Chủ đề câu hỏi ngữ pháp')
INSERT [dbo].[CHUDETL] ([MaChuDeTL], [TenChuDeTL], [MoTaChuDeTL]) VALUES (4, N'Reading Part 6', N'Chủ đề điền từ vào đoạn văn')
INSERT [dbo].[CHUDETL] ([MaChuDeTL], [TenChuDeTL], [MoTaChuDeTL]) VALUES (5, N'Reading Part 7', N'Chủ đề đọc hiểu đoạn văn')
GO
INSERT [dbo].[DETHI] ([id_DeThi], [LoaiDde], [HinhThuc], [ThoiGian]) VALUES (1, N'TOEIC', N'Trắc nghiệm', 120)
INSERT [dbo].[DETHI] ([id_DeThi], [LoaiDde], [HinhThuc], [ThoiGian]) VALUES (2, N'TOEIC', N'Trắc nghiệm', 120)
INSERT [dbo].[DETHI] ([id_DeThi], [LoaiDde], [HinhThuc], [ThoiGian]) VALUES (3, N'TOEIC', N'Trắc nghiệm', 120)
INSERT [dbo].[DETHI] ([id_DeThi], [LoaiDde], [HinhThuc], [ThoiGian]) VALUES (4, N'TOEIC', N'Trắc nghiệm', 120)
INSERT [dbo].[DETHI] ([id_DeThi], [LoaiDde], [HinhThuc], [ThoiGian]) VALUES (5, N'TOEIC', N'Trắc nghiệm', 120)
GO

INSERT [dbo].[DONKHIEUNAI] ([MaDon], [CauSo], [HinhThucCauHoi], [MoTaSaiSot], [DeNghiXemXet], [NguoiLap], [MaBT], [MaSV]) VALUES (1, 1, N'Trắc nghiệm', N'Đáp án sai', N'Xem lại đáp án', N'Nguyễn Văn A', 1, 1)
INSERT [dbo].[DONKHIEUNAI] ([MaDon], [CauSo], [HinhThucCauHoi], [MoTaSaiSot], [DeNghiXemXet], [NguoiLap], [MaBT], [MaSV]) VALUES (2, 2, N'Trắc nghiệm', N'Âm thanh không rõ', N'Kiểm tra audio', N'Trần Thị B', 2, 2)
INSERT [dbo].[DONKHIEUNAI] ([MaDon], [CauSo], [HinhThucCauHoi], [MoTaSaiSot], [DeNghiXemXet], [NguoiLap], [MaBT], [MaSV]) VALUES (3, 3, N'Trắc nghiệm', N'Câu hỏi không rõ', N'Chỉnh sửa câu hỏi', N'Lê Văn C', 3, 3)
INSERT [dbo].[DONKHIEUNAI] ([MaDon], [CauSo], [HinhThucCauHoi], [MoTaSaiSot], [DeNghiXemXet], [NguoiLap], [MaBT], [MaSV]) VALUES (4, 4, N'Trắc nghiệm', N'Đáp án trùng', N'Sửa đáp án', N'Phạm Thị D', 4, 4)
INSERT [dbo].[DONKHIEUNAI] ([MaDon], [CauSo], [HinhThucCauHoi], [MoTaSaiSot], [DeNghiXemXet], [NguoiLap], [MaBT], [MaSV]) VALUES (5, 5, N'Trắc nghiệm', N'Chấm điểm sai', N'Chấm lại bài', N'Hoàng Văn E', 5, 5)
GO

INSERT [dbo].[GIAOVIEN_DIENDAN] ([MaDD], [MaGV], [TG_Tao], [TrangThai]) VALUES (1, 1, CAST(N'2025-06-01T10:00:00.000' AS DateTime), N'Hoạt động')
INSERT [dbo].[GIAOVIEN_DIENDAN] ([MaDD], [MaGV], [TG_Tao], [TrangThai]) VALUES (2, 2, CAST(N'2025-06-02T10:00:00.000' AS DateTime), N'Hoạt động')
INSERT [dbo].[GIAOVIEN_DIENDAN] ([MaDD], [MaGV], [TG_Tao], [TrangThai]) VALUES (3, 3, CAST(N'2025-06-03T10:00:00.000' AS DateTime), N'Hoạt động')
INSERT [dbo].[GIAOVIEN_DIENDAN] ([MaDD], [MaGV], [TG_Tao], [TrangThai]) VALUES (4, 4, CAST(N'2025-06-04T10:00:00.000' AS DateTime), N'Hoạt động')
INSERT [dbo].[GIAOVIEN_DIENDAN] ([MaDD], [MaGV], [TG_Tao], [TrangThai]) VALUES (5, 5, CAST(N'2025-06-05T10:00:00.000' AS DateTime), N'Hoạt động')
GO
