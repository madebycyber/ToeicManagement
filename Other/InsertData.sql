USE [N0130062005]
/****** chung ******/
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [Lop], [Email], [NgaySinh], [DiaChi], [CCCD], [TenDangNhapSv], [MatKhauSV]) VALUES (1, N'Nguyễn Thị An', N'Lớp TOEIC A1', N'an.nguyen@example.com', CAST(N'2002-01-01' AS Date), N'123 Đường Láng, Hà Nội', CAST(123456789012 AS Numeric(12, 0)), N'sv_an', N'password123')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [Lop], [Email], [NgaySinh], [DiaChi], [CCCD], [TenDangNhapSv], [MatKhauSV]) VALUES (2, N'Trần Văn Bình', N'Lớp TOEIC A2', N'binh.tran@example.com', CAST(N'2002-02-02' AS Date), N'456 Đường Giải Phóng, Hà Nội', CAST(234567890123 AS Numeric(12, 0)), N'sv_binh', N'password123')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [Lop], [Email], [NgaySinh], [DiaChi], [CCCD], [TenDangNhapSv], [MatKhauSV]) VALUES (3, N'Lê Thị Cúc', N'Lớp TOEIC B1', N'cuc.le@example.com', CAST(N'2002-03-03' AS Date), N'789 Đường Nguyễn Trãi, Hà Nội', CAST(345678901234 AS Numeric(12, 0)), N'sv_cuc', N'password123')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [Lop], [Email], [NgaySinh], [DiaChi], [CCCD], [TenDangNhapSv], [MatKhauSV]) VALUES (4, N'Phạm Văn Dũng', N'Lớp TOEIC B2', N'dung.pham@example.com', CAST(N'2002-04-04' AS Date), N'101 Đường Cầu Giấy, Hà Nội', CAST(456789012345 AS Numeric(12, 0)), N'sv_dung', N'password123')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTenSV], [Lop], [Email], [NgaySinh], [DiaChi], [CCCD], [TenDangNhapSv], [MatKhauSV]) VALUES (5, N'Hoàng Thị Em', N'Lớp TOEIC C1', N'em.hoang@example.com', CAST(N'2002-05-05' AS Date), N'202 Đường Tây Sơn, Hà Nội', CAST(567890123456 AS Numeric(12, 0)), N'sv_em', N'password123')
GO
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGiaoVien], [DiaChi], [SDT], [Email], [CapBac], [ChucVu], [TenDangNhapGV], [MatKhauGV]) VALUES (1, N'Nguyễn Văn A', N'123 Đường Láng, Hà Nội', CAST(1234567890 AS Numeric(10, 0)), N'a.nguyen@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_a', N'password123')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGiaoVien], [DiaChi], [SDT], [Email], [CapBac], [ChucVu], [TenDangNhapGV], [MatKhauGV]) VALUES (2, N'Trần Thị B', N'456 Đường Giải Phóng, Hà Nội', CAST(2345678901 AS Numeric(10, 0)), N'b.tran@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_b', N'password123')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGiaoVien], [DiaChi], [SDT], [Email], [CapBac], [ChucVu], [TenDangNhapGV], [MatKhauGV]) VALUES (3, N'Lê Văn C', N'789 Đường Nguyễn Trãi, Hà Nội', CAST(3456789012 AS Numeric(10, 0)), N'c.le@example.com', N'Tiến sĩ', N'Trưởng bộ môn', N'gv_c', N'password123')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGiaoVien], [DiaChi], [SDT], [Email], [CapBac], [ChucVu], [TenDangNhapGV], [MatKhauGV]) VALUES (4, N'Phạm Thị D', N'101 Đường Cầu Giấy, Hà Nội', CAST(4567890123 AS Numeric(10, 0)), N'd.pham@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_d', N'password123')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGiaoVien], [DiaChi], [SDT], [Email], [CapBac], [ChucVu], [TenDangNhapGV], [MatKhauGV]) VALUES (5, N'Hoàng Văn E', N'202 Đường Tây Sơn, Hà Nội', CAST(5678901234 AS Numeric(10, 0)), N'e.hoang@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_e', N'password123')
GO
INSERT [dbo].[KIEMDUYETVIEN] ([MaKDV], [HoTenKDV], [EmailKDV], [TenDangNhapKDV], [MatKhauKDV]) VALUES (1, N'Nguyễn Thị X', N'x.nguyen@example.com', N'kdv_x', N'password123')
INSERT [dbo].[KIEMDUYETVIEN] ([MaKDV], [HoTenKDV], [EmailKDV], [TenDangNhapKDV], [MatKhauKDV]) VALUES (2, N'Trần Văn Y', N'y.tran@example.com', N'kdv_y', N'password123')
INSERT [dbo].[KIEMDUYETVIEN] ([MaKDV], [HoTenKDV], [EmailKDV], [TenDangNhapKDV], [MatKhauKDV]) VALUES (3, N'Lê Thị Z', N'z.le@example.com', N'kdv_z', N'password123')
INSERT [dbo].[KIEMDUYETVIEN] ([MaKDV], [HoTenKDV], [EmailKDV], [TenDangNhapKDV], [MatKhauKDV]) VALUES (4, N'Phạm Văn W', N'w.pham@example.com', N'kdv_w', N'password123')
INSERT [dbo].[KIEMDUYETVIEN] ([MaKDV], [HoTenKDV], [EmailKDV], [TenDangNhapKDV], [MatKhauKDV]) VALUES (5, N'Hoàng Thị V', N'v.hoang@example.com', N'kdv_v', N'password123')
GO
