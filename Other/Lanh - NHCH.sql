USE [N0130062005]
--Lấy một câu hỏi do giáo viên đề xuất 
DECLARE @MaGV_Input INT = 1;

SELECT
    CH.MaCH AS [Mã câu hỏi],
    CASE
        WHEN NCH.MaNhomCH IS NOT NULL THEN
            LEFT(
                ISNULL(NCH.ND_HoiThoai, ISNULL(NCH.ND_DoanVan, '')) +
                CASE 
                    WHEN CH.ND_CauHoi IS NOT NULL AND CH.ND_CauHoi != '' 
                    THEN CHAR(13) + CHAR(10) + CH.ND_CauHoi 
                    ELSE '' 
                END,
                100
            ) + '...'
        ELSE
            LEFT(ISNULL(CH.ND_CauHoi, ''), 100) + '...'
    END AS [Nội dung tóm tắt],
    PT.TenPT AS [Dạng bài thi],
    KN.TenKN AS [Kỹ năng],
    MDK.TenMDK AS [Độ khó],
    (
        SELECT TOP 1 DA_Dung.KyHieuDA 
        FROM DapAn DA_Dung 
        WHERE DA_Dung.MaCH = CH.MaCH 
          AND DA_Dung.LaDapAnDung = 1
    ) AS [Đáp án đúng (Ký hiệu)]
FROM
    CauHoi CH
INNER JOIN GiaoVien GV_Tao ON CH.ID_GiaoVienTaoCH = GV_Tao.MaGV
LEFT JOIN NhomCH NCH ON CH.MaNhomCH = NCH.MaNhomCH
LEFT JOIN PhanLoaiCH PLCH ON CH.MaCH = PLCH.MaCH
LEFT JOIN KyNang KN ON PLCH.MaKN = KN.MaKN
LEFT JOIN PhanThi PT ON PLCH.MaPT = PT.MaPT
LEFT JOIN MucDoKho MDK ON PLCH.MaMDK = MDK.MaMDK
WHERE
    CH.ID_GiaoVienTaoCH = @MaGV_Input
ORDER BY
    CH.MaCH;


	-- Lấy ra chi tiết một câu hỏi do giáo viên đề xuất 

DECLARE @MaGV_Input INT = 1;
DECLARE @MaCH_Input INT = 1;
SELECT
    CH.MaCH AS [Mã câu hỏi],
    GV_Tao.TenGiaoVien AS [Người đề xuất],
    KN.TenKN AS [Kỹ năng],
    PT.TenPT AS [Dạng bài thi],
    MDK.TenMDK AS [Độ khó],
    CASE
        WHEN NCH.MaNhomCH IS NOT NULL THEN
            ISNULL(NCH.ND_HoiThoai, ISNULL(NCH.ND_DoanVan, '')) +
            CASE 
                WHEN CH.ND_CauHoi IS NOT NULL AND CH.ND_CauHoi != '' 
                THEN CHAR(13) + CHAR(10) + CH.ND_CauHoi 
                ELSE '' 
            END
        ELSE
            ISNULL(CH.ND_CauHoi, '')
    END AS [Nội dung câu hỏi (đầy đủ)],
    DA.KyHieuDA AS [Ký hiệu đáp án],
    DA.ND_DapAn AS [Nội dung đáp án],
    DA.LaDapAnDung AS [Là đáp án đúng (1=Đúng, 0=Sai)],
    (
        SELECT TOP 1 DA_Dung.KyHieuDA 
        FROM DapAn DA_Dung 
        WHERE DA_Dung.MaCH = CH.MaCH AND DA_Dung.LaDapAnDung = 1
    ) AS [Đáp án đúng (Chỉ ký hiệu)],
    ISNULL(CH.Path_HinhAnh, ISNULL(CH.Path_AudioRieng, NCH.Path_AudioNhom)) AS [File đính kèm],
    CH.GiaiThichDA AS [Ghi chú]
FROM
    CauHoi CH
