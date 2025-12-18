Use [Toeic_CentrerDb]
INSERT INTO [dbo].[KYNANG] (MaKN, TenKN) VALUES
(1, N'Listening'),
(2, N'Reading'),
(3, N'Speaking'),
(4, N'Writing'),
(5, N'Vocabulary');
INSERT INTO [dbo].[PHANTHI] (MaPT, TenPT, MaKN) VALUES
(1, N'Part 1: Photographs', 1),
(2, N'Part 5: Incomplete Sentences', 2),
(3, N'Part 2: Question-Response', 1),
(4, N'Part 6: Text Completion', 2),
(5, N'Part 7: Reading Comprehension', 2);
INSERT INTO [dbo].[NHOMCH] (MaNhomCH, KyHieu_NhomCh, ND_DoanVan, ND_HoiThoai, Path_AudioNhom, ID_GiaoVienTao, NgayTaoNhom, MaPT) VALUES
(1, N'Nhom1', N'Đoạn văn mô tả hình ảnh', NULL, N'/audio/n1.mp3', 1, '2025-06-01', 1),
(2, N'Nhom2', NULL, N'Hội thoại ngắn', N'/audio/n2.mp3', 2, '2025-06-02', 1),
(3, N'Nhom3', N'Đoạn văn thông báo', NULL, N'/audio/n3.mp3', 3, '2025-06-03', 2),
(4, N'Nhom4', NULL, N'Hội thoại dài', N'/audio/n4.mp3', 4, '2025-06-04', 1),
(5, N'Nhom5', N'Đoạn văn quảng cáo', NULL, N'/audio/n5.mp3', 5, '2025-06-05', 2);
INSERT INTO [dbo].[SINHVIEN] (MaSV, HoTenSV, Lop, Email, NgaySinh, DiaChi, CCCD, TenDangNhapSv, MatKhauSV) VALUES
(1, N'Nguyễn Thị An', N'Lớp TOEIC A1', N'an.nguyen@example.com', '2002-01-01', N'123 Đường Láng, Hà Nội', 123456789012, N'sv_an', N'password123'),
(2, N'Trần Văn Bình', N'Lớp TOEIC A2', N'binh.tran@example.com', '2002-02-02', N'456 Đường Giải Phóng, Hà Nội', 234567890123, N'sv_binh', N'password123'),
(3, N'Lê Thị Cúc', N'Lớp TOEIC B1', N'cuc.le@example.com', '2002-03-03', N'789 Đường Nguyễn Trãi, Hà Nội', 345678901234, N'sv_cuc', N'password123'),
(4, N'Phạm Văn Dũng', N'Lớp TOEIC B2', N'dung.pham@example.com', '2002-04-04', N'101 Đường Cầu Giấy, Hà Nội', 456789012345, N'sv_dung', N'password123'),
(5, N'Hoàng Thị Em', N'Lớp TOEIC C1', N'em.hoang@example.com', '2002-05-05', N'202 Đường Tây Sơn, Hà Nội', 567890123456, N'sv_em', N'password123');
INSERT INTO [dbo].[KIEMDUYETVIEN] (MaKDV, HoTenKDV, EmailKDV, TenDangNhapKDV, MatKhauKDV) VALUES
(1, N'Nguyễn Thị X', N'x.nguyen@example.com', N'kdv_x', N'password123'),
(2, N'Trần Văn Y', N'y.tran@example.com', N'kdv_y', N'password123'),
(3, N'Lê Thị Z', N'z.le@example.com', N'kdv_z', N'password123'),
(4, N'Phạm Văn W', N'w.pham@example.com', N'kdv_w', N'password123'),
(5, N'Hoàng Thị V', N'v.hoang@example.com', N'kdv_v', N'password123');
INSERT INTO [dbo].[LOAITAILIEU] (MaLoaiTL, TenLoaiTL, MoTaLoaiTL) VALUES
(1, N'Tài liệu Listening', N'Tài liệu luyện nghe TOEIC'),
(2, N'Tài liệu Reading', N'Tài liệu luyện đọc TOEIC'),
(3, N'Đề thi mẫu', N'Đề thi TOEIC mẫu'),
(4, N'Từ vựng', N'Tài liệu học từ vựng TOEIC'),
(5, N'Ngữ pháp', N'Tài liệu học ngữ pháp TOEIC');
INSERT INTO [dbo].[TRANGTHAICH] (MaTT_CH, TenTT_CH) VALUES
(1, N'Chờ duyệt'),
(2, N'Đã duyệt'),
(3, N'Từ chối'),
(4, N'Cần chỉnh sửa'),
(5, N'Hoàn tất');
INSERT INTO [dbo].[TRANGTHAITL] (MaTT_Tl, KyHieuTT_TL, TenTT_TL, MoTaTT_TL) VALUES
(1, N'CD', N'Chờ duyệt', N'Tài liệu đang chờ kiểm duyệt'),
(2, N'DD', N'Đã duyệt', N'Tài liệu đã được phê duyệt'),
(3, N'TC', N'Từ chối', N'Tài liệu bị từ chối'),
(4, N'CS', N'Cần chỉnh sửa', N'Tài liệu cần chỉnh sửa'),
(5, N'HT', N'Hoàn tất', N'Tài liệu đã hoàn tất');
INSERT INTO [dbo].[PHIEUBAITAPONLUYEN] (id_PhieuBaiTap, MaSV, Lop, DangCauHoi, ThoiGianGiao, ThoiGianNop, DiemSo, NhanXet) VALUES
(1, 1, N'Lớp TOEIC A1', N'Trắc nghiệm', '2025-06-01 08:00:00', '2025-06-02 23:59:00', 80, N'Cần cải thiện Part 1'),
(2, 2, N'Lớp TOEIC A2', N'Trắc nghiệm', '2025-06-02 08:00:00', '2025-06-03 23:59:00', 75, N'Tốt ở Part 5'),
(3, 3, N'Lớp TOEIC B1', N'Trắc nghiệm', '2025-06-03 08:00:00', '2025-06-04 23:59:00', 90, N'Xuất sắc Part 7'),
(4, 4, N'Lớp TOEIC B2', N'Trắc nghiệm', '2025-06-04 08:00:00', '2025-06-05 23:59:00', 70, N'Cần luyện thêm Part 2'),
(5, 5, N'Lớp TOEIC C1', N'Trắc nghiệm', '2025-06-05 08:00:00', '2025-06-06 23:59:00', 85, N'Ổn định ở Part 6');
INSERT INTO [dbo].[TAILIEUHOCTAP] (MaTL, TieuDeTL, MoTaNganTL, Path_FileTL, URL_NgoaiTL, NoiDungVanBan, MaLoaiTL, MaTT_TL, ID_NguoiTaiLen, ID_NguoiDuyetTL, NgayTaiLenTL, NgayDuyetTL, NgayCapNhatTL_Cuoi) VALUES
(1, N'Tài liệu Listening Part 1', N'Hướng dẫn luyện nghe Part 1', N'/files/listening_p1.pdf', NULL, N'Nội dung tài liệu...', 1, 1, 1, 1, '2025-06-01 10:00:00', '2025-06-02 10:00:00', '2025-06-03 10:00:00'),
(2, N'Tài liệu Reading Part 5', N'Hướng dẫn ngữ pháp Part 5', N'/files/reading_p5.pdf', NULL, N'Nội dung tài liệu...', 2, 2, 2, 2, '2025-06-02 10:00:00', '2025-06-03 10:00:00', '2025-06-04 10:00:00'),
(3, N'Đề thi mẫu TOEIC', N'Đề thi mẫu chuẩn ETS', N'/files/sample_test.pdf', NULL, N'Nội dung tài liệu...', 3, 3, 3, 3, '2025-06-03 10:00:00', '2025-06-04 10:00:00', '2025-06-05 10:00:00'),
(4, N'Từ vựng TOEIC 600', N'600 từ vựng cơ bản', N'/files/vocab_600.pdf', NULL, N'Nội dung tài liệu...', 4, 4, 4, 4, '2025-06-04 10:00:00', '2025-06-05 10:00:00', '2025-06-06 10:00:00'),
(5, N'Ngữ pháp TOEIC', N'Cẩm nang ngữ pháp TOEIC', N'/files/grammar_toeic.pdf', NULL, N'Nội dung tài liệu...', 5, 5, 5, 5, '2025-06-05 10:00:00', '2025-06-06 10:00:00', '2025-06-07 10:00:00');
INSERT INTO [dbo].[LICHSUDUYETTL] (MaLSD_TL, MaTL, ID_NguoiDuyetLS_TL, MaTT_Truoc_TL, MaTT_Moi_TL, GhiChuDuyetTL, ThoiDiemDuyetTL) VALUES
(1, 1, 1, 1, 2, N'Tài liệu hợp lệ', '2025-06-02 10:00:00'),
(2, 2, 2, 2, 3, N'Phê duyệt tài liệu', '2025-06-03 10:00:00'),
(3, 3, 3, 3, 4, N'Cần bổ sung mô tả', '2025-06-04 10:00:00'),
(4, 4, 4, 4, 5, N'Đã duyệt hoàn tất', '2025-06-05 10:00:00'),
(5, 5, 5, 1, 3, N'Kiểm tra nội dung', '2025-06-06 10:00:00');
INSERT INTO [dbo].[DETHI] (id_DeThi, LoaiDde, HinhThuc, ThoiGian) VALUES
(1, N'TOEIC', N'Trắc nghiệm', 120),
(2, N'TOEIC', N'Trắc nghiệm', 120),
(3, N'TOEIC', N'Trắc nghiệm', 120),
(4, N'TOEIC', N'Trắc nghiệm', 120),
(5, N'TOEIC', N'Trắc nghiệm', 120);
INSERT INTO [dbo].[GIAOVIEN] (MaGV, TenGiaoVien, DiaChi, SDT, Email, CapBac, ChucVu, TenDangNhapGV, MatKhauGV) VALUES
(1, N'Nguyễn Văn A', N'123 Đường Láng, Hà Nội', 1234567890, N'a.nguyen@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_a', N'password123'),
(2, N'Trần Thị B', N'456 Đường Giải Phóng, Hà Nội', 2345678901, N'b.tran@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_b', N'password123'),
(3, N'Lê Văn C', N'789 Đường Nguyễn Trãi, Hà Nội', 3456789012, N'c.le@example.com', N'Tiến sĩ', N'Trưởng bộ môn', N'gv_c', N'password123'),
(4, N'Phạm Thị D', N'101 Đường Cầu Giấy, Hà Nội', 4567890123, N'd.pham@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_d', N'password123'),
(5, N'Hoàng Văn E', N'202 Đường Tây Sơn, Hà Nội', 5678901234, N'e.hoang@example.com', N'Thạc sĩ', N'Giảng viên', N'gv_e', N'password123');
INSERT INTO [dbo].[DONDENGHITAODD] (MaDDN, TenNguoiDN, ChucVu, DonVi, NgayVietDon, TenDienDanDeXuat, MucDich, NoiDung, HinhThucTrienKhai, LoiIchKyVong) VALUES
(1, N'Nguyễn Văn A', N'Giảng viên', N'Khoa Ngoại ngữ', '2025-06-01', N'Thảo luận TOEIC Listening', N'Hỗ trợ học viên', N'Tạo không gian thảo luận', N'Trực tuyến', N'Nâng cao kỹ năng Listening'),
(2, N'Trần Thị B', N'Giảng viên', N'Khoa Ngoại ngữ', '2025-06-02', N'Thảo luận TOEIC Reading', N'Chia sẻ tài liệu', N'Tạo diễn đàn nhóm', N'Trực tiếp', N'Cải thiện kỹ năng Reading'),
(3, N'Lê Văn C', N'Giảng viên', N'Khoa Ngoại ngữ', '2025-06-03', N'Mẹo thi TOEIC', N'Chia sẻ kinh nghiệm', N'Tổ chức thảo luận', N'Trực tuyến', N'Tăng điểm TOEIC'),
(4, N'Phạm Thị D', N'Giảng viên', N'Khoa Ngoại ngữ', '2025-06-04', N'Tài liệu TOEIC', N'Cung cấp tài liệu', N'Tạo kho tài liệu', N'Trực tuyến', N'Hỗ trợ học tập'),
(5, N'Hoàng Văn E', N'Giảng viên', N'Khoa Ngoại ngữ', '2025-06-05', N'Hỏi đáp TOEIC', N'Hỗ trợ học viên', N'Tạo kênh hỏi đáp', N'Trực tuyến', N'Giải đáp thắc mắc');
INSERT INTO [dbo].[DIENDAN] (MaDD, TieuDe, NguoiTao, SoBaiViet, TrangThai, HanhDong, GhiChu, MaDDN) VALUES
(1, N'Thảo luận TOEIC Listening', N'Nguyễn Văn A', 10, N'Hoạt động', N'Mở', N'Diễn đàn chính', 1),
(2, N'Thảo luận TOEIC Reading', N'Trần Thị B', 8, N'Hoạt động', N'Mở', N'Diễn đàn phụ', 2),
(3, N'Mẹo thi TOEIC', N'Lê Văn C', 15, N'Hoạt động', N'Mở', N'Chia sẻ kinh nghiệm', 3),
(4, N'Tài liệu TOEIC', N'Phạm Thị D', 5, N'Hoạt động', N'Mở', N'Tài liệu mới', 4),
(5, N'Hỏi đáp TOEIC', N'Hoàng Văn E', 12, N'Hoạt động', N'Mở', N'Hỗ trợ học viên', 5);
INSERT INTO [dbo].[DANGKYTHITHU] (id_ThiThu, MaSV, NgayThiThu, CaThi, DiaDiem, DotThiThu, id_DeThi, GhiChu, MaLSD_TL) VALUES
(1, 1, '2025-06-15', N'Sáng', N'Phòng A101', N'Đợt 1/2025', 1, N'Đăng ký sớm', 1),
(2, 2, '2025-06-20', N'Chiều', N'Phòng A102', N'Đợt 2/2025', 2, N'Cần chuẩn bị kỹ', 2),
(3, 3, '2025-06-25', N'Sáng', N'Phòng A103', N'Đợt 3/2025', 3, N'Thi thử lần đầu', 3),
(4, 4, '2025-06-30', N'Chiều', N'Phòng A104', N'Đợt 4/2025', 4, N'Thi lại', 4),
(5, 5, '2025-07-05', N'Sáng', N'Phòng A105', N'Đợt 5/2025', 5, N'Thi thử cuối khóa', 5);
INSERT INTO [dbo].[BAITHI] (MaBT, NgayLap, TenBaiThi, NgayThi, TGLamBai, TongDiem) VALUES
(1, '2025-06-01', N'TOEIC Test 1', '2025-06-15', '120', '990'),
(2, '2025-06-05', N'TOEIC Test 2', '2025-06-20', '120', '850'),
(3, '2025-06-10', N'TOEIC Test 3', '2025-06-25', '120', '900'),
(4, '2025-06-12', N'TOEIC Test 4', '2025-06-30', '120', '950'),
(5, '2025-06-15', N'TOEIC Test 5', '2025-07-05', '120', '870');
INSERT INTO [dbo].[BAIVIET] (MaBV, TenBV, NoiDung, MaDD, MaNguoiTao) VALUES
(1, N'Bí kíp đạt 900 TOEIC', N'Nội dung chia sẻ kinh nghiệm...', 1, 1),
(2, N'Mẹo làm bài Listening Part 1', N'Nội dung hướng dẫn chi tiết...', 2, 2),
(3, N'Hướng dẫn Reading Part 5', N'Nội dung phân tích câu hỏi...', 3, 3),
(4, N'Tài liệu TOEIC mới nhất', N'Nội dung giới thiệu tài liệu...', 4, 4),
(5, N'Thảo luận Part 7', N'Nội dung thảo luận nhóm...', 5, 5);
INSERT INTO [dbo].[BIENBANTHITHU] (id_BienBanThiThu, id_ThiThu, DotThiThu, DiaDiem, GiamThiCoiThi1, GiamThiCoiThi2) VALUES
(1, 1, N'Đợt 1/2025', N'Phòng A101', N'Nguyễn Văn A', N'Trần Thị B'),
(2, 2, N'Đợt 2/2025', N'Phòng A102', N'Lê Văn C', N'Phạm Thị D'),
(3, 3, N'Đợt 3/2025', N'Phòng A103', N'Hoàng Văn E', N'Ngô Thị F'),
(4, 4, N'Đợt 4/2025', N'Phòng A104', N'Vũ Văn G', N'Đặng Thị H'),
(5, 5, N'Đợt 5/2025', N'Phòng A105', N'Bùi Văn I', N'Huỳnh Thị J');
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
INSERT INTO [dbo].[CAUTRUCDETHI] (MaDeThi, MaPT, SoLuongCau, MaDoKhoPart) VALUES
(1, 1, 10, 1),
(2, 2, 15, 2),
(3, 3, 20, 3),
(4, 4, 25, 4),
(5, 5, 30, 5);
INSERT INTO [dbo].[CAUTRUCDETHI] (MaDeThi, MaPT, SoLuongCau, MaDoKhoPart) VALUES
(1, 1, 10, 1),
(2, 2, 15, 2),
(3, 3, 20, 3),
(4, 4, 25, 4),
(5, 5, 30, 5);
INSERT INTO [dbo].[CHITIETBAITHI] (MaBT, MaSV, PhanThi, SoCauDung, DiemSo) VALUES
(1, 1, N'Listening', 45, 450),
(2, 2, N'Reading', 40, 400),
(3, 3, N'Listening', 48, 480),
(4, 4, N'Reading', 42, 420),
(5, 5, N'Listening', 47, 470);
INSERT INTO [dbo].[CHUDETL] (MaChuDeTL, TenChuDeTL, MoTaChuDeTL) VALUES
(1, N'Listening Part 1', N'Chủ đề câu hỏi mô tả hình ảnh'),
(2, N'Listening Part 2', N'Chủ đề câu hỏi trả lời'),
(3, N'Reading Part 5', N'Chủ đề câu hỏi ngữ pháp'),
(4, N'Reading Part 6', N'Chủ đề điền từ vào đoạn văn'),
(5, N'Reading Part 7', N'Chủ đề đọc hiểu đoạn văn');
INSERT INTO [dbo].[D_DETHI] (id_DDeThi, MaCH, id_DeThi) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5);
INSERT INTO [dbo].[DANGKYONLUYEN] (id_OnLuyen, MaSV, id_Lop, TrinhDoHienTai, DiemToiecMucTieu, HinhThucHoc, GhiChu) VALUES
(1, 1, 1, N'Beginner', 600, N'Trực tiếp', N'Ưu tiên Listening'),
(2, 2, 2, N'Intermediate', 750, N'Trực tuyến', N'Cần cải thiện Reading'),
(3, 3, 3, N'Advanced', 900, N'Trực tiếp', N'Tập trung Part 7'),
(4, 4, 4, N'Beginner', 550, N'Trực tuyến', N'Học thêm từ vựng'),
(5, 5, 5, N'Intermediate', 700, N'Trực tiếp', N'Cần luyện đề thi thử');

