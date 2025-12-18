/*
  Danh sách bài thi
*/
DECLARE @MaSinhVien INT = 1; -- <-- Thay Mã Sinh viên (MaSV) cần tìm vào đây

SELECT DISTINCT
    GETDATE() AS NgayLap,
    sv.MaSV AS Ma,
    sv.HoTenSV,
    sv.NgaySinh,
    sv.DiaChi,
    sv.CCCD,
    ROW_NUMBER() OVER(PARTITION BY sv.MaSV ORDER BY bt.NgayThi, bt.MaBT) AS STT,
    bt.TenBaiThi,
    bt.NgayThi,
    bt.TGLamBai AS ThoiGianLamBai
FROM
    SinhVien AS sv
JOIN
    ChiTietBaiThi AS ctbt ON sv.MaSV = ctbt.MaSV
JOIN
    BaiThi AS bt ON ctbt.MaBT = bt.MaBT
WHERE
    sv.MaSV = @MaSinhVien
ORDER BY
    bt.NgayThi DESC;
--------------------------------------------------------------------

--------------------------------------------------------------------
	/*
  Chi tiết bài thi
*/
DECLARE @MaSinhVien_CanXem INT = 1; -- <-- Thay Mã Sinh viên (MaSV) cần xem tại đây
DECLARE @MaBaiThi_CanXem INT = 1;   -- <-- Thay Mã Bài thi (MaBT) cần xem tại đây (ví dụ: mã của 'Full Test 2')

-- Câu lệnh chính để xuất dữ liệu cho mẫu biểu "CHI TIẾT BÀI THI"
SELECT
    -- Phần thông tin chung (sẽ lặp lại ở mỗi dòng kết quả, ứng dụng chỉ cần lấy dòng đầu tiên)
    GETDATE() AS NgayLap,
    sv.MaSV AS Ma,
    sv.HoTenSV,
    sv.NgaySinh,
    sv.DiaChi,
    sv.CCCD,

    -- Phần tóm tắt bài thi (cũng sẽ lặp lại)
    bt.TenBaiThi,
    bt.NgayThi AS NgayLamBai,
    bt.TGLamBai AS ThoiGianLam,
    CONCAT(bt.TongDiem, '/990') AS TongDiem, -- Ghép chuỗi để tạo định dạng '665/990'

    -- Phần chi tiết kết quả (đây là phần dữ liệu thay đổi theo từng dòng)
    ctbt.PhanThi,
    CONCAT(ctbt.SoCauDung, '/100') AS SoCauDung, -- Ghép chuỗi để tạo định dạng '67/100'
    ctbt.DiemSo
FROM
    ChiTietBaiThi AS ctbt -- Bắt đầu từ bảng chi tiết
JOIN
    SinhVien AS sv ON ctbt.MaSV = sv.MaSV -- Nối với bảng SinhVien để lấy thông tin cá nhân
JOIN
    BaiThi AS bt ON ctbt.MaBT = bt.MaBT -- Nối với bảng BaiThi để lấy thông tin chung về bài thi
WHERE
    ctbt.MaSV = @MaSinhVien_CanXem  -- Lọc theo đúng sinh viên
    AND ctbt.MaBT = @MaBaiThi_CanXem; -- Và lọc theo đúng bài thi

--------------------------------------------------------------------------

--------------------------------------------------------------------------
/*
  ĐƠN KHIẾU NẠI
*/
DECLARE @MaSinhVien_KN INT = 1; -- <-- Thay Mã Sinh viên khiếu nại vào đây
DECLARE @MaBaiThi_KN INT = 1;   -- <-- Thay Mã Bài thi bị khiếu nại vào đây