INNER JOIN GiaoVien GV_Tao ON CH.ID_GiaoVienTaoCH = GV_Tao.MaGV
LEFT JOIN NhomCH NCH ON CH.MaNhomCH = NCH.MaNhomCH
LEFT JOIN PhanLoaiCH PLCH ON CH.MaCH = PLCH.MaCH
LEFT JOIN KyNang KN ON PLCH.MaKN = KN.MaKN
LEFT JOIN PhanThi PT ON PLCH.MaPT = PT.MaPT
LEFT JOIN MucDoKho MDK ON PLCH.MaMDK = MDK.MaMDK
LEFT JOIN DapAn DA ON CH.MaCH = DA.MaCH
WHERE
    CH.MaCH = @MaCH_Input
    AND CH.ID_GiaoVienTaoCH = @MaGV_Input;

	--Lấy danh sách câu hỏi kèm thông tin duyệt lần cuối 
DECLARE @DanhSachMaCH NVARCHAR(MAX) = '4,6';  

SELECT
    CH.MaCH AS [Mã câu hỏi],
    CASE
        WHEN NCH.MaNhomCH IS NOT NULL THEN
            ISNULL(NCH.ND_HoiThoai, ISNULL(NCH.ND_DoanVan, '')) +
            CASE 
                WHEN CH.ND_CauHoi IS NOT NULL AND CH.ND_CauHoi != '' 
                THEN CHAR(13) + CHAR(10) + CH.ND_CauHoi 
                ELSE '' 
            END
        ELSE
            ISNULL(CH.ND_CauHoi, '')
    END AS [Nội dung câu hỏi],
    TT_CauHoi.TenTT_CH AS [Trạng thái hiện tại của câu hỏi],
    LSD.ThoiDiemDuyet AS [Thời gian duyệt (lần cuối)],
    KDV.HoTenKDV AS [Người duyệt (lần cuối)],
    LSD.GhiChuDuyet AS [Ghi chú duyệt (lần cuối)],
    TT_LSD.TenTT_CH AS [Trạng thái sau duyệt (lần cuối)]
FROM
    CauHoi CH
LEFT JOIN NhomCH NCH ON CH.MaNhomCH = NCH.MaNhomCH
LEFT JOIN TrangThaiCH TT_CauHoi ON CH.MaTT_CH = TT_CauHoi.MaTT_CH
LEFT JOIN (
    SELECT LSD1.*
    FROM LichSuDuyetCH LSD1
    INNER JOIN (
        SELECT MaCH, MAX(ThoiDiemDuyet) AS MaxThoiDiemDuyet
        FROM LichSuDuyetCH
        GROUP BY MaCH
    ) AS LSD_MaxThoiDiem 
        ON LSD1.MaCH = LSD_MaxThoiDiem.MaCH 
        AND LSD1.ThoiDiemDuyet = LSD_MaxThoiDiem.MaxThoiDiemDuyet
) AS LSD ON CH.MaCH = LSD.MaCH
LEFT JOIN KiemDuyetVien KDV ON LSD.ID_NguoiDuyetLS = KDV.MaKDV
LEFT JOIN TrangThaiCH TT_LSD ON LSD.MaTT_Sau = TT_LSD.MaTT_CH
WHERE
    CH.MaCH IN (SELECT value FROM STRING_SPLIT(@DanhSachMaCH, ','))
ORDER BY
    CH.MaCH;


-- Lấy danh sách câu hỏi có trạng thái cần chỉnh sửa
-- 1. Khai báo biến trạng thái cần chỉnh sửa
DECLARE @MaTrangThaiCanChinhSua_UC1 INT;

-- 2. Gán mã trạng thái có tên "Cần chỉnh sửa"
SELECT TOP 1 
    @MaTrangThaiCanChinhSua_UC1 = MaTT_CH
FROM 
    TrangThaiCH
WHERE 
    TenTT_CH = N'Cần chỉnh sửa';