INSERT INTO [dbo].[DAPAN] (MaDA, MaCH, ND_DapAn, LaDapAnDung, KyHieuDA) VALUES
(1, 1, N'Reading a book', 1, 'A'),
(2, 1, N'Writing a letter', 0, 'B'),
(3, 2, N'Room 101', 1, 'A'),
(4, 3, N'The manager', 1, 'A'),
(5, 4, N'9 AM', 1, 'A');

INSERT INTO [dbo].[DETHIDATAO] (MaDeThi, TenDeThi, MaLoaiDe, MaTrangThaiDeThi, MoTaDe, ThoiGianLamBai_Phut, NguonGocThamKhao, NamThamKhao, DoKhoTongThe, Tags, ChoPhepXemDapAn, ChoPhepLamLai, SoLanLamLaiMax, ID_GiaoVienTaoDe, ID_SinhVienTaoDe, NgayTaoDe, NgayXuatBan, NgayCapNhatCuoi) VALUES
(1, N'Đề TOEIC 1', 1, 1, N'Đề thi thử TOEIC', 120, N'ETS', 2024, 3, N'TOEIC, Listening, Reading', N'Có', 1, 2, 1, NULL, '2025-06-01 10:00:00', '2025-06-02 10:00:00', '2025-06-03 10:00:00'),
(2, N'Đề TOEIC 2', 2, 2, N'Đề thi chính thức', 120, N'ETS', 2024, 4, N'TOEIC, Reading', N'Không', 0, 0, 2, NULL, '2025-06-02 10:00:00', '2025-06-03 10:00:00', '2025-06-04 10:00:00'),
(3, N'Đề TOEIC 3', 3, 3, N'Đề luyện tập', 120, N'ETS', 2024, 2, N'TOEIC, Listening', N'Có', 1, 3, 3, NULL, '2025-06-03 10:00:00', '2025-06-04 10:00:00', '2025-06-05 10:00:00'),
(4, N'Đề TOEIC 4', 4, 4, N'Đề thi thử TOEIC', 120, N'ETS', 2024, 3, N'TOEIC, Reading', N'Có', 1, 2, 4, NULL, '2025-06-04 10:00:00', '2025-06-05 10:00:00', '2025-06-06 10:00:00'),
(5, N'Đề TOEIC 5', 5, 5, N'Đề thi chính thức', 120, N'ETS', 2024, 5, N'TOEIC, Listening, Reading', N'Không', 0, 0, 5, NULL, '2025-06-05 10:00:00', '2025-06-06 10:00:00', '2025-06-07 10:00:00');
INSERT INTO [dbo].[DIEMTHI] (id_DiemThi, id_ThiThu, MaSV, DiemPart1, DiemPart2, DiemPart3, DiemPart4, DiemPart5, DiemPart6, DiemPart7, TongDiem, Bac) VALUES
(1, 1, 1, 50, 45, 60, 55, 50, 45, 60, 365, N'B1'),
(2, 2, 2, 40, 35, 50, 45, 40, 35, 50, 295, N'B1'),
(3, 3, 3, 60, 55, 70, 65, 60, 55, 70, 435, N'B2'),
(4, 4, 4, 45, 40, 55, 50, 45, 40, 55, 330, N'B1'),
(5, 5, 5, 55, 50, 65, 60, 55, 50, 65, 400, N'B2');

