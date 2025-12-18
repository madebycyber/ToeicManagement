USE [TOIEC]
/****** HIEN LE ******/
INSERT [dbo].[BAITHI] ([MaBT], [NgayLap], [TenBaiThi], [NgayThi], [TGLamBai], [TongDiem]) VALUES (1, CAST(N'2025-06-01' AS Date), N'TOEIC Test 1', CAST(N'2025-06-15' AS Date), N'120       ', N'990       ')
INSERT [dbo].[BAITHI] ([MaBT], [NgayLap], [TenBaiThi], [NgayThi], [TGLamBai], [TongDiem]) VALUES (2, CAST(N'2025-06-05' AS Date), N'TOEIC Test 2', CAST(N'2025-06-20' AS Date), N'120       ', N'850       ')
INSERT [dbo].[BAITHI] ([MaBT], [NgayLap], [TenBaiThi], [NgayThi], [TGLamBai], [TongDiem]) VALUES (3, CAST(N'2025-06-10' AS Date), N'TOEIC Test 3', CAST(N'2025-06-25' AS Date), N'120       ', N'900       ')
INSERT [dbo].[BAITHI] ([MaBT], [NgayLap], [TenBaiThi], [NgayThi], [TGLamBai], [TongDiem]) VALUES (4, CAST(N'2025-06-12' AS Date), N'TOEIC Test 4', CAST(N'2025-06-30' AS Date), N'120       ', N'950       ')
INSERT [dbo].[BAITHI] ([MaBT], [NgayLap], [TenBaiThi], [NgayThi], [TGLamBai], [TongDiem]) VALUES (5, CAST(N'2025-06-15' AS Date), N'TOEIC Test 5', CAST(N'2025-07-05' AS Date), N'120       ', N'870       ')
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
INSERT [dbo].[DIENDAN] ([MaDD], [TieuDe], [NguoiTao], [SoBaiViet], [TrangThai], [HanhDong], [GhiChu], [MaDDN]) VALUES (1, N'Thảo luận TOEIC Listening', N'Nguyễn Văn A', 10, N'Hoạt động', N'Mở', N'Diễn đàn chính', 1)
INSERT [dbo].[DIENDAN] ([MaDD], [TieuDe], [NguoiTao], [SoBaiViet], [TrangThai], [HanhDong], [GhiChu], [MaDDN]) VALUES (2, N'Thảo luận TOEIC Reading', N'Trần Thị B', 8, N'Hoạt động', N'Mở', N'Diễn đàn phụ', 2)
INSERT [dbo].[DIENDAN] ([MaDD], [TieuDe], [NguoiTao], [SoBaiViet], [TrangThai], [HanhDong], [GhiChu], [MaDDN]) VALUES (3, N'Mẹo thi TOEIC', N'Lê Văn C', 15, N'Hoạt động', N'Mở', N'Chia sẻ kinh nghiệm', 3)
INSERT [dbo].[DIENDAN] ([MaDD], [TieuDe], [NguoiTao], [SoBaiViet], [TrangThai], [HanhDong], [GhiChu], [MaDDN]) VALUES (4, N'Tài liệu TOEIC', N'Phạm Thị D', 5, N'Hoạt động', N'Mở', N'Tài liệu mới', 4)
INSERT [dbo].[DIENDAN] ([MaDD], [TieuDe], [NguoiTao], [SoBaiViet], [TrangThai], [HanhDong], [GhiChu], [MaDDN]) VALUES (5, N'Hỏi đáp TOEIC', N'Hoàng Văn E', 12, N'Hoạt động', N'Mở', N'Hỗ trợ học viên', 5)
GO
INSERT [dbo].[DONDENGHITAODD] ([MaDDN], [TenNguoiDN], [ChucVu], [DonVi], [NgayVietDon], [TenDienDanDeXuat], [MucDich], [NoiDung], [HinhThucTrienKhai], [LoiIchKyVong]) VALUES (1, N'Nguyễn Văn A', N'Giảng viên', N'Khoa Ngoại ngữ', CAST(N'2025-06-01' AS Date), N'Thảo luận TOEIC Listening', N'Hỗ trợ học viên', N'Tạo không gian thảo luận', N'Trực tuyến', N'Nâng cao kỹ năng Listening')
INSERT [dbo].[DONDENGHITAODD] ([MaDDN], [TenNguoiDN], [ChucVu], [DonVi], [NgayVietDon], [TenDienDanDeXuat], [MucDich], [NoiDung], [HinhThucTrienKhai], [LoiIchKyVong]) VALUES (2, N'Trần Thị B', N'Giảng viên', N'Khoa Ngoại ngữ', CAST(N'2025-06-02' AS Date), N'Thảo luận TOEIC Reading', N'Chia sẻ tài liệu', N'Tạo diễn đàn nhóm', N'Trực tiếp', N'Cải thiện kỹ năng Reading')
INSERT [dbo].[DONDENGHITAODD] ([MaDDN], [TenNguoiDN], [ChucVu], [DonVi], [NgayVietDon], [TenDienDanDeXuat], [MucDich], [NoiDung], [HinhThucTrienKhai], [LoiIchKyVong]) VALUES (3, N'Lê Văn C', N'Giảng viên', N'Khoa Ngoại ngữ', CAST(N'2025-06-03' AS Date), N'Mẹo thi TOEIC', N'Chia sẻ kinh nghiệm', N'Tổ chức thảo luận', N'Trực tuyến', N'Tăng điểm TOEIC')
INSERT [dbo].[DONDENGHITAODD] ([MaDDN], [TenNguoiDN], [ChucVu], [DonVi], [NgayVietDon], [TenDienDanDeXuat], [MucDich], [NoiDung], [HinhThucTrienKhai], [LoiIchKyVong]) VALUES (4, N'Phạm Thị D', N'Giảng viên', N'Khoa Ngoại ngữ', CAST(N'2025-06-04' AS Date), N'Tài liệu TOEIC', N'Cung cấp tài liệu', N'Tạo kho tài liệu', N'Trực tuyến', N'Hỗ trợ học tập')
INSERT [dbo].[DONDENGHITAODD] ([MaDDN], [TenNguoiDN], [ChucVu], [DonVi], [NgayVietDon], [TenDienDanDeXuat], [MucDich], [NoiDung], [HinhThucTrienKhai], [LoiIchKyVong]) VALUES (5, N'Hoàng Văn E', N'Giảng viên', N'Khoa Ngoại ngữ', CAST(N'2025-06-05' AS Date), N'Hỏi đáp TOEIC', N'Hỗ trợ học viên', N'Tạo kênh hỏi đáp', N'Trực tuyến', N'Giải đáp thắc mắc')
GO
INSERT [dbo].[DONKHIEUNAI] ([MaDon], [CauSo], [HinhThucCauHoi], [MoTaSaiSot], [DeNghiXemXet], [NguoiLap], [MaBT], [MaSV]) VALUES (1, 1, N'Trắc nghiệm', N'Đáp án sai', N'Xem lại đáp án', N'Nguyễn Văn A', 1, 1)
INSERT [dbo].[DONKHIEUNAI] ([MaDon], [CauSo], [HinhThucCauHoi], [MoTaSaiSot], [DeNghiXemXet], [NguoiLap], [MaBT], [MaSV]) VALUES (2, 2, N'Trắc nghiệm', N'Âm thanh không rõ', N'Kiểm tra audio', N'Trần Thị B', 2, 2)
INSERT [dbo].[DONKHIEUNAI] ([MaDon], [CauSo], [HinhThucCauHoi], [MoTaSaiSot], [DeNghiXemXet], [NguoiLap], [MaBT], [MaSV]) VALUES (3, 3, N'Trắc nghiệm', N'Câu hỏi không rõ', N'Chỉnh sửa câu hỏi', N'Lê Văn C', 3, 3)
INSERT [dbo].[DONKHIEUNAI] ([MaDon], [CauSo], [HinhThucCauHoi], [MoTaSaiSot], [DeNghiXemXet], [NguoiLap], [MaBT], [MaSV]) VALUES (4, 4, N'Trắc nghiệm', N'Đáp án trùng', N'Sửa đáp án', N'Phạm Thị D', 4, 4)
INSERT [dbo].[DONKHIEUNAI] ([MaDon], [CauSo], [HinhThucCauHoi], [MoTaSaiSot], [DeNghiXemXet], [NguoiLap], [MaBT], [MaSV]) VALUES (5, 5, N'Trắc nghiệm', N'Chấm điểm sai', N'Chấm lại bài', N'Hoàng Văn E', 5, 5)
GO
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGiaoVien], [DiaChi], [SDT], [Email], [CapBac], [ChucVu], [TenDangNhapGV], [MatKhauGV]) VALUES (1, N'Nguyễn Văn A', N'123 Đường Láng, Hà Nội', CAST(1234567890 AS Numeric(10, 0)), N'a.nguyen@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_a', N'password123')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGiaoVien], [DiaChi], [SDT], [Email], [CapBac], [ChucVu], [TenDangNhapGV], [MatKhauGV]) VALUES (2, N'Trần Thị B', N'456 Đường Giải Phóng, Hà Nội', CAST(2345678901 AS Numeric(10, 0)), N'b.tran@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_b', N'password123')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGiaoVien], [DiaChi], [SDT], [Email], [CapBac], [ChucVu], [TenDangNhapGV], [MatKhauGV]) VALUES (3, N'Lê Văn C', N'789 Đường Nguyễn Trãi, Hà Nội', CAST(3456789012 AS Numeric(10, 0)), N'c.le@example.com', N'Tiến sĩ', N'Trưởng bộ môn', N'gv_c', N'password123')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGiaoVien], [DiaChi], [SDT], [Email], [CapBac], [ChucVu], [TenDangNhapGV], [MatKhauGV]) VALUES (4, N'Phạm Thị D', N'101 Đường Cầu Giấy, Hà Nội', CAST(4567890123 AS Numeric(10, 0)), N'd.pham@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_d', N'password123')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGiaoVien], [DiaChi], [SDT], [Email], [CapBac], [ChucVu], [TenDangNhapGV], [MatKhauGV]) VALUES (5, N'Hoàng Văn E', N'202 Đường Tây Sơn, Hà Nội', CAST(5678901234 AS Numeric(10, 0)), N'e.hoang@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_e', N'password123')
GO
INSERT [dbo].[GIAOVIEN_DIENDAN] ([MaDD], [MaGV], [TG_Tao], [TrangThai]) VALUES (1, 1, CAST(N'2025-06-01T10:00:00.000' AS DateTime), N'Hoạt động')
INSERT [dbo].[GIAOVIEN_DIENDAN] ([MaDD], [MaGV], [TG_Tao], [TrangThai]) VALUES (2, 2, CAST(N'2025-06-02T10:00:00.000' AS DateTime), N'Hoạt động')
INSERT [dbo].[GIAOVIEN_DIENDAN] ([MaDD], [MaGV], [TG_Tao], [TrangThai]) VALUES (3, 3, CAST(N'2025-06-03T10:00:00.000' AS DateTime), N'Hoạt động')
INSERT [dbo].[GIAOVIEN_DIENDAN] ([MaDD], [MaGV], [TG_Tao], [TrangThai]) VALUES (4, 4, CAST(N'2025-06-04T10:00:00.000' AS DateTime), N'Hoạt động')
INSERT [dbo].[GIAOVIEN_DIENDAN] ([MaDD], [MaGV], [TG_Tao], [TrangThai]) VALUES (5, 5, CAST(N'2025-06-05T10:00:00.000' AS DateTime), N'Hoạt động')
GO
INSERT [dbo].[KIEMDUYETVIEN] ([MaKDV], [HoTenKDV], [EmailKDV], [TenDangNhapKDV], [MatKhauKDV]) VALUES (1, N'Nguyễn Thị X', N'x.nguyen@example.com', N'kdv_x', N'password123')
INSERT [dbo].[KIEMDUYETVIEN] ([MaKDV], [HoTenKDV], [EmailKDV], [TenDangNhapKDV], [MatKhauKDV]) VALUES (2, N'Trần Văn Y', N'y.tran@example.com', N'kdv_y', N'password123')
INSERT [dbo].[KIEMDUYETVIEN] ([MaKDV], [HoTenKDV], [EmailKDV], [TenDangNhapKDV], [MatKhauKDV]) VALUES (3, N'Lê Thị Z', N'z.le@example.com', N'kdv_z', N'password123')
INSERT [dbo].[KIEMDUYETVIEN] ([MaKDV], [HoTenKDV], [EmailKDV], [TenDangNhapKDV], [MatKhauKDV]) VALUES (4, N'Phạm Văn W', N'w.pham@example.com', N'kdv_w', N'password123')
INSERT [dbo].[KIEMDUYETVIEN] ([MaKDV], [HoTenKDV], [EmailKDV], [TenDangNhapKDV], [MatKhauKDV]) VALUES (5, N'Hoàng Thị V', N'v.hoang@example.com', N'kdv_v', N'password123')
GO