-- 3. Truy vấn các câu hỏi đang ở trạng thái cần chỉnh sửa, cùng thông tin yêu cầu gần nhất
SELECT
    CH.MaCH AS [Mã câu hỏi],

    -- Nội dung tóm tắt câu hỏi
    CASE
        WHEN NCH.MaNhomCH IS NOT NULL THEN
            LEFT(
                ISNULL(NCH.ND_HoiThoai, ISNULL(NCH.ND_DoanVan, '')) +
                CASE 
                    WHEN CH.ND_CauHoi IS NOT NULL AND CH.ND_CauHoi != '' 
                    THEN CHAR(13) + CHAR(10) + CH.ND_CauHoi 
                    ELSE '' 
                END,
                150
            ) + '...'
        ELSE
            LEFT(ISNULL(CH.ND_CauHoi, ''), 150) + '...'
    END AS [Nội dung tóm tắt],

    GV_Tao.TenGiaoVien AS [Giáo viên đề xuất],
    CH.NgayTaoCH AS [Ngày tạo câu hỏi],
    LastEditRequest.ThoiDiemDuyet AS [Ngày yêu cầu chỉnh sửa (Gần nhất)],
    KDV_Request.HoTenKDV AS [Người kiểm duyệt yêu cầu (Gần nhất)],
    LEFT(ISNULL(LastEditRequest.GhiChuDuyet, ''), 100) + '...' AS [Ghi chú yêu cầu (Tóm tắt)]

FROM
    CauHoi CH
INNER JOIN GiaoVien GV_Tao ON CH.ID_GiaoVienTaoCH = GV_Tao.MaGV
INNER JOIN TrangThaiCH TT_CH ON CH.MaTT_CH = TT_CH.MaTT_CH
LEFT JOIN NhomCH NCH ON CH.MaNhomCH = NCH.MaNhomCH

-- Truy vấn yêu cầu gần nhất từ bảng duyệt
LEFT JOIN (
    SELECT 
        LSD_inner.MaCH,
        LSD_inner.ThoiDiemDuyet,
        LSD_inner.ID_NguoiDuyetLS,  
        LSD_inner.GhiChuDuyet,
        ROW_NUMBER() OVER (PARTITION BY LSD_inner.MaCH ORDER BY LSD_inner.ThoiDiemDuyet DESC) AS rn
    FROM 
        LichSuDuyetCH LSD_inner
    WHERE 
        LSD_inner.MaTT_Moi = @MaTrangThaiCanChinhSua_UC1
) AS LastEditRequest 
    ON CH.MaCH = LastEditRequest.MaCH AND LastEditRequest.rn = 1

LEFT JOIN KiemDuyetVien KDV_Request 
    ON LastEditRequest.ID_NguoiDuyetLS = KDV_Request.MaKDV

-- Chỉ lấy câu hỏi đang có trạng thái cần chỉnh sửa
WHERE
    CH.MaTT_CH = @MaTrangThaiCanChinhSua_UC1

ORDER BY 
    LastEditRequest.ThoiDiemDuyet DESC, CH.MaCH;



	-- Lấy chi tiết phiếu yêu cầu chỉnh sửa nội dung cho 1 lần chỉnh sửa cụ thể 
	-- Khai báo biến
DECLARE @MaLSD_Input INT = 1;
DECLARE @MaTrangThaiCanChinhSua_UC2 INT;

-- Gán mã trạng thái "Cần chỉnh sửa"
SELECT TOP 1 
    @MaTrangThaiCanChinhSua_UC2 = MaTT_CH
FROM TrangThaiCH
WHERE TenTT_CH = N'Cần chỉnh sửa';

-- Truy vấn thông tin phiếu yêu cầu chỉnh sửa
SELECT
    LSD.MaLSD AS [Số phiếu],
    CONVERT(DATE, LSD.ThoiDiemDuyet) AS [Ngày phiếu],
    CH.MaCH AS [Mã câu hỏi],
    GV_Tao.TenGiaoVien AS [Giáo viên đề xuất],
    CH.NgayTaoCH AS [Ngày đề xuất câu hỏi],
    LSD.GhiChuDuyet AS [Nội dung yêu cầu chỉnh sửa],
    KDV.HoTenKDV AS [Người kiểm duyệt]

