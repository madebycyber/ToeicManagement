USE [TOIEC]
/****** LAN ANH ******/

INSERT [dbo].[KYNANG] ([MaKN], [TenKN]) VALUES (1, N'Listening')
INSERT [dbo].[KYNANG] ([MaKN], [TenKN]) VALUES (2, N'Reading')
INSERT [dbo].[KYNANG] ([MaKN], [TenKN]) VALUES (3, N'Speaking')
INSERT [dbo].[KYNANG] ([MaKN], [TenKN]) VALUES (4, N'Writing')
INSERT [dbo].[KYNANG] ([MaKN], [TenKN]) VALUES (5, N'Vocabulary')
GO
INSERT [dbo].[LICHHOC] ([LichID], [LopID], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (1, 1, CAST(N'2025-06-01T08:00:00.000' AS DateTime), CAST(N'2025-06-01T10:00:00.000' AS DateTime))
INSERT [dbo].[LICHHOC] ([LichID], [LopID], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (2, 2, CAST(N'2025-06-02T14:00:00.000' AS DateTime), CAST(N'2025-06-02T16:00:00.000' AS DateTime))
INSERT [dbo].[LICHHOC] ([LichID], [LopID], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (3, 3, CAST(N'2025-06-03T08:00:00.000' AS DateTime), CAST(N'2025-06-03T10:00:00.000' AS DateTime))
INSERT [dbo].[LICHHOC] ([LichID], [LopID], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (4, 4, CAST(N'2025-06-04T14:00:00.000' AS DateTime), CAST(N'2025-06-04T16:00:00.000' AS DateTime))
INSERT [dbo].[LICHHOC] ([LichID], [LopID], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (5, 5, CAST(N'2025-06-05T08:00:00.000' AS DateTime), CAST(N'2025-06-05T10:00:00.000' AS DateTime))
GO
INSERT [dbo].[LICHTHITOIEC] ([LichThiID], [UserID], [DiaDiemThi], [ThoiGianTao]) VALUES (1, 1, N'Trung tâm ETS Hà Nội', CAST(N'2025-06-01T10:00:00.000' AS DateTime))
INSERT [dbo].[LICHTHITOIEC] ([LichThiID], [UserID], [DiaDiemThi], [ThoiGianTao]) VALUES (2, 2, N'Trung tâm ETS TP.HCM', CAST(N'2025-06-02T10:00:00.000' AS DateTime))
INSERT [dbo].[LICHTHITOIEC] ([LichThiID], [UserID], [DiaDiemThi], [ThoiGianTao]) VALUES (3, 3, N'Trung tâm ETS Đà Nẵng', CAST(N'2025-06-03T10:00:00.000' AS DateTime))
INSERT [dbo].[LICHTHITOIEC] ([LichThiID], [UserID], [DiaDiemThi], [ThoiGianTao]) VALUES (4, 4, N'Trung tâm ETS Cần Thơ', CAST(N'2025-06-04T10:00:00.000' AS DateTime))
INSERT [dbo].[LICHTHITOIEC] ([LichThiID], [UserID], [DiaDiemThi], [ThoiGianTao]) VALUES (5, 5, N'Trung tâm ETS Hải Phòng', CAST(N'2025-06-05T10:00:00.000' AS DateTime))
GO
INSERT [dbo].[LOAIDETHI] ([MaLoaiDe], [TenLoaiDe]) VALUES (1, N'Thi thử')
INSERT [dbo].[LOAIDETHI] ([MaLoaiDe], [TenLoaiDe]) VALUES (2, N'Thi chính thức')
INSERT [dbo].[LOAIDETHI] ([MaLoaiDe], [TenLoaiDe]) VALUES (3, N'Luyện tập')
INSERT [dbo].[LOAIDETHI] ([MaLoaiDe], [TenLoaiDe]) VALUES (4, N'Đề mẫu')
INSERT [dbo].[LOAIDETHI] ([MaLoaiDe], [TenLoaiDe]) VALUES (5, N'Đề chuyên sâu')
GO
INSERT [dbo].[LOAITAILIEU] ([MaLoaiTL], [TenLoaiTL], [MoTaLoaiTL]) VALUES (1, N'Tài liệu Listening', N'Tài liệu luyện nghe TOEIC')
INSERT [dbo].[LOAITAILIEU] ([MaLoaiTL], [TenLoaiTL], [MoTaLoaiTL]) VALUES (2, N'Tài liệu Reading', N'Tài liệu luyện đọc TOEIC')
INSERT [dbo].[LOAITAILIEU] ([MaLoaiTL], [TenLoaiTL], [MoTaLoaiTL]) VALUES (3, N'Đề thi mẫu', N'Đề thi TOEIC mẫu')
INSERT [dbo].[LOAITAILIEU] ([MaLoaiTL], [TenLoaiTL], [MoTaLoaiTL]) VALUES (4, N'Từ vựng', N'Tài liệu học từ vựng TOEIC')
INSERT [dbo].[LOAITAILIEU] ([MaLoaiTL], [TenLoaiTL], [MoTaLoaiTL]) VALUES (5, N'Ngữ pháp', N'Tài liệu học ngữ pháp TOEIC')
GO
INSERT [dbo].[LOP] ([id_Lop], [TenLop], [ThangBatDau], [ThangKetThuc], [MaGV]) VALUES (1, N'Lớp TOEIC A1', CAST(N'2025-06-01' AS Date), CAST(N'2025-08-31' AS Date), 1)
INSERT [dbo].[LOP] ([id_Lop], [TenLop], [ThangBatDau], [ThangKetThuc], [MaGV]) VALUES (2, N'Lớp TOEIC A2', CAST(N'2025-06-01' AS Date), CAST(N'2025-08-31' AS Date), 2)
INSERT [dbo].[LOP] ([id_Lop], [TenLop], [ThangBatDau], [ThangKetThuc], [MaGV]) VALUES (3, N'Lớp TOEIC B1', CAST(N'2025-06-01' AS Date), CAST(N'2025-08-31' AS Date), 3)
INSERT [dbo].[LOP] ([id_Lop], [TenLop], [ThangBatDau], [ThangKetThuc], [MaGV]) VALUES (4, N'Lớp TOEIC B2', CAST(N'2025-06-01' AS Date), CAST(N'2025-08-31' AS Date), 4)
INSERT [dbo].[LOP] ([id_Lop], [TenLop], [ThangBatDau], [ThangKetThuc], [MaGV]) VALUES (5, N'Lớp TOEIC C1', CAST(N'2025-06-01' AS Date), CAST(N'2025-08-31' AS Date), 5)
GO
INSERT [dbo].[MUCDOKHO] ([MaMDK], [TenMDK]) VALUES (1, N'Dễ')
INSERT [dbo].[MUCDOKHO] ([MaMDK], [TenMDK]) VALUES (2, N'Trung bình')
INSERT [dbo].[MUCDOKHO] ([MaMDK], [TenMDK]) VALUES (3, N'Khó')
INSERT [dbo].[MUCDOKHO] ([MaMDK], [TenMDK]) VALUES (4, N'Rất khó')
INSERT [dbo].[MUCDOKHO] ([MaMDK], [TenMDK]) VALUES (5, N'Nâng cao')
GO
INSERT [dbo].[NHOMCH] ([MaNhomCH], [KyHieu_NhomCh], [ND_DoanVan], [ND_HoiThoai], [Path_AudioNhom], [ID_GiaoVienTao], [NgayTaoNhom], [MaPT]) VALUES (1, N'Nhom1', N'Đoạn văn mô tả hình ảnh', NULL, N'/audio/n1.mp3', 1, CAST(N'2025-06-01' AS Date), 1)
INSERT [dbo].[NHOMCH] ([MaNhomCH], [KyHieu_NhomCh], [ND_DoanVan], [ND_HoiThoai], [Path_AudioNhom], [ID_GiaoVienTao], [NgayTaoNhom], [MaPT]) VALUES (2, N'Nhom2', NULL, N'Hội thoại ngắn', N'/audio/n2.mp3', 2, CAST(N'2025-06-02' AS Date), 1)
INSERT [dbo].[NHOMCH] ([MaNhomCH], [KyHieu_NhomCh], [ND_DoanVan], [ND_HoiThoai], [Path_AudioNhom], [ID_GiaoVienTao], [NgayTaoNhom], [MaPT]) VALUES (3, N'Nhom3', N'Đoạn văn thông báo', NULL, N'/audio/n3.mp3', 3, CAST(N'2025-06-03' AS Date), 2)
INSERT [dbo].[NHOMCH] ([MaNhomCH], [KyHieu_NhomCh], [ND_DoanVan], [ND_HoiThoai], [Path_AudioNhom], [ID_GiaoVienTao], [NgayTaoNhom], [MaPT]) VALUES (4, N'Nhom4', NULL, N'Hội thoại dài', N'/audio/n4.mp3', 4, CAST(N'2025-06-04' AS Date), 1)
INSERT [dbo].[NHOMCH] ([MaNhomCH], [KyHieu_NhomCh], [ND_DoanVan], [ND_HoiThoai], [Path_AudioNhom], [ID_GiaoVienTao], [NgayTaoNhom], [MaPT]) VALUES (5, N'Nhom5', N'Đoạn văn quảng cáo', NULL, N'/audio/n5.mp3', 5, CAST(N'2025-06-05' AS Date), 2)
GO
INSERT [dbo].[PHANLOAITL] ([MaPL], [MaKN], [MaPT]) VALUES (1, 1, 1)
INSERT [dbo].[PHANLOAITL] ([MaPL], [MaKN], [MaPT]) VALUES (2, 2, 2)
INSERT [dbo].[PHANLOAITL] ([MaPL], [MaKN], [MaPT]) VALUES (3, 3, 1)
INSERT [dbo].[PHANLOAITL] ([MaPL], [MaKN], [MaPT]) VALUES (4, 4, 2)
INSERT [dbo].[PHANLOAITL] ([MaPL], [MaKN], [MaPT]) VALUES (5, 5, 1)
GO
INSERT [dbo].[PHANTHI] ([MaPT], [TenPT], [MaKN]) VALUES (1, N'Part 1: Photographs', 1)
INSERT [dbo].[PHANTHI] ([MaPT], [TenPT], [MaKN]) VALUES (2, N'Part 5: Incomplete Sentences', 2)
INSERT [dbo].[PHANTHI] ([MaPT], [TenPT], [MaKN]) VALUES (3, N'Part 2: Question-Response', 1)
INSERT [dbo].[PHANTHI] ([MaPT], [TenPT], [MaKN]) VALUES (4, N'Part 6: Text Completion', 2)
INSERT [dbo].[PHANTHI] ([MaPT], [TenPT], [MaKN]) VALUES (5, N'Part 7: Reading Comprehension', 2)
GO
INSERT INTO [dbo].[CAUHOI] (MaCH, MaNhomCH, ND_CauHoi, Path_AudioRieng, Path_HinhAnh, GiaiThichDA, MaTT_CH, ID_GiaoVienTaoCH, ID_NguoiDuyetCH, STT_TrongNhom, NgayTaoCH, NgayDuyetCH, NgayCapNhatCH) VALUES
(1, 1, N'What is the man doing?', N'/audio/q1.mp3', N'/images/q1.jpg', N'The man is reading.', 1, 1, 1, 1, '2025-06-01', '2025-06-02', '2025-06-03'),
(2, 2, N'Where is the meeting held?', N'/audio/q2.mp3', NULL, N'The meeting is in Room 101.', 2, 2, 2, 1, '2025-06-02', '2025-06-03', '2025-06-04'),
(3, 3, N'Who is the speaker?', N'/audio/q3.mp3', NULL, N'The speaker is the manager.', 3, 3, 3, 2, '2025-06-03', '2025-06-04', '2025-06-05'),
(4, 4, N'What time does the train leave?', N'/audio/q4.mp3', N'/images/q4.jpg', N'The train leaves at 9 AM.', 4, 4, 4, 1, '2025-06-04', '2025-06-05', '2025-06-06'),
(5, 5, N'Why was the event canceled?', N'/audio/q5.mp3', NULL, N'The event was canceled due to rain.', 5, 5, 5, 3, '2025-06-05', '2025-06-06', '2025-06-07');
INSERT INTO [dbo].[CAUHOIBAITAP] (id_BaiTap, id_PhieuBaiTap, MaCH) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5);
INSERT INTO [dbo].[CAUHOITRONG DETHI] (MaDeThi, MaCH, STT_CH_TrongDe) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5);
INSERT INTO [dbo].[LICHSUDUYETCH] (MaLSD, MaCH, ID_NguoiDuyetLS, MaTT_Truoc, MaTT_Sau, GhiCHuDuyet, ThoiDiemDuyet) VALUES
(1, 1, 1, 1, 2, N'Đã kiểm tra nội dung', '2025-06-02 10:00:00'),
(2, 2, 2, 2, 3, N'Phê duyệt câu hỏi', '2025-06-03 10:00:00'),
(3, 3, 3, 3, 4, N'Cần chỉnh sửa đáp án', '2025-06-04 10:00:00'),
(4, 4, 4, 4, 5, N'Đã duyệt hoàn tất', '2025-06-05 10:00:00'),
(5, 5, 5, 1, 3, N'Kiểm tra audio', '2025-06-06 10:00:00');

INSERT INTO [dbo].[LICHTHITOIEC] (LichThiID, UserID, DiaDiemThi, ThoiGianTao) VALUES
(1, 1, N'Trung tâm ETS Hà Nội', '2025-06-01 10:00:00'),
(2, 2, N'Trung tâm ETS TP.HCM', '2025-06-02 10:00:00'),
(3, 3, N'Trung tâm ETS Đà Nẵng', '2025-06-03 10:00:00'),
(4, 4, N'Trung tâm ETS Cần Thơ', '2025-06-04 10:00:00'),
(5, 5, N'Trung tâm ETS Hải Phòng', '2025-06-05 10:00:00');
INSERT INTO [dbo].[LOAIDETHI] (MaLoaiDe, TenLoaiDe) VALUES
(1, N'Thi thử'),
(2, N'Thi chính thức'),
(3, N'Luyện tập'),
(4, N'Đề mẫu'),
(5, N'Đề chuyên sâu');

INSERT INTO [dbo].[LOP] (id_Lop, TenLop, ThangBatDau, ThangKetThuc, MaGV) VALUES
(1, N'Lớp TOEIC A1', '2025-06-01', '2025-08-31', 1),
(2, N'Lớp TOEIC A2', '2025-06-01', '2025-08-31', 2),
(3, N'Lớp TOEIC B1', '2025-06-01', '2025-08-31', 3),
(4, N'Lớp TOEIC B2', '2025-06-01', '2025-08-31', 4),
(5, N'Lớp TOEIC C1', '2025-06-01', '2025-08-31', 5);
INSERT INTO [dbo].[MUCDOKHO] (MaMDK, TenMDK) VALUES
(1, N'Dễ'),
(2, N'Trung bình'),
(3, N'Khó'),
(4, N'Rất khó'),
(5, N'Nâng cao');

INSERT INTO [dbo].[PHANLOAICH] (MaCH, MaPT, MaKN, MaMDK) VALUES
(1, 1, 1, 1),
(2, 1, 1, 2),
(3, 2, 2, 3),
(4, 1, 1, 4),
(5, 2, 2, 5);
INSERT INTO [dbo].[PHANLOAITL] (MaPL, MaKN, MaPT) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 1),
(4, 4, 2),
(5, 5, 1);