INSERT INTO [dbo].[DONKHIEUNAI] (MaDon, CauSo, HinhThucCauHoi, MoTaSaiSot, DeNghiXemXet, NguoiLap, MaBT, MaSV) VALUES
(1, 1, N'Trắc nghiệm', N'Đáp án sai', N'Xem lại đáp án', N'Nguyễn Văn A', 1, 1),
(2, 2, N'Trắc nghiệm', N'Âm thanh không rõ', N'Kiểm tra audio', N'Trần Thị B', 2, 2),
(3, 3, N'Trắc nghiệm', N'Câu hỏi không rõ', N'Chỉnh sửa câu hỏi', N'Lê Văn C', 3, 3),
(4, 4, N'Trắc nghiệm', N'Đáp án trùng', N'Sửa đáp án', N'Phạm Thị D', 4, 4),
(5, 5, N'Trắc nghiệm', N'Chấm điểm sai', N'Chấm lại bài', N'Hoàng Văn E', 5, 5);

INSERT INTO [dbo].[GIAOVIEN_DIENDAN] (MaDD, MaGV, TG_Tao, TrangThai) VALUES
(1, 1, '2025-06-01 10:00:00', N'Hoạt động'),
(2, 2, '2025-06-02 10:00:00', N'Hoạt động'),
(3, 3, '2025-06-03 10:00:00', N'Hoạt động'),
(4, 4, '2025-06-04 10:00:00', N'Hoạt động'),
(5, 5, '2025-06-05 10:00:00', N'Hoạt động');