FROM LichSuDuyetCH LSD
INNER JOIN CauHoi CH ON LSD.MaCH = CH.MaCH
INNER JOIN GiaoVien GV_Tao ON CH.ID_GiaoVienTaoCH = GV_Tao.MaGV
INNER JOIN KiemDuyetVien KDV ON LSD.ID_NguoiDuyetLS = KDV.MaKDV  

WHERE
    LSD.MaLSD = @MaLSD_Input
    AND LSD.MaTT_Sau = @MaTrangThaiCanChinhSua_UC2;

	-- Lấy danh sách câu hỏi chính thức 
	-- 1. Khai báo và lấy mã trạng thái "Đã duyệt"
DECLARE @MaTrangThaiDaDuyet INT;

SELECT TOP 1 
    @MaTrangThaiDaDuyet = MaTT_CH
FROM TrangThaiCH
WHERE TenTT_CH = N'Đã duyệt';

-- 2. Truy vấn chính
SELECT
    CH.MaCH AS [Mã câu hỏi],
    KN.TenKN AS [Kỹ năng],
    PT.TenPT AS [Dạng bài],
    MDK.TenMDK AS [Độ khó],
    GV_Tao.TenGiaoVien AS [Giáo viên đề xuất],
    CH.NgayTaoCH AS [Thời gian đề xuất],
    LastApprovedDuyet.ThoiDiemDuyet AS [Thời gian kiểm duyệt],
    ISNULL(CH.Path_HinhAnh, ISNULL(CH.Path_AudioRieng, NCH.Path_AudioNhom)) AS [File đính kèm],
    LastApprovedDuyet.GhiChuDuyet AS [Ghi chú],
    KDV_Duyet.HoTenKDV AS [Người duyệt lần cuối]

FROM CauHoi CH
INNER JOIN GiaoVien GV_Tao ON CH.ID_GiaoVienTaoCH = GV_Tao.MaGV
INNER JOIN TrangThaiCH TT_CH ON CH.MaTT_CH = TT_CH.MaTT_CH
LEFT JOIN NhomCH NCH ON CH.MaNhomCH = NCH.MaNhomCH
LEFT JOIN PhanLoaiCH PLCH ON CH.MaCH = PLCH.MaCH
LEFT JOIN KyNang KN ON PLCH.MaKN = KN.MaKN
LEFT JOIN PhanThi PT ON PLCH.MaPT = PT.MaPT
LEFT JOIN MucDoKho MDK ON PLCH.MaMDK = MDK.MaMDK

-- 3. Lấy lần duyệt gần nhất với trạng thái "Đã duyệt"
LEFT JOIN (
    SELECT 
        LSD_inner.MaCH,
        LSD_inner.ThoiDiemDuyet,
        LSD_inner.GhiChuDuyet,
        LSD_inner.ID_NguoiDuyetLS,
        ROW_NUMBER() OVER(PARTITION BY LSD_inner.MaCH ORDER BY LSD_inner.ThoiDiemDuyet DESC) AS rn
    FROM 
        LichSuDuyetCH LSD_inner
    WHERE 
        LSD_inner.MaTT_Moi = @MaTrangThaiDaDuyet
) AS LastApprovedDuyet 
    ON CH.MaCH = LastApprovedDuyet.MaCH AND LastApprovedDuyet.rn = 1

LEFT JOIN KiemDuyetVien KDV_Duyet 
    ON LastApprovedDuyet.ID_NguoiDuyetLS = KDV_Duyet.MaKDV

-- 4. Chỉ lấy những câu hỏi đang ở trạng thái "Đã duyệt"
WHERE CH.MaTT_CH = @MaTrangThaiDaDuyet

ORDER BY CH.MaCH;

