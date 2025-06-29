using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToeicCentre_Management.Migrations
{
    /// <inheritdoc />
    public partial class AddCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BAITHI",
                columns: table => new
                {
                    MaBT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayLap = table.Column<DateOnly>(type: "date", nullable: true),
                    TenBaiThi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NgayThi = table.Column<DateOnly>(type: "date", nullable: true),
                    TGLamBai = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TongDiem = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAITHI", x => x.MaBT);
                });

            migrationBuilder.CreateTable(
                name: "CHUDETL",
                columns: table => new
                {
                    MaChuDeTL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuDeTL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MoTaChuDeTL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHUDETL", x => x.MaChuDeTL);
                });

            migrationBuilder.CreateTable(
                name: "ChudetlTailieuhoctap",
                columns: table => new
                {
                    MaChuDeTl = table.Column<int>(type: "int", nullable: false),
                    MaTl = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChudetlTailieuhoctap", x => new { x.MaChuDeTl, x.MaTl });
                });

            migrationBuilder.CreateTable(
                name: "DETHI",
                columns: table => new
                {
                    id_DeThi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiDde = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    HinhThuc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ThoiGian = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DETHI", x => x.id_DeThi);
                });

            migrationBuilder.CreateTable(
                name: "DONDENGHITAODD",
                columns: table => new
                {
                    MaDDN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNguoiDN = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ChucVu = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DonVi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NgayVietDon = table.Column<DateOnly>(type: "date", nullable: true),
                    TenDienDanDeXuat = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MucDich = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhThucTrienKhai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LoiIchKyVong = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DONDENGHITAODD", x => x.MaDDN);
                });

            migrationBuilder.CreateTable(
                name: "GIAOVIEN",
                columns: table => new
                {
                    MaGV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGiaoVien = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SDT = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CapBac = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ChucVu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TenDangNhapGV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MatKhauGV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GIAOVIEN", x => x.MaGV);
                });

            migrationBuilder.CreateTable(
                name: "KIEMDUYETVIEN",
                columns: table => new
                {
                    MaKDV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTenKDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmailKDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TenDangNhapKDV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MatKhauKDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KIEMDUYETVIEN", x => x.MaKDV);
                });

            migrationBuilder.CreateTable(
                name: "KYNANG",
                columns: table => new
                {
                    MaKN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KYNANG", x => x.MaKN);
                });

            migrationBuilder.CreateTable(
                name: "LICHHOC",
                columns: table => new
                {
                    LichID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LopID = table.Column<int>(type: "int", nullable: true),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime", nullable: true),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LICHHOC", x => x.LichID);
                });

            migrationBuilder.CreateTable(
                name: "LICHTHITOIEC",
                columns: table => new
                {
                    LichThiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    DiaDiemThi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LICHTHITOIEC", x => x.LichThiID);
                });

            migrationBuilder.CreateTable(
                name: "LOAIDETHI",
                columns: table => new
                {
                    MaLoaiDe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiDe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOAIDETHI", x => x.MaLoaiDe);
                });

            migrationBuilder.CreateTable(
                name: "LOAITAILIEU",
                columns: table => new
                {
                    MaLoaiTL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiTL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MoTaLoaiTL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOAITAILIEU", x => x.MaLoaiTL);
                });

            migrationBuilder.CreateTable(
                name: "MUCDOKHO",
                columns: table => new
                {
                    MaMDK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMDK = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUCDOKHO", x => x.MaMDK);
                });

            migrationBuilder.CreateTable(
                name: "PHIEUDANGKYTOIEC",
                columns: table => new
                {
                    MaPhieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TenDonVi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HoVaTen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NgaySinh = table.Column<DateOnly>(type: "date", nullable: true),
                    CCCD = table.Column<decimal>(type: "numeric(12,0)", nullable: false),
                    SoDienThoai = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    DiaChiLienHe = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NoiCongTac = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NgayGioDangKy = table.Column<DateTime>(type: "datetime", nullable: true),
                    GioThi = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayKiemTraKetQua = table.Column<DateOnly>(type: "date", nullable: true),
                    LePhiThi = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    NgayDangKy = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHIEUDANGKYTOIEC", x => x.MaPhieu);
                });

            migrationBuilder.CreateTable(
                name: "SINHVIEN",
                columns: table => new
                {
                    MaSV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTenSV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Lop = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NgaySinh = table.Column<DateOnly>(type: "date", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CCCD = table.Column<decimal>(type: "numeric(12,0)", nullable: true),
                    TenDangNhapSv = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MatKhauSV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SINHVIEN", x => x.MaSV);
                });

            migrationBuilder.CreateTable(
                name: "TRANGTHAICH",
                columns: table => new
                {
                    MaTT_CH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTT_CH = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANGTHAICH", x => x.MaTT_CH);
                });

            migrationBuilder.CreateTable(
                name: "TRANGTHAIDETHI",
                columns: table => new
                {
                    MaTrangThaiDe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTrangThaiDe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANGTHAIDETHI", x => x.MaTrangThaiDe);
                });

            migrationBuilder.CreateTable(
                name: "TRANGTHAITL",
                columns: table => new
                {
                    MaTT_Tl = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KyHieuTT_TL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenTT_TL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MoTaTT_TL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANGTHAITL", x => x.MaTT_Tl);
                });

            migrationBuilder.CreateTable(
                name: "TT_LICHTHITOIEC",
                columns: table => new
                {
                    MaTT_LichThi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LichThiID = table.Column<int>(type: "int", nullable: true),
                    NgayThi = table.Column<DateOnly>(type: "date", nullable: true),
                    GioThuTuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    GioBatDauLamBai = table.Column<DateTime>(type: "datetime", nullable: true),
                    LoaiBaiThi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_LICHTHITOIEC", x => x.MaTT_LichThi);
                });

            migrationBuilder.CreateTable(
                name: "DIENDAN",
                columns: table => new
                {
                    MaDD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NguoiTao = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SoBaiViet = table.Column<int>(type: "int", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    HanhDong = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaDDN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIENDAN", x => x.MaDD);
                    table.ForeignKey(
                        name: "FK_DIENDAN_DONDENGHITAODD",
                        column: x => x.MaDDN,
                        principalTable: "DONDENGHITAODD",
                        principalColumn: "MaDDN");
                });

            migrationBuilder.CreateTable(
                name: "LOP",
                columns: table => new
                {
                    id_Lop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ThangBatDau = table.Column<DateOnly>(type: "date", nullable: true),
                    ThangKetThuc = table.Column<DateOnly>(type: "date", nullable: true),
                    MaGV = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOP", x => x.id_Lop);
                    table.ForeignKey(
                        name: "FK_LOP_GIAOVIEN",
                        column: x => x.MaGV,
                        principalTable: "GIAOVIEN",
                        principalColumn: "MaGV");
                });

            migrationBuilder.CreateTable(
                name: "PHANTHI",
                columns: table => new
                {
                    MaPT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaKN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHANTHI", x => x.MaPT);
                    table.ForeignKey(
                        name: "FK_PHANTHI_KYNANG",
                        column: x => x.MaKN,
                        principalTable: "KYNANG",
                        principalColumn: "MaKN");
                });

            migrationBuilder.CreateTable(
                name: "CHITIETBAITHI",
                columns: table => new
                {
                    MaBT = table.Column<int>(type: "int", nullable: false),
                    MaSV = table.Column<int>(type: "int", nullable: false),
                    PhanThi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SoCauDung = table.Column<int>(type: "int", nullable: true),
                    DiemSo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETBAITHI", x => new { x.MaBT, x.MaSV });
                    table.ForeignKey(
                        name: "FK_CHITIETBAITHI_BAITHI",
                        column: x => x.MaBT,
                        principalTable: "BAITHI",
                        principalColumn: "MaBT");
                    table.ForeignKey(
                        name: "FK_CHITIETBAITHI_SINHVIEN",
                        column: x => x.MaSV,
                        principalTable: "SINHVIEN",
                        principalColumn: "MaSV");
                });

            migrationBuilder.CreateTable(
                name: "DONKHIEUNAI",
                columns: table => new
                {
                    MaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CauSo = table.Column<int>(type: "int", nullable: true),
                    HinhThucCauHoi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    MoTaSaiSot = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeNghiXemXet = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NguoiLap = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    MaBT = table.Column<int>(type: "int", nullable: true),
                    MaSV = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DONKHIEUNAI", x => x.MaDon);
                    table.ForeignKey(
                        name: "FK_DONKHIEUNAI_BAITHI",
                        column: x => x.MaBT,
                        principalTable: "BAITHI",
                        principalColumn: "MaBT");
                    table.ForeignKey(
                        name: "FK_DONKHIEUNAI_SINHVIEN",
                        column: x => x.MaSV,
                        principalTable: "SINHVIEN",
                        principalColumn: "MaSV");
                });

            migrationBuilder.CreateTable(
                name: "PHIEUBAITAPONLUYEN",
                columns: table => new
                {
                    id_PhieuBaiTap = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSV = table.Column<int>(type: "int", nullable: true),
                    Lop = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DangCauHoi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ThoiGianGiao = table.Column<DateTime>(type: "datetime", nullable: true),
                    ThoiGianNop = table.Column<DateTime>(type: "datetime", nullable: true),
                    DiemSo = table.Column<int>(type: "int", nullable: true),
                    NhanXet = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHIEUBAITAPONLUYEN", x => x.id_PhieuBaiTap);
                    table.ForeignKey(
                        name: "FK_PHIEUBAITAPONLUYEN_SINHVIEN",
                        column: x => x.MaSV,
                        principalTable: "SINHVIEN",
                        principalColumn: "MaSV");
                });

            migrationBuilder.CreateTable(
                name: "DETHIDATAO",
                columns: table => new
                {
                    MaDeThi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDeThi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MaLoaiDe = table.Column<int>(type: "int", nullable: true),
                    MaTrangThaiDeThi = table.Column<int>(type: "int", nullable: true),
                    MoTaDe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianLamBai_Phut = table.Column<int>(type: "int", nullable: true),
                    NguonGocThamKhao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NamThamKhao = table.Column<int>(type: "int", nullable: true),
                    DoKhoTongThe = table.Column<int>(type: "int", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChoPhepXemDapAn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChoPhepLamLai = table.Column<bool>(type: "bit", nullable: true),
                    SoLanLamLaiMax = table.Column<int>(type: "int", nullable: true),
                    ID_GiaoVienTaoDe = table.Column<int>(type: "int", nullable: true),
                    ID_SinhVienTaoDe = table.Column<int>(type: "int", nullable: true),
                    NgayTaoDe = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayXuatBan = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayCapNhatCuoi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DETHIDATAO", x => x.MaDeThi);
                    table.ForeignKey(
                        name: "FK_DETHIDATAO_GIAOVIEN",
                        column: x => x.ID_GiaoVienTaoDe,
                        principalTable: "GIAOVIEN",
                        principalColumn: "MaGV");
                    table.ForeignKey(
                        name: "FK_DETHIDATAO_LOAIDETHI",
                        column: x => x.MaLoaiDe,
                        principalTable: "LOAIDETHI",
                        principalColumn: "MaLoaiDe");
                    table.ForeignKey(
                        name: "FK_DETHIDATAO_SINHVIEN",
                        column: x => x.ID_SinhVienTaoDe,
                        principalTable: "SINHVIEN",
                        principalColumn: "MaSV");
                    table.ForeignKey(
                        name: "FK_DETHIDATAO_TRANGTHAIDETHI",
                        column: x => x.MaTrangThaiDeThi,
                        principalTable: "TRANGTHAIDETHI",
                        principalColumn: "MaTrangThaiDe");
                });

            migrationBuilder.CreateTable(
                name: "TAILIEUHOCTAP",
                columns: table => new
                {
                    MaTL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDeTL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MoTaNganTL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path_FileTL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    URL_NgoaiTL = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    NoiDungVanBan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoaiTL = table.Column<int>(type: "int", nullable: true),
                    MaTT_TL = table.Column<int>(type: "int", nullable: true),
                    ID_NguoiTaiLen = table.Column<int>(type: "int", nullable: true),
                    ID_NguoiDuyetTL = table.Column<int>(type: "int", nullable: true),
                    NgayTaiLenTL = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayDuyetTL = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayCapNhatTL_Cuoi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAILIEUHOCTAP", x => x.MaTL);
                    table.ForeignKey(
                        name: "FK_TAILIEUHOCTAP_GIAOVIEN",
                        column: x => x.ID_NguoiTaiLen,
                        principalTable: "GIAOVIEN",
                        principalColumn: "MaGV");
                    table.ForeignKey(
                        name: "FK_TAILIEUHOCTAP_KIEMDUYETVIEN",
                        column: x => x.ID_NguoiDuyetTL,
                        principalTable: "KIEMDUYETVIEN",
                        principalColumn: "MaKDV");
                    table.ForeignKey(
                        name: "FK_TAILIEUHOCTAP_LOAITAILIEU",
                        column: x => x.MaLoaiTL,
                        principalTable: "LOAITAILIEU",
                        principalColumn: "MaLoaiTL");
                    table.ForeignKey(
                        name: "FK_TAILIEUHOCTAP_TRANGTHAITL",
                        column: x => x.MaTT_TL,
                        principalTable: "TRANGTHAITL",
                        principalColumn: "MaTT_Tl");
                });

            migrationBuilder.CreateTable(
                name: "BAIVIET",
                columns: table => new
                {
                    MaBV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaDD = table.Column<int>(type: "int", nullable: true),
                    MaNguoiTao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAIVIET", x => x.MaBV);
                    table.ForeignKey(
                        name: "FK_BAIVIET_DIENDAN",
                        column: x => x.MaDD,
                        principalTable: "DIENDAN",
                        principalColumn: "MaDD");
                    table.ForeignKey(
                        name: "FK_BAIVIET_GIAOVIEN",
                        column: x => x.MaNguoiTao,
                        principalTable: "GIAOVIEN",
                        principalColumn: "MaGV");
                });

            migrationBuilder.CreateTable(
                name: "GIAOVIEN_DIENDAN",
                columns: table => new
                {
                    MaDD = table.Column<int>(type: "int", nullable: false),
                    MaGV = table.Column<int>(type: "int", nullable: false),
                    TG_Tao = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GIAOVIEN_DIENDAN", x => new { x.MaDD, x.MaGV });
                    table.ForeignKey(
                        name: "FK_GIAOVIEN_DIENDAN_DIENDAN",
                        column: x => x.MaDD,
                        principalTable: "DIENDAN",
                        principalColumn: "MaDD");
                    table.ForeignKey(
                        name: "FK_GIAOVIEN_DIENDAN_GIAOVIEN",
                        column: x => x.MaGV,
                        principalTable: "GIAOVIEN",
                        principalColumn: "MaGV");
                });

            migrationBuilder.CreateTable(
                name: "THAMGIA",
                columns: table => new
                {
                    MaDD = table.Column<int>(type: "int", nullable: false),
                    MaSV = table.Column<int>(type: "int", nullable: false),
                    TGThamGia = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THAMGIA", x => new { x.MaDD, x.MaSV });
                    table.ForeignKey(
                        name: "FK_THAMGIA_DIENDAN",
                        column: x => x.MaDD,
                        principalTable: "DIENDAN",
                        principalColumn: "MaDD");
                    table.ForeignKey(
                        name: "FK_THAMGIA_SINHVIEN",
                        column: x => x.MaSV,
                        principalTable: "SINHVIEN",
                        principalColumn: "MaSV");
                });

            migrationBuilder.CreateTable(
                name: "DANGKYONLUYEN",
                columns: table => new
                {
                    id_OnLuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSV = table.Column<int>(type: "int", nullable: true),
                    id_Lop = table.Column<int>(type: "int", nullable: true),
                    TrinhDoHienTai = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DiemToiecMucTieu = table.Column<int>(type: "int", nullable: true),
                    HinhThucHoc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DANGKYONLUYEN", x => x.id_OnLuyen);
                    table.ForeignKey(
                        name: "FK_DANGKYONLUYEN_LOP",
                        column: x => x.id_Lop,
                        principalTable: "LOP",
                        principalColumn: "id_Lop");
                    table.ForeignKey(
                        name: "FK_DANGKYONLUYEN_SINHVIEN",
                        column: x => x.MaSV,
                        principalTable: "SINHVIEN",
                        principalColumn: "MaSV");
                });

            migrationBuilder.CreateTable(
                name: "THONGKELOP",
                columns: table => new
                {
                    id_Thongke = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Lop = table.Column<int>(type: "int", nullable: true),
                    TongHocVien = table.Column<int>(type: "int", nullable: true),
                    TrungBinhDiem = table.Column<int>(type: "int", nullable: true),
                    SoTren450 = table.Column<int>(type: "int", nullable: true),
                    SoTren600 = table.Column<int>(type: "int", nullable: true),
                    NhanXet = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DotThiThu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THONGKELOP", x => x.id_Thongke);
                    table.ForeignKey(
                        name: "FK_THONGKELOP_LOP",
                        column: x => x.id_Lop,
                        principalTable: "LOP",
                        principalColumn: "id_Lop");
                });

            migrationBuilder.CreateTable(
                name: "CAUTRUCDETHI",
                columns: table => new
                {
                    MaDeThi = table.Column<int>(type: "int", nullable: false),
                    MaPT = table.Column<int>(type: "int", nullable: false),
                    SoLuongCau = table.Column<int>(type: "int", nullable: true),
                    MaDoKhoPart = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAUTRUCDETHI", x => new { x.MaDeThi, x.MaPT });
                    table.ForeignKey(
                        name: "FK_CAUTRUCDETHI_MUCDOKHO",
                        column: x => x.MaDoKhoPart,
                        principalTable: "MUCDOKHO",
                        principalColumn: "MaMDK");
                    table.ForeignKey(
                        name: "FK_CAUTRUCDETHI_PHANTHI",
                        column: x => x.MaPT,
                        principalTable: "PHANTHI",
                        principalColumn: "MaPT");
                });

            migrationBuilder.CreateTable(
                name: "NHOMCH",
                columns: table => new
                {
                    MaNhomCH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KyHieu_NhomCh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ND_DoanVan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ND_HoiThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path_AudioNhom = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ID_GiaoVienTao = table.Column<int>(type: "int", nullable: true),
                    NgayTaoNhom = table.Column<DateOnly>(type: "date", nullable: true),
                    MaPT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHOMCH", x => x.MaNhomCH);
                    table.ForeignKey(
                        name: "FK_NHOMCH_GIAOVIEN",
                        column: x => x.ID_GiaoVienTao,
                        principalTable: "GIAOVIEN",
                        principalColumn: "MaGV");
                    table.ForeignKey(
                        name: "FK_NHOMCH_PHANTHI",
                        column: x => x.MaPT,
                        principalTable: "PHANTHI",
                        principalColumn: "MaPT");
                });

            migrationBuilder.CreateTable(
                name: "PHANLOAITL",
                columns: table => new
                {
                    MaPL = table.Column<int>(type: "int", nullable: false),
                    MaKN = table.Column<int>(type: "int", nullable: true),
                    MaPT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHANLOAITL", x => x.MaPL);
                    table.ForeignKey(
                        name: "FK_PHANLOAITL_KYNANG",
                        column: x => x.MaKN,
                        principalTable: "KYNANG",
                        principalColumn: "MaKN");
                    table.ForeignKey(
                        name: "FK_PHANLOAITL_PHANTHI",
                        column: x => x.MaPL,
                        principalTable: "PHANTHI",
                        principalColumn: "MaPT");
                });

            migrationBuilder.CreateTable(
                name: "LICHSUDUYETTL",
                columns: table => new
                {
                    MaLSD_TL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTL = table.Column<int>(type: "int", nullable: true),
                    ID_NguoiDuyetLS_TL = table.Column<int>(type: "int", nullable: true),
                    MaTT_Truoc_TL = table.Column<int>(type: "int", nullable: true),
                    MaTT_Moi_TL = table.Column<int>(type: "int", nullable: true),
                    GhiChuDuyetTL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiDiemDuyetTL = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LICHSUDUYETTL", x => x.MaLSD_TL);
                    table.ForeignKey(
                        name: "FK_LICHSUDUYETTL_KIEMDUYETVIEN",
                        column: x => x.ID_NguoiDuyetLS_TL,
                        principalTable: "KIEMDUYETVIEN",
                        principalColumn: "MaKDV");
                    table.ForeignKey(
                        name: "FK_LICHSUDUYETTL_TAILIEUHOCTAP",
                        column: x => x.MaTL,
                        principalTable: "TAILIEUHOCTAP",
                        principalColumn: "MaTL");
                    table.ForeignKey(
                        name: "FK_LICHSUDUYETTL_TRANGTHAITL",
                        column: x => x.MaTT_Truoc_TL,
                        principalTable: "TRANGTHAITL",
                        principalColumn: "MaTT_Tl");
                    table.ForeignKey(
                        name: "FK_LICHSUDUYETTL_TRANGTHAITL1",
                        column: x => x.MaTT_Moi_TL,
                        principalTable: "TRANGTHAITL",
                        principalColumn: "MaTT_Tl");
                });

            migrationBuilder.CreateTable(
                name: "TAILIEU_CHUDE",
                columns: table => new
                {
                    MaTL = table.Column<int>(type: "int", nullable: false),
                    MaChuDeTL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAILIEU_CHUDE", x => new { x.MaTL, x.MaChuDeTL });
                    table.ForeignKey(
                        name: "FK_TAILIEU_CHUDE_CHUDETL",
                        column: x => x.MaChuDeTL,
                        principalTable: "CHUDETL",
                        principalColumn: "MaChuDeTL");
                    table.ForeignKey(
                        name: "FK_TAILIEU_CHUDE_TAILIEUHOCTAP",
                        column: x => x.MaTL,
                        principalTable: "TAILIEUHOCTAP",
                        principalColumn: "MaTL");
                });

            migrationBuilder.CreateTable(
                name: "CAUHOI",
                columns: table => new
                {
                    MaCH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhomCH = table.Column<int>(type: "int", nullable: true),
                    ND_CauHoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path_AudioRieng = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Path_HinhAnh = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    GiaiThichDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaTT_CH = table.Column<int>(type: "int", nullable: true),
                    ID_GiaoVienTaoCH = table.Column<int>(type: "int", nullable: true),
                    ID_NguoiDuyetCH = table.Column<int>(type: "int", nullable: true),
                    STT_TrongNhom = table.Column<int>(type: "int", nullable: true),
                    NgayTaoCH = table.Column<DateOnly>(type: "date", nullable: true),
                    NgayDuyetCH = table.Column<DateOnly>(type: "date", nullable: true),
                    NgayCapNhatCH = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAUHOI", x => x.MaCH);
                    table.ForeignKey(
                        name: "FK_CAUHOI_GIAOVIEN",
                        column: x => x.ID_GiaoVienTaoCH,
                        principalTable: "GIAOVIEN",
                        principalColumn: "MaGV");
                    table.ForeignKey(
                        name: "FK_CAUHOI_KIEMDUYETVIEN",
                        column: x => x.ID_NguoiDuyetCH,
                        principalTable: "KIEMDUYETVIEN",
                        principalColumn: "MaKDV");
                    table.ForeignKey(
                        name: "FK_CAUHOI_NHOMCH",
                        column: x => x.MaNhomCH,
                        principalTable: "NHOMCH",
                        principalColumn: "MaNhomCH");
                    table.ForeignKey(
                        name: "FK_CAUHOI_TRANGTHAICH",
                        column: x => x.MaTT_CH,
                        principalTable: "TRANGTHAICH",
                        principalColumn: "MaTT_CH");
                });

            migrationBuilder.CreateTable(
                name: "DANGKYTHITHU",
                columns: table => new
                {
                    id_ThiThu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSV = table.Column<int>(type: "int", nullable: true),
                    NgayThiThu = table.Column<DateOnly>(type: "date", nullable: true),
                    CaThi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DiaDiem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DotThiThu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    id_DeThi = table.Column<int>(type: "int", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MaLSD_TL = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DANGKYTHITHU", x => x.id_ThiThu);
                    table.ForeignKey(
                        name: "FK_DANGKYTHITHU_DETHI",
                        column: x => x.id_DeThi,
                        principalTable: "DETHI",
                        principalColumn: "id_DeThi");
                    table.ForeignKey(
                        name: "FK_DANGKYTHITHU_LICHSUDUYETTL",
                        column: x => x.MaLSD_TL,
                        principalTable: "LICHSUDUYETTL",
                        principalColumn: "MaLSD_TL");
                    table.ForeignKey(
                        name: "FK_DANGKYTHITHU_SINHVIEN",
                        column: x => x.MaSV,
                        principalTable: "SINHVIEN",
                        principalColumn: "MaSV");
                });

            migrationBuilder.CreateTable(
                name: "CAUHOIBAITAP",
                columns: table => new
                {
                    id_BaiTap = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_PhieuBaiTap = table.Column<int>(type: "int", nullable: false),
                    MaCH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAUHOIBAITAP", x => x.id_BaiTap);
                    table.ForeignKey(
                        name: "FK_CAUHOIBAITAP_CAUHOI",
                        column: x => x.MaCH,
                        principalTable: "CAUHOI",
                        principalColumn: "MaCH");
                    table.ForeignKey(
                        name: "FK_CAUHOIBAITAP_PHIEUBAITAPONLUYEN",
                        column: x => x.id_PhieuBaiTap,
                        principalTable: "PHIEUBAITAPONLUYEN",
                        principalColumn: "id_PhieuBaiTap");
                });

            migrationBuilder.CreateTable(
                name: "CAUHOITRONG DETHI",
                columns: table => new
                {
                    MaDeThi = table.Column<int>(type: "int", nullable: false),
                    MaCH = table.Column<int>(type: "int", nullable: false),
                    STT_CH_TrongDe = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAUHOITRONG DETHI", x => new { x.MaDeThi, x.MaCH });
                    table.ForeignKey(
                        name: "FK_CAUHOITRONG DETHI_CAUHOI",
                        column: x => x.MaCH,
                        principalTable: "CAUHOI",
                        principalColumn: "MaCH");
                    table.ForeignKey(
                        name: "FK_CAUHOITRONG DETHI_DETHIDATAO",
                        column: x => x.MaDeThi,
                        principalTable: "DETHIDATAO",
                        principalColumn: "MaDeThi");
                });

            migrationBuilder.CreateTable(
                name: "D_DETHI",
                columns: table => new
                {
                    id_DDeThi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCH = table.Column<int>(type: "int", nullable: true),
                    id_DeThi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_DETHI", x => x.id_DDeThi);
                    table.ForeignKey(
                        name: "FK_D_DETHI_CAUHOI",
                        column: x => x.MaCH,
                        principalTable: "CAUHOI",
                        principalColumn: "MaCH");
                    table.ForeignKey(
                        name: "FK_D_DETHI_DETHI",
                        column: x => x.id_DeThi,
                        principalTable: "DETHI",
                        principalColumn: "id_DeThi");
                });

            migrationBuilder.CreateTable(
                name: "DAPAN",
                columns: table => new
                {
                    MaDA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCH = table.Column<int>(type: "int", nullable: true),
                    ND_DapAn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LaDapAnDung = table.Column<bool>(type: "bit", nullable: true),
                    KyHieuDA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAPAN", x => x.MaDA);
                    table.ForeignKey(
                        name: "FK_DAPAN_CAUHOI",
                        column: x => x.MaCH,
                        principalTable: "CAUHOI",
                        principalColumn: "MaCH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LICHSUDUYETCH",
                columns: table => new
                {
                    MaLSD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCH = table.Column<int>(type: "int", nullable: true),
                    ID_NguoiDuyetLS = table.Column<int>(type: "int", nullable: true),
                    MaTT_Truoc = table.Column<int>(type: "int", nullable: true),
                    MaTT_Sau = table.Column<int>(type: "int", nullable: true),
                    GhiCHuDuyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiDiemDuyet = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LICHSUDUYETCH", x => x.MaLSD);
                    table.ForeignKey(
                        name: "FK_LICHSUDUYETCH_CAUHOI",
                        column: x => x.MaCH,
                        principalTable: "CAUHOI",
                        principalColumn: "MaCH");
                    table.ForeignKey(
                        name: "FK_LICHSUDUYETCH_KIEMDUYETVIEN",
                        column: x => x.ID_NguoiDuyetLS,
                        principalTable: "KIEMDUYETVIEN",
                        principalColumn: "MaKDV");
                    table.ForeignKey(
                        name: "FK_LICHSUDUYETCH_TRANGTHAICH",
                        column: x => x.MaTT_Truoc,
                        principalTable: "TRANGTHAICH",
                        principalColumn: "MaTT_CH");
                    table.ForeignKey(
                        name: "FK_LICHSUDUYETCH_TRANGTHAICH1",
                        column: x => x.MaTT_Sau,
                        principalTable: "TRANGTHAICH",
                        principalColumn: "MaTT_CH");
                });

            migrationBuilder.CreateTable(
                name: "PHANLOAICH",
                columns: table => new
                {
                    MaCH = table.Column<int>(type: "int", nullable: false),
                    MaPT = table.Column<int>(type: "int", nullable: false),
                    MaKN = table.Column<int>(type: "int", nullable: false),
                    MaMDK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHANLOAICH", x => new { x.MaCH, x.MaPT });
                    table.ForeignKey(
                        name: "FK_PHANLOAICH_CAUHOI",
                        column: x => x.MaCH,
                        principalTable: "CAUHOI",
                        principalColumn: "MaCH");
                    table.ForeignKey(
                        name: "FK_PHANLOAICH_KYNANG",
                        column: x => x.MaKN,
                        principalTable: "KYNANG",
                        principalColumn: "MaKN");
                    table.ForeignKey(
                        name: "FK_PHANLOAICH_MUCDOKHO",
                        column: x => x.MaMDK,
                        principalTable: "MUCDOKHO",
                        principalColumn: "MaMDK");
                    table.ForeignKey(
                        name: "FK_PHANLOAICH_PHANTHI",
                        column: x => x.MaPT,
                        principalTable: "PHANTHI",
                        principalColumn: "MaPT");
                });

            migrationBuilder.CreateTable(
                name: "BIENBANTHITHU",
                columns: table => new
                {
                    id_BienBanThiThu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_ThiThu = table.Column<int>(type: "int", nullable: true),
                    DotThiThu = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DiaDiem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GiamThiCoiThi1 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    GiamThiCoiThi2 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIENBANTHITHU", x => x.id_BienBanThiThu);
                    table.ForeignKey(
                        name: "FK_BIENBANTHITHU_DANGKYTHITHU",
                        column: x => x.id_ThiThu,
                        principalTable: "DANGKYTHITHU",
                        principalColumn: "id_ThiThu");
                });

            migrationBuilder.CreateTable(
                name: "DIEMTHI",
                columns: table => new
                {
                    id_DiemThi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_ThiThu = table.Column<int>(type: "int", nullable: true),
                    MaSV = table.Column<int>(type: "int", nullable: true),
                    DiemPart1 = table.Column<int>(type: "int", nullable: true),
                    DiemPart2 = table.Column<int>(type: "int", nullable: true),
                    DiemPart3 = table.Column<int>(type: "int", nullable: true),
                    DiemPart4 = table.Column<int>(type: "int", nullable: true),
                    DiemPart5 = table.Column<int>(type: "int", nullable: true),
                    DiemPart6 = table.Column<int>(type: "int", nullable: true),
                    DiemPart7 = table.Column<int>(type: "int", nullable: true),
                    TongDiem = table.Column<int>(type: "int", nullable: true),
                    Bac = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIEMTHI", x => x.id_DiemThi);
                    table.ForeignKey(
                        name: "FK_DIEMTHI_DANGKYTHITHU",
                        column: x => x.id_ThiThu,
                        principalTable: "DANGKYTHITHU",
                        principalColumn: "id_ThiThu");
                    table.ForeignKey(
                        name: "FK_DIEMTHI_SINHVIEN",
                        column: x => x.MaSV,
                        principalTable: "SINHVIEN",
                        principalColumn: "MaSV");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BAIVIET_MaDD",
                table: "BAIVIET",
                column: "MaDD");

            migrationBuilder.CreateIndex(
                name: "IX_BAIVIET_MaNguoiTao",
                table: "BAIVIET",
                column: "MaNguoiTao");

            migrationBuilder.CreateIndex(
                name: "IX_BIENBANTHITHU_id_ThiThu",
                table: "BIENBANTHITHU",
                column: "id_ThiThu");

            migrationBuilder.CreateIndex(
                name: "IX_CAUHOI_ID_GiaoVienTaoCH",
                table: "CAUHOI",
                column: "ID_GiaoVienTaoCH");

            migrationBuilder.CreateIndex(
                name: "IX_CAUHOI_ID_NguoiDuyetCH",
                table: "CAUHOI",
                column: "ID_NguoiDuyetCH");

            migrationBuilder.CreateIndex(
                name: "IX_CAUHOI_MaNhomCH",
                table: "CAUHOI",
                column: "MaNhomCH");

            migrationBuilder.CreateIndex(
                name: "IX_CAUHOI_MaTT_CH",
                table: "CAUHOI",
                column: "MaTT_CH");

            migrationBuilder.CreateIndex(
                name: "IX_CAUHOIBAITAP_id_PhieuBaiTap",
                table: "CAUHOIBAITAP",
                column: "id_PhieuBaiTap");

            migrationBuilder.CreateIndex(
                name: "IX_CAUHOIBAITAP_MaCH",
                table: "CAUHOIBAITAP",
                column: "MaCH");

            migrationBuilder.CreateIndex(
                name: "IX_CAUHOITRONG DETHI_MaCH",
                table: "CAUHOITRONG DETHI",
                column: "MaCH");

            migrationBuilder.CreateIndex(
                name: "IX_CAUTRUCDETHI_MaDoKhoPart",
                table: "CAUTRUCDETHI",
                column: "MaDoKhoPart");

            migrationBuilder.CreateIndex(
                name: "IX_CAUTRUCDETHI_MaPT",
                table: "CAUTRUCDETHI",
                column: "MaPT");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETBAITHI_MaSV",
                table: "CHITIETBAITHI",
                column: "MaSV");

            migrationBuilder.CreateIndex(
                name: "IX_D_DETHI_id_DeThi",
                table: "D_DETHI",
                column: "id_DeThi");

            migrationBuilder.CreateIndex(
                name: "IX_D_DETHI_MaCH",
                table: "D_DETHI",
                column: "MaCH");

            migrationBuilder.CreateIndex(
                name: "IX_DANGKYONLUYEN_id_Lop",
                table: "DANGKYONLUYEN",
                column: "id_Lop");

            migrationBuilder.CreateIndex(
                name: "IX_DANGKYONLUYEN_MaSV",
                table: "DANGKYONLUYEN",
                column: "MaSV");

            migrationBuilder.CreateIndex(
                name: "IX_DANGKYTHITHU_id_DeThi",
                table: "DANGKYTHITHU",
                column: "id_DeThi");

            migrationBuilder.CreateIndex(
                name: "IX_DANGKYTHITHU_MaLSD_TL",
                table: "DANGKYTHITHU",
                column: "MaLSD_TL");

            migrationBuilder.CreateIndex(
                name: "IX_DANGKYTHITHU_MaSV",
                table: "DANGKYTHITHU",
                column: "MaSV");

            migrationBuilder.CreateIndex(
                name: "IX_DAPAN_MaCH",
                table: "DAPAN",
                column: "MaCH");

            migrationBuilder.CreateIndex(
                name: "IX_DETHIDATAO_ID_GiaoVienTaoDe",
                table: "DETHIDATAO",
                column: "ID_GiaoVienTaoDe");

            migrationBuilder.CreateIndex(
                name: "IX_DETHIDATAO_ID_SinhVienTaoDe",
                table: "DETHIDATAO",
                column: "ID_SinhVienTaoDe");

            migrationBuilder.CreateIndex(
                name: "IX_DETHIDATAO_MaLoaiDe",
                table: "DETHIDATAO",
                column: "MaLoaiDe");

            migrationBuilder.CreateIndex(
                name: "IX_DETHIDATAO_MaTrangThaiDeThi",
                table: "DETHIDATAO",
                column: "MaTrangThaiDeThi");

            migrationBuilder.CreateIndex(
                name: "IX_DIEMTHI_id_ThiThu",
                table: "DIEMTHI",
                column: "id_ThiThu");

            migrationBuilder.CreateIndex(
                name: "IX_DIEMTHI_MaSV",
                table: "DIEMTHI",
                column: "MaSV");

            migrationBuilder.CreateIndex(
                name: "IX_DIENDAN_MaDDN",
                table: "DIENDAN",
                column: "MaDDN");

            migrationBuilder.CreateIndex(
                name: "IX_DONKHIEUNAI_MaBT",
                table: "DONKHIEUNAI",
                column: "MaBT");

            migrationBuilder.CreateIndex(
                name: "IX_DONKHIEUNAI_MaSV",
                table: "DONKHIEUNAI",
                column: "MaSV");

            migrationBuilder.CreateIndex(
                name: "IX_GIAOVIEN_DIENDAN_MaGV",
                table: "GIAOVIEN_DIENDAN",
                column: "MaGV");

            migrationBuilder.CreateIndex(
                name: "IX_LICHSUDUYETCH_ID_NguoiDuyetLS",
                table: "LICHSUDUYETCH",
                column: "ID_NguoiDuyetLS");

            migrationBuilder.CreateIndex(
                name: "IX_LICHSUDUYETCH_MaCH",
                table: "LICHSUDUYETCH",
                column: "MaCH");

            migrationBuilder.CreateIndex(
                name: "IX_LICHSUDUYETCH_MaTT_Sau",
                table: "LICHSUDUYETCH",
                column: "MaTT_Sau");

            migrationBuilder.CreateIndex(
                name: "IX_LICHSUDUYETCH_MaTT_Truoc",
                table: "LICHSUDUYETCH",
                column: "MaTT_Truoc");

            migrationBuilder.CreateIndex(
                name: "IX_LICHSUDUYETTL_ID_NguoiDuyetLS_TL",
                table: "LICHSUDUYETTL",
                column: "ID_NguoiDuyetLS_TL");

            migrationBuilder.CreateIndex(
                name: "IX_LICHSUDUYETTL_MaTL",
                table: "LICHSUDUYETTL",
                column: "MaTL");

            migrationBuilder.CreateIndex(
                name: "IX_LICHSUDUYETTL_MaTT_Moi_TL",
                table: "LICHSUDUYETTL",
                column: "MaTT_Moi_TL");

            migrationBuilder.CreateIndex(
                name: "IX_LICHSUDUYETTL_MaTT_Truoc_TL",
                table: "LICHSUDUYETTL",
                column: "MaTT_Truoc_TL");

            migrationBuilder.CreateIndex(
                name: "IX_LOP_MaGV",
                table: "LOP",
                column: "MaGV");

            migrationBuilder.CreateIndex(
                name: "IX_NHOMCH_ID_GiaoVienTao",
                table: "NHOMCH",
                column: "ID_GiaoVienTao");

            migrationBuilder.CreateIndex(
                name: "IX_NHOMCH_MaPT",
                table: "NHOMCH",
                column: "MaPT");

            migrationBuilder.CreateIndex(
                name: "IX_PHANLOAICH_MaKN",
                table: "PHANLOAICH",
                column: "MaKN");

            migrationBuilder.CreateIndex(
                name: "IX_PHANLOAICH_MaMDK",
                table: "PHANLOAICH",
                column: "MaMDK");

            migrationBuilder.CreateIndex(
                name: "IX_PHANLOAICH_MaPT",
                table: "PHANLOAICH",
                column: "MaPT");

            migrationBuilder.CreateIndex(
                name: "IX_PHANLOAITL_MaKN",
                table: "PHANLOAITL",
                column: "MaKN");

            migrationBuilder.CreateIndex(
                name: "IX_PHANTHI_MaKN",
                table: "PHANTHI",
                column: "MaKN");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUBAITAPONLUYEN_MaSV",
                table: "PHIEUBAITAPONLUYEN",
                column: "MaSV");

            migrationBuilder.CreateIndex(
                name: "IX_TAILIEU_CHUDE_MaChuDeTL",
                table: "TAILIEU_CHUDE",
                column: "MaChuDeTL");

            migrationBuilder.CreateIndex(
                name: "IX_TAILIEUHOCTAP_ID_NguoiDuyetTL",
                table: "TAILIEUHOCTAP",
                column: "ID_NguoiDuyetTL");

            migrationBuilder.CreateIndex(
                name: "IX_TAILIEUHOCTAP_ID_NguoiTaiLen",
                table: "TAILIEUHOCTAP",
                column: "ID_NguoiTaiLen");

            migrationBuilder.CreateIndex(
                name: "IX_TAILIEUHOCTAP_MaLoaiTL",
                table: "TAILIEUHOCTAP",
                column: "MaLoaiTL");

            migrationBuilder.CreateIndex(
                name: "IX_TAILIEUHOCTAP_MaTT_TL",
                table: "TAILIEUHOCTAP",
                column: "MaTT_TL");

            migrationBuilder.CreateIndex(
                name: "IX_THAMGIA_MaSV",
                table: "THAMGIA",
                column: "MaSV");

            migrationBuilder.CreateIndex(
                name: "IX_THONGKELOP_id_Lop",
                table: "THONGKELOP",
                column: "id_Lop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BAIVIET");

            migrationBuilder.DropTable(
                name: "BIENBANTHITHU");

            migrationBuilder.DropTable(
                name: "CAUHOIBAITAP");

            migrationBuilder.DropTable(
                name: "CAUHOITRONG DETHI");

            migrationBuilder.DropTable(
                name: "CAUTRUCDETHI");

            migrationBuilder.DropTable(
                name: "CHITIETBAITHI");

            migrationBuilder.DropTable(
                name: "ChudetlTailieuhoctap");

            migrationBuilder.DropTable(
                name: "D_DETHI");

            migrationBuilder.DropTable(
                name: "DANGKYONLUYEN");

            migrationBuilder.DropTable(
                name: "DAPAN");

            migrationBuilder.DropTable(
                name: "DIEMTHI");

            migrationBuilder.DropTable(
                name: "DONKHIEUNAI");

            migrationBuilder.DropTable(
                name: "GIAOVIEN_DIENDAN");

            migrationBuilder.DropTable(
                name: "LICHHOC");

            migrationBuilder.DropTable(
                name: "LICHSUDUYETCH");

            migrationBuilder.DropTable(
                name: "LICHTHITOIEC");

            migrationBuilder.DropTable(
                name: "PHANLOAICH");

            migrationBuilder.DropTable(
                name: "PHANLOAITL");

            migrationBuilder.DropTable(
                name: "PHIEUDANGKYTOIEC");

            migrationBuilder.DropTable(
                name: "TAILIEU_CHUDE");

            migrationBuilder.DropTable(
                name: "THAMGIA");

            migrationBuilder.DropTable(
                name: "THONGKELOP");

            migrationBuilder.DropTable(
                name: "TT_LICHTHITOIEC");

            migrationBuilder.DropTable(
                name: "PHIEUBAITAPONLUYEN");

            migrationBuilder.DropTable(
                name: "DETHIDATAO");

            migrationBuilder.DropTable(
                name: "DANGKYTHITHU");

            migrationBuilder.DropTable(
                name: "BAITHI");

            migrationBuilder.DropTable(
                name: "CAUHOI");

            migrationBuilder.DropTable(
                name: "MUCDOKHO");

            migrationBuilder.DropTable(
                name: "CHUDETL");

            migrationBuilder.DropTable(
                name: "DIENDAN");

            migrationBuilder.DropTable(
                name: "LOP");

            migrationBuilder.DropTable(
                name: "LOAIDETHI");

            migrationBuilder.DropTable(
                name: "TRANGTHAIDETHI");

            migrationBuilder.DropTable(
                name: "DETHI");

            migrationBuilder.DropTable(
                name: "LICHSUDUYETTL");

            migrationBuilder.DropTable(
                name: "SINHVIEN");

            migrationBuilder.DropTable(
                name: "NHOMCH");

            migrationBuilder.DropTable(
                name: "TRANGTHAICH");

            migrationBuilder.DropTable(
                name: "DONDENGHITAODD");

            migrationBuilder.DropTable(
                name: "TAILIEUHOCTAP");

            migrationBuilder.DropTable(
                name: "PHANTHI");

            migrationBuilder.DropTable(
                name: "GIAOVIEN");

            migrationBuilder.DropTable(
                name: "KIEMDUYETVIEN");

            migrationBuilder.DropTable(
                name: "LOAITAILIEU");

            migrationBuilder.DropTable(
                name: "TRANGTHAITL");

            migrationBuilder.DropTable(
                name: "KYNANG");
        }
    }
}