INSERT INTO [dbo].[LICHHOC] (LichID, LopID, ThoiGianBatDau, ThoiGianKetThuc) VALUES
(1, 1, '2025-06-01 08:00:00', '2025-06-01 10:00:00'),
(2, 2, '2025-06-02 14:00:00', '2025-06-02 16:00:00'),
(3, 3, '2025-06-03 08:00:00', '2025-06-03 10:00:00'),
(4, 4, '2025-06-04 14:00:00', '2025-06-04 16:00:00'),
(5, 5, '2025-06-05 08:00:00', '2025-06-05 10:00:00');
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


INSERT INTO [dbo].[PHIEUDANGKYTOIEC] (MaPhieu, UserID, TenDonVi, HoVaTen, GioiTinh, NgaySinh, CCCD, SoDienThoai, DiaChiLienHe, Email, NoiCongTac, NgayGioDangKy, GioThi, NgayKiemTraKetQua, LePhiThi, NgayDangKy) VALUES
(1, 1, N'ĐH Ngoại ngữ', N'Nguyễn Văn A', N'Nam', '2000-01-01', 123456789012, 1234567890, N'123 Đường Láng, Hà Nội', N'a.nguyen@example.com', N'Công ty ABC', '2025-06-01 10:00:00', '2025-06-15 08:00:00', '2025-06-30', 1500000.00, '2025-06-01'),
(2, 2, N'ĐH Kinh tế', N'Trần Thị B', N'Nữ', '2000-02-02', 234567890123, 2345678901, N'456 Đường Giải Phóng, Hà Nội', N'b.tran@example.com', N'Công ty XYZ', '2025-06-02 10:00:00', '2025-06-15 08:00:00', '2025-06-30', 1500000.00, '2025-06-02'),
(3, 3, N'ĐH Bách khoa', N'Lê Văn C', N'Nam', '2000-03-03', 345678901234, 3456789012, N'789 Đường Nguyễn Trãi, Hà Nội', N'c.le@example.com', N'Công ty DEF', '2025-06-03 10:00:00', '2025-06-15 08:00:00', '2025-06-30', 1500000.00, '2025-06-03'),
(4, 4, N'ĐH Sư phạm', N'Phạm Thị D', N'Nữ', '2000-04-04', 456789012345, 4567890123, N'101 Đường Cầu Giấy, Hà Nội', N'd.pham@example.com', N'Công ty GHI', '2025-06-04 10:00:00', '2025-06-15 08:00:00', '2025-06-30', 1500000.00, '2025-06-04'),
(5, 5, N'ĐH Y Hà Nội', N'Hoàng Văn E', N'Nam', '2000-05-05', 567890123456, 5678901234, N'202 Đường Tây Sơn, Hà Nội', N'e.hoang@example.com', N'Công ty JKL', '2025-06-05 10:00:00', '2025-06-15 08:00:00', '2025-06-30', 1500000.00, '2025-06-05');