-- Câu lệnh chính để xuất dữ liệu cho mẫu "ĐƠN KHIẾU NẠI"
SELECT
    -- Phần thông tin chung (sẽ lặp lại ở mỗi dòng, ứng dụng chỉ cần lấy từ dòng đầu tiên)
    sv.HoTenSV AS TenNguoiLamDon,
    sv.MaSV AS MaHocVien,
    sv.Lop,
    sv.Email AS EmailLienHe,
    bt.TenBaiThi,
    -- Trích xuất ngày, tháng, năm từ ngày thi
    DAY(bt.NgayThi) AS NgayThi_Ngay,
    MONTH(bt.NgayThi) AS NgayThi_Thang,
    YEAR(bt.NgayThi) AS NgayThi_Nam,
    NULL AS GioThi, -- Không có dữ liệu trong CSDL
    NULL AS PhutThi, -- Không có dữ liệu trong CSDL
    -- Trích xuất ngày, tháng, năm lập đơn từ ngày hiện tại
    DAY(GETDATE()) AS NgayLapDon_Ngay,
    MONTH(GETDATE()) AS NgayLapDon_Thang,
    YEAR(GETDATE()) AS NgayLapDon_Nam,

    -- Phần nội dung chi tiết trong bảng khiếu nại (thay đổi theo từng dòng)
    ROW_NUMBER() OVER(ORDER BY dkn.MaDon) AS STT, -- Tạo STT tự động cho các mục khiếu nại
    dkn.CauSo AS CauHoiSo,
    dkn.HinhThucCauHoi,
    dkn.MoTaSaiSot,
    dkn.DeNghiXemXet
FROM
    DonKhieuNai AS dkn
JOIN
    SinhVien AS sv ON dkn.MaSV = sv.MaSV -- Nối với bảng SinhVien để lấy thông tin người làm đơn
JOIN
    BaiThi AS bt ON dkn.MaBT = bt.MaBT   -- Nối với bảng BaiThi để lấy thông tin kỳ thi
WHERE
    dkn.MaSV = @MaSinhVien_KN           -- Lọc đúng sinh viên
    AND dkn.MaBT = @MaBaiThi_KN;        -- Và đúng bài thi bị khiếu nại

--------------------------------------------------------------------------

--------------------------------------------------------------------------

/*
  ĐƠN ĐỀ NGHỊ TẠO DIỄN ĐÀN
*/
DECLARE @MaDonDeNghi INT = 1; -- <-- Thay Mã Đơn Đề Nghị (MaDDN) cần xem vào đây

-- Câu lệnh chính để xuất dữ liệu cho mẫu "ĐƠN ĐỀ NGHỊ TẠO DIỄN ĐÀN"
SELECT
    -- Thông tin người đề nghị
    ddn.TenNguoiDN,
    ddn.ChucVu,
    ddn.DonVi,
    ddn.NgayVietDon,

    -- Nội dung chi tiết của đề nghị
    ddn.TenDienDanDeXuat,
    ddn.MucDich,
    ddn.NoiDung,
    ddn.HinhThucTrienKhai,
    ddn.LoiIchKyVong,
    
    -- Tên người đề nghị ở cuối đơn (lấy lại từ cột TenNguoiDN)
    ddn.TenNguoiDN AS NguoiDeNghi
FROM
    DonDeNghiTaoDD AS ddn -- Chỉ cần truy vấn từ một bảng duy nhất
WHERE
    ddn.MaDDN = @MaDonDeNghi; -- Lọc theo mã đơn cụ thể

------------------------------------------------------------------------

------------------------------------------------------------------------
-- DANH SÁCH DIỄN ĐÀN
SELECT
    ROW_NUMBER() OVER(ORDER BY gvdd.TG_Tao DESC) AS STT, -- Tạo STT, sắp xếp theo diễn đàn mới nhất lên đầu
    dd.TieuDe AS TieuDeChuDe,
    dd.NguoiTao,
    CAST(gvdd.TG_Tao AS DATE) AS NgayTao, -- Chỉ lấy phần ngày từ cột thời gian tạo
    dd.SoBaiViet,
    dd.TrangThai,
    dd.HanhDong,
    dd.GhiChu
FROM
    DienDan AS dd -- Bắt đầu từ bảng Diễn đàn
JOIN
    GiaoVien_DienDan AS gvdd ON dd.MaDD = gvdd.MaDD -- Nối với bảng GiaoVien_DienDan để lấy ngày tạo
ORDER BY
    STT ASC; -- Sắp xếp kết quả cuối cùng theo thứ tự STT tăng dần