INSERT INTO [dbo].[TAILIEU_CHUDE] (MaTL, MaChuDeTL) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

INSERT INTO [dbo].[THAMGIA] (MaDD, MaSV, TGThamGia) VALUES
(1, 1, '2025-06-01 10:00:00'),
(2, 2, '2025-06-02 10:00:00'),
(3, 3, '2025-06-03 10:00:00'),
(4, 4, '2025-06-04 10:00:00'),
(5, 5, '2025-06-05 10:00:00');
INSERT INTO [dbo].[THONGKELOP] (id_Thongke, id_Lop, TongHocVien, TrungBinhDiem, SoTren450, SoTren600, NhanXet, DotThiThu) VALUES
(1, 1, 30, 400, 10, 2, N'Cần cải thiện Listening', N'Đợt 1/2025'),
(2, 2, 25, 450, 15, 5, N'Tốt ở Reading', N'Đợt 2/2025'),
(3, 3, 20, 500, 18, 8, N'Xuất sắc Part 7', N'Đợt 3/2025'),
(4, 4, 28, 420, 12, 3, N'Cần luyện thêm Part 2', N'Đợt 4/2025'),
(5, 5, 22, 480, 16, 6, N'Ổn định Part 6', N'Đợt 5/2025');

INSERT INTO [dbo].[TRANGTHAIDETHI] (MaTrangThaiDe, TenTrangThaiDe) VALUES
(1, N'Chờ duyệt'),
(2, N'Đã duyệt'),
(3, N'Từ chối'),
(4, N'Cần chỉnh sửa'),
(5, N'Xuất bản');

INSERT INTO [dbo].[TT_LICHTHITOIEC] (MaTT_LichThi, LichThiID, NgayThi, GioThuTuc, GioBatDauLamBai, LoaiBaiThi) VALUES
(1, 1, '2025-06-15', '2025-06-15 07:00:00', '2025-06-15 08:00:00', N'TOEIC Listening & Reading'),
(2, 2, '2025-06-16', '2025-06-16 07:00:00', '2025-06-16 08:00:00', N'TOEIC Listening & Reading'),
(3, 3, '2025-06-17', '2025-06-17 07:00:00', '2025-06-17 08:00:00', N'TOEIC Listening & Reading'),
(4, 4, '2025-06-18', '2025-06-18 07:00:00', '2025-06-18 08:00:00', N'TOEIC Listening & Reading'),
(5, 5, '2025-06-19', '2025-06-19 07:00:00', '2025-06-19 08:00:00', N'TOEIC Listening & Reading');

