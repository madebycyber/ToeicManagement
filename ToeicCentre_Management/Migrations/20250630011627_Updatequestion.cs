using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToeicCentre_Management.Migrations
{
    /// <inheritdoc />
    public partial class Updatequestion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BAIVIET_DIENDAN",
                table: "BAIVIET");

            migrationBuilder.DropForeignKey(
                name: "FK_BAIVIET_GIAOVIEN",
                table: "BAIVIET");

            migrationBuilder.DropForeignKey(
                name: "FK_BIENBANTHITHU_DANGKYTHITHU",
                table: "BIENBANTHITHU");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOI_GIAOVIEN",
                table: "CAUHOI");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOI_KIEMDUYETVIEN",
                table: "CAUHOI");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOI_NHOMCH",
                table: "CAUHOI");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOI_TRANGTHAICH",
                table: "CAUHOI");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOIBAITAP_CAUHOI",
                table: "CAUHOIBAITAP");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOIBAITAP_PHIEUBAITAPONLUYEN",
                table: "CAUHOIBAITAP");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOITRONG DETHI_CAUHOI",
                table: "CAUHOITRONG DETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOITRONG DETHI_DETHIDATAO",
                table: "CAUHOITRONG DETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUTRUCDETHI_MUCDOKHO",
                table: "CAUTRUCDETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUTRUCDETHI_PHANTHI",
                table: "CAUTRUCDETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_CHITIETBAITHI_BAITHI",
                table: "CHITIETBAITHI");

            migrationBuilder.DropForeignKey(
                name: "FK_CHITIETBAITHI_SINHVIEN",
                table: "CHITIETBAITHI");

            migrationBuilder.DropForeignKey(
                name: "FK_D_DETHI_CAUHOI",
                table: "D_DETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_D_DETHI_DETHI",
                table: "D_DETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_DANGKYONLUYEN_LOP",
                table: "DANGKYONLUYEN");

            migrationBuilder.DropForeignKey(
                name: "FK_DANGKYONLUYEN_SINHVIEN",
                table: "DANGKYONLUYEN");

            migrationBuilder.DropForeignKey(
                name: "FK_DANGKYTHITHU_DETHI",
                table: "DANGKYTHITHU");

            migrationBuilder.DropForeignKey(
                name: "FK_DANGKYTHITHU_LICHSUDUYETTL",
                table: "DANGKYTHITHU");

            migrationBuilder.DropForeignKey(
                name: "FK_DANGKYTHITHU_SINHVIEN",
                table: "DANGKYTHITHU");

            migrationBuilder.DropForeignKey(
                name: "FK_DAPAN_CAUHOI",
                table: "DAPAN");

            migrationBuilder.DropForeignKey(
                name: "FK_DETHIDATAO_GIAOVIEN",
                table: "DETHIDATAO");

            migrationBuilder.DropForeignKey(
                name: "FK_DETHIDATAO_LOAIDETHI",
                table: "DETHIDATAO");

            migrationBuilder.DropForeignKey(
                name: "FK_DETHIDATAO_SINHVIEN",
                table: "DETHIDATAO");

            migrationBuilder.DropForeignKey(
                name: "FK_DETHIDATAO_TRANGTHAIDETHI",
                table: "DETHIDATAO");

            migrationBuilder.DropForeignKey(
                name: "FK_DIEMTHI_DANGKYTHITHU",
                table: "DIEMTHI");

            migrationBuilder.DropForeignKey(
                name: "FK_DIEMTHI_SINHVIEN",
                table: "DIEMTHI");

            migrationBuilder.DropForeignKey(
                name: "FK_DIENDAN_DONDENGHITAODD",
                table: "DIENDAN");

            migrationBuilder.DropForeignKey(
                name: "FK_DONKHIEUNAI_BAITHI",
                table: "DONKHIEUNAI");

            migrationBuilder.DropForeignKey(
                name: "FK_DONKHIEUNAI_SINHVIEN",
                table: "DONKHIEUNAI");

            migrationBuilder.DropForeignKey(
                name: "FK_GIAOVIEN_DIENDAN_DIENDAN",
                table: "GIAOVIEN_DIENDAN");

            migrationBuilder.DropForeignKey(
                name: "FK_GIAOVIEN_DIENDAN_GIAOVIEN",
                table: "GIAOVIEN_DIENDAN");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETCH_CAUHOI",
                table: "LICHSUDUYETCH");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETCH_KIEMDUYETVIEN",
                table: "LICHSUDUYETCH");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETCH_TRANGTHAICH",
                table: "LICHSUDUYETCH");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETCH_TRANGTHAICH1",
                table: "LICHSUDUYETCH");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETTL_KIEMDUYETVIEN",
                table: "LICHSUDUYETTL");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETTL_TAILIEUHOCTAP",
                table: "LICHSUDUYETTL");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETTL_TRANGTHAITL",
                table: "LICHSUDUYETTL");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETTL_TRANGTHAITL1",
                table: "LICHSUDUYETTL");

            migrationBuilder.DropForeignKey(
                name: "FK_LOP_GIAOVIEN",
                table: "LOP");

            migrationBuilder.DropForeignKey(
                name: "FK_NHOMCH_GIAOVIEN",
                table: "NHOMCH");

            migrationBuilder.DropForeignKey(
                name: "FK_NHOMCH_PHANTHI",
                table: "NHOMCH");

            migrationBuilder.DropForeignKey(
                name: "FK_PHANLOAICH_CAUHOI",
                table: "PHANLOAICH");

            migrationBuilder.DropForeignKey(
                name: "FK_PHANLOAICH_KYNANG",
                table: "PHANLOAICH");

            migrationBuilder.DropForeignKey(
                name: "FK_PHANLOAICH_MUCDOKHO",
                table: "PHANLOAICH");

            migrationBuilder.DropForeignKey(
                name: "FK_PHANLOAICH_PHANTHI",
                table: "PHANLOAICH");

            migrationBuilder.DropForeignKey(
                name: "FK_PHANLOAITL_KYNANG",
                table: "PHANLOAITL");

            migrationBuilder.DropForeignKey(
                name: "FK_PHANLOAITL_PHANTHI",
                table: "PHANLOAITL");

            migrationBuilder.DropForeignKey(
                name: "FK_PHANTHI_KYNANG",
                table: "PHANTHI");

            migrationBuilder.DropForeignKey(
                name: "FK_PHIEUBAITAPONLUYEN_SINHVIEN",
                table: "PHIEUBAITAPONLUYEN");

            migrationBuilder.DropForeignKey(
                name: "FK_TAILIEUHOCTAP_GIAOVIEN",
                table: "TAILIEUHOCTAP");

            migrationBuilder.DropForeignKey(
                name: "FK_TAILIEUHOCTAP_KIEMDUYETVIEN",
                table: "TAILIEUHOCTAP");

            migrationBuilder.DropForeignKey(
                name: "FK_TAILIEUHOCTAP_LOAITAILIEU",
                table: "TAILIEUHOCTAP");

            migrationBuilder.DropForeignKey(
                name: "FK_TAILIEUHOCTAP_TRANGTHAITL",
                table: "TAILIEUHOCTAP");

            migrationBuilder.DropForeignKey(
                name: "FK_THAMGIA_DIENDAN",
                table: "THAMGIA");

            migrationBuilder.DropForeignKey(
                name: "FK_THAMGIA_SINHVIEN",
                table: "THAMGIA");

            migrationBuilder.DropForeignKey(
                name: "FK_THONGKELOP_LOP",
                table: "THONGKELOP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TRANGTHAICH",
                table: "TRANGTHAICH");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAILIEUHOCTAP",
                table: "TAILIEUHOCTAP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PHANTHI",
                table: "PHANTHI");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PHANLOAICH",
                table: "PHANLOAICH");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NHOMCH",
                table: "NHOMCH");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KYNANG",
                table: "KYNANG");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KIEMDUYETVIEN",
                table: "KIEMDUYETVIEN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GIAOVIEN",
                table: "GIAOVIEN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DAPAN",
                table: "DAPAN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAUHOI",
                table: "CAUHOI");

            migrationBuilder.RenameTable(
                name: "TRANGTHAICH",
                newName: "Trangthaich");

            migrationBuilder.RenameTable(
                name: "TAILIEUHOCTAP",
                newName: "Tailieuhoctap");

            migrationBuilder.RenameTable(
                name: "PHANTHI",
                newName: "Phanthi");

            migrationBuilder.RenameTable(
                name: "PHANLOAICH",
                newName: "Phanloaich");

            migrationBuilder.RenameTable(
                name: "NHOMCH",
                newName: "Nhomch");

            migrationBuilder.RenameTable(
                name: "KYNANG",
                newName: "Kynang");

            migrationBuilder.RenameTable(
                name: "KIEMDUYETVIEN",
                newName: "Kiemduyetvien");

            migrationBuilder.RenameTable(
                name: "GIAOVIEN",
                newName: "Giaovien");

            migrationBuilder.RenameTable(
                name: "DAPAN",
                newName: "Dapan");

            migrationBuilder.RenameTable(
                name: "CAUHOI",
                newName: "Cauhoi");

            migrationBuilder.RenameIndex(
                name: "IX_TAILIEUHOCTAP_MaTT_TL",
                table: "Tailieuhoctap",
                newName: "IX_Tailieuhoctap_MaTT_TL");

            migrationBuilder.RenameIndex(
                name: "IX_TAILIEUHOCTAP_MaLoaiTL",
                table: "Tailieuhoctap",
                newName: "IX_Tailieuhoctap_MaLoaiTL");

            migrationBuilder.RenameIndex(
                name: "IX_TAILIEUHOCTAP_ID_NguoiTaiLen",
                table: "Tailieuhoctap",
                newName: "IX_Tailieuhoctap_ID_NguoiTaiLen");

            migrationBuilder.RenameIndex(
                name: "IX_TAILIEUHOCTAP_ID_NguoiDuyetTL",
                table: "Tailieuhoctap",
                newName: "IX_Tailieuhoctap_ID_NguoiDuyetTL");

            migrationBuilder.RenameIndex(
                name: "IX_PHANTHI_MaKN",
                table: "Phanthi",
                newName: "IX_Phanthi_MaKN");

            migrationBuilder.RenameIndex(
                name: "IX_PHANLOAICH_MaPT",
                table: "Phanloaich",
                newName: "IX_Phanloaich_MaPT");

            migrationBuilder.RenameIndex(
                name: "IX_PHANLOAICH_MaMDK",
                table: "Phanloaich",
                newName: "IX_Phanloaich_MaMDK");

            migrationBuilder.RenameIndex(
                name: "IX_PHANLOAICH_MaKN",
                table: "Phanloaich",
                newName: "IX_Phanloaich_MaKN");

            migrationBuilder.RenameColumn(
                name: "KyHieu_NhomCh",
                table: "Nhomch",
                newName: "KyHieu_NhomCH");

            migrationBuilder.RenameIndex(
                name: "IX_NHOMCH_MaPT",
                table: "Nhomch",
                newName: "IX_Nhomch_MaPT");

            migrationBuilder.RenameIndex(
                name: "IX_NHOMCH_ID_GiaoVienTao",
                table: "Nhomch",
                newName: "IX_Nhomch_ID_GiaoVienTao");

            migrationBuilder.RenameIndex(
                name: "IX_DAPAN_MaCH",
                table: "Dapan",
                newName: "IX_Dapan_MaCH");

            migrationBuilder.RenameIndex(
                name: "IX_CAUHOI_MaTT_CH",
                table: "Cauhoi",
                newName: "IX_Cauhoi_MaTT_CH");

            migrationBuilder.RenameIndex(
                name: "IX_CAUHOI_MaNhomCH",
                table: "Cauhoi",
                newName: "IX_Cauhoi_MaNhomCH");

            migrationBuilder.RenameIndex(
                name: "IX_CAUHOI_ID_NguoiDuyetCH",
                table: "Cauhoi",
                newName: "IX_Cauhoi_ID_NguoiDuyetCH");

            migrationBuilder.RenameIndex(
                name: "IX_CAUHOI_ID_GiaoVienTaoCH",
                table: "Cauhoi",
                newName: "IX_Cauhoi_ID_GiaoVienTaoCH");

            migrationBuilder.AlterColumn<string>(
                name: "URL_NgoaiTL",
                table: "Tailieuhoctap",
                type: "varchar(1000)",
                unicode: false,
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path_FileTL",
                table: "Tailieuhoctap",
                type: "varchar(500)",
                unicode: false,
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTaiLenTL",
                table: "Tailieuhoctap",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getutcdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path_AudioNhom",
                table: "Nhomch",
                type: "varchar(500)",
                unicode: false,
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "NgayTaoNhom",
                table: "Nhomch",
                type: "date",
                nullable: true,
                defaultValueSql: "(getutcdate())",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KyHieu_NhomCH",
                table: "Nhomch",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenDangNhapKDV",
                table: "Kiemduyetvien",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailKDV",
                table: "Kiemduyetvien",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenDangNhapGV",
                table: "Giaovien",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Giaovien",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bac",
                table: "DIEMTHI",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KyHieuDA",
                table: "Dapan",
                type: "varchar(1)",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path_HinhAnh",
                table: "Cauhoi",
                type: "varchar(500)",
                unicode: false,
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path_AudioRieng",
                table: "Cauhoi",
                type: "varchar(500)",
                unicode: false,
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "NgayTaoCH",
                table: "Cauhoi",
                type: "date",
                nullable: true,
                defaultValueSql: "(getutcdate())",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaBT",
                table: "BAITHI",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK__TrangTha__853A7EF0C0E067CB",
                table: "Trangthaich",
                column: "MaTT_CH");

            migrationBuilder.AddPrimaryKey(
                name: "PK__TaiLieuH__2725007100A8DEC2",
                table: "Tailieuhoctap",
                column: "MaTL");

            migrationBuilder.AddPrimaryKey(
                name: "PK__PhanThi__2725E7F6D80C8DA8",
                table: "Phanthi",
                column: "MaPT");

            migrationBuilder.AddPrimaryKey(
                name: "PK__PhanLoai__5557D07F80AC11A1",
                table: "Phanloaich",
                columns: new[] { "MaCH", "MaPT" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__NhomCH__5A1F247DC67BF8B8",
                table: "Nhomch",
                column: "MaNhomCH");

            migrationBuilder.AddPrimaryKey(
                name: "PK__KyNang__2725CF140DA899C6",
                table: "Kynang",
                column: "MaKN");

            migrationBuilder.AddPrimaryKey(
                name: "PK__KiemDuye__3BDEA374C697BD05",
                table: "Kiemduyetvien",
                column: "MaKDV");

            migrationBuilder.AddPrimaryKey(
                name: "PK__GiaoVien__2725AEF36F8181E1",
                table: "Giaovien",
                column: "MaGV");

            migrationBuilder.AddPrimaryKey(
                name: "PK__DapAn__2725867A10592A45",
                table: "Dapan",
                column: "MaDA");

            migrationBuilder.AddPrimaryKey(
                name: "PK__CauHoi__27258E00C4D3AB47",
                table: "Cauhoi",
                column: "MaCH");

            migrationBuilder.CreateIndex(
                name: "UQ__NhomCH__672E42A04E462227",
                table: "Nhomch",
                column: "KyHieu_NhomCH",
                unique: true,
                filter: "[KyHieu_NhomCH] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__KiemDuye__B8DA919D3A066022",
                table: "Kiemduyetvien",
                column: "EmailKDV",
                unique: true,
                filter: "[EmailKDV] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__KiemDuye__D23D381579F74216",
                table: "Kiemduyetvien",
                column: "TenDangNhapKDV",
                unique: true,
                filter: "[TenDangNhapKDV] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__GiaoVien__6A6BEFC49AB6F408",
                table: "Giaovien",
                column: "TenDangNhapGV",
                unique: true,
                filter: "[TenDangNhapGV] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__GiaoVien__A9D1053497C9C9AF",
                table: "Giaovien",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BAIVIET_DIENDAN_MaDD",
                table: "BAIVIET",
                column: "MaDD",
                principalTable: "DIENDAN",
                principalColumn: "MaDD");

            migrationBuilder.AddForeignKey(
                name: "FK_BAIVIET_Giaovien_MaNguoiTao",
                table: "BAIVIET",
                column: "MaNguoiTao",
                principalTable: "Giaovien",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK_BIENBANTHITHU_DANGKYTHITHU_id_ThiThu",
                table: "BIENBANTHITHU",
                column: "id_ThiThu",
                principalTable: "DANGKYTHITHU",
                principalColumn: "id_ThiThu");

            migrationBuilder.AddForeignKey(
                name: "FK__CauHoi__ID_GiaoV__5FB337D6",
                table: "Cauhoi",
                column: "ID_GiaoVienTaoCH",
                principalTable: "Giaovien",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK__CauHoi__ID_Nguoi__60A75C0F",
                table: "Cauhoi",
                column: "ID_NguoiDuyetCH",
                principalTable: "Kiemduyetvien",
                principalColumn: "MaKDV");

            migrationBuilder.AddForeignKey(
                name: "FK__CauHoi__MaNhomCH__5DCAEF64",
                table: "Cauhoi",
                column: "MaNhomCH",
                principalTable: "Nhomch",
                principalColumn: "MaNhomCH");

            migrationBuilder.AddForeignKey(
                name: "FK__CauHoi__MaTT_CH__5EBF139D",
                table: "Cauhoi",
                column: "MaTT_CH",
                principalTable: "Trangthaich",
                principalColumn: "MaTT_CH");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOIBAITAP_Cauhoi_MaCH",
                table: "CAUHOIBAITAP",
                column: "MaCH",
                principalTable: "Cauhoi",
                principalColumn: "MaCH");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOIBAITAP_PHIEUBAITAPONLUYEN_id_PhieuBaiTap",
                table: "CAUHOIBAITAP",
                column: "id_PhieuBaiTap",
                principalTable: "PHIEUBAITAPONLUYEN",
                principalColumn: "id_PhieuBaiTap",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOITRONG DETHI_Cauhoi_MaCH",
                table: "CAUHOITRONG DETHI",
                column: "MaCH",
                principalTable: "Cauhoi",
                principalColumn: "MaCH",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOITRONG DETHI_DETHIDATAO_MaDeThi",
                table: "CAUHOITRONG DETHI",
                column: "MaDeThi",
                principalTable: "DETHIDATAO",
                principalColumn: "MaDeThi",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAUTRUCDETHI_MUCDOKHO_MaDoKhoPart",
                table: "CAUTRUCDETHI",
                column: "MaDoKhoPart",
                principalTable: "MUCDOKHO",
                principalColumn: "MaMDK");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUTRUCDETHI_Phanthi_MaPT",
                table: "CAUTRUCDETHI",
                column: "MaPT",
                principalTable: "Phanthi",
                principalColumn: "MaPT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CHITIETBAITHI_BAITHI_MaBT",
                table: "CHITIETBAITHI",
                column: "MaBT",
                principalTable: "BAITHI",
                principalColumn: "MaBT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CHITIETBAITHI_SINHVIEN_MaSV",
                table: "CHITIETBAITHI",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_D_DETHI_Cauhoi_MaCH",
                table: "D_DETHI",
                column: "MaCH",
                principalTable: "Cauhoi",
                principalColumn: "MaCH");

            migrationBuilder.AddForeignKey(
                name: "FK_D_DETHI_DETHI_id_DeThi",
                table: "D_DETHI",
                column: "id_DeThi",
                principalTable: "DETHI",
                principalColumn: "id_DeThi");

            migrationBuilder.AddForeignKey(
                name: "FK_DANGKYONLUYEN_LOP_id_Lop",
                table: "DANGKYONLUYEN",
                column: "id_Lop",
                principalTable: "LOP",
                principalColumn: "id_Lop");

            migrationBuilder.AddForeignKey(
                name: "FK_DANGKYONLUYEN_SINHVIEN_MaSV",
                table: "DANGKYONLUYEN",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_DANGKYTHITHU_DETHI_id_DeThi",
                table: "DANGKYTHITHU",
                column: "id_DeThi",
                principalTable: "DETHI",
                principalColumn: "id_DeThi");

            migrationBuilder.AddForeignKey(
                name: "FK_DANGKYTHITHU_LICHSUDUYETTL_MaLSD_TL",
                table: "DANGKYTHITHU",
                column: "MaLSD_TL",
                principalTable: "LICHSUDUYETTL",
                principalColumn: "MaLSD_TL");

            migrationBuilder.AddForeignKey(
                name: "FK_DANGKYTHITHU_SINHVIEN_MaSV",
                table: "DANGKYTHITHU",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK__DapAn__MaCH__6477ECF3",
                table: "Dapan",
                column: "MaCH",
                principalTable: "Cauhoi",
                principalColumn: "MaCH");

            migrationBuilder.AddForeignKey(
                name: "FK_DETHIDATAO_Giaovien_ID_GiaoVienTaoDe",
                table: "DETHIDATAO",
                column: "ID_GiaoVienTaoDe",
                principalTable: "Giaovien",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK_DETHIDATAO_LOAIDETHI_MaLoaiDe",
                table: "DETHIDATAO",
                column: "MaLoaiDe",
                principalTable: "LOAIDETHI",
                principalColumn: "MaLoaiDe");

            migrationBuilder.AddForeignKey(
                name: "FK_DETHIDATAO_SINHVIEN_ID_SinhVienTaoDe",
                table: "DETHIDATAO",
                column: "ID_SinhVienTaoDe",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_DETHIDATAO_TRANGTHAIDETHI_MaTrangThaiDeThi",
                table: "DETHIDATAO",
                column: "MaTrangThaiDeThi",
                principalTable: "TRANGTHAIDETHI",
                principalColumn: "MaTrangThaiDe");

            migrationBuilder.AddForeignKey(
                name: "FK_DIEMTHI_DANGKYTHITHU_id_ThiThu",
                table: "DIEMTHI",
                column: "id_ThiThu",
                principalTable: "DANGKYTHITHU",
                principalColumn: "id_ThiThu");

            migrationBuilder.AddForeignKey(
                name: "FK_DIEMTHI_SINHVIEN_MaSV",
                table: "DIEMTHI",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_DIENDAN_DONDENGHITAODD_MaDDN",
                table: "DIENDAN",
                column: "MaDDN",
                principalTable: "DONDENGHITAODD",
                principalColumn: "MaDDN");

            migrationBuilder.AddForeignKey(
                name: "FK_DONKHIEUNAI_BAITHI_MaBT",
                table: "DONKHIEUNAI",
                column: "MaBT",
                principalTable: "BAITHI",
                principalColumn: "MaBT");

            migrationBuilder.AddForeignKey(
                name: "FK_DONKHIEUNAI_SINHVIEN_MaSV",
                table: "DONKHIEUNAI",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_GIAOVIEN_DIENDAN_DIENDAN_MaDD",
                table: "GIAOVIEN_DIENDAN",
                column: "MaDD",
                principalTable: "DIENDAN",
                principalColumn: "MaDD",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GIAOVIEN_DIENDAN_Giaovien_MaGV",
                table: "GIAOVIEN_DIENDAN",
                column: "MaGV",
                principalTable: "Giaovien",
                principalColumn: "MaGV",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETCH_Cauhoi_MaCH",
                table: "LICHSUDUYETCH",
                column: "MaCH",
                principalTable: "Cauhoi",
                principalColumn: "MaCH");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETCH_Kiemduyetvien_ID_NguoiDuyetLS",
                table: "LICHSUDUYETCH",
                column: "ID_NguoiDuyetLS",
                principalTable: "Kiemduyetvien",
                principalColumn: "MaKDV");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETCH_Trangthaich_MaTT_Sau",
                table: "LICHSUDUYETCH",
                column: "MaTT_Sau",
                principalTable: "Trangthaich",
                principalColumn: "MaTT_CH");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETCH_Trangthaich_MaTT_Truoc",
                table: "LICHSUDUYETCH",
                column: "MaTT_Truoc",
                principalTable: "Trangthaich",
                principalColumn: "MaTT_CH");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETTL_Kiemduyetvien_ID_NguoiDuyetLS_TL",
                table: "LICHSUDUYETTL",
                column: "ID_NguoiDuyetLS_TL",
                principalTable: "Kiemduyetvien",
                principalColumn: "MaKDV");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETTL_TRANGTHAITL_MaTT_Moi_TL",
                table: "LICHSUDUYETTL",
                column: "MaTT_Moi_TL",
                principalTable: "TRANGTHAITL",
                principalColumn: "MaTT_Tl");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETTL_TRANGTHAITL_MaTT_Truoc_TL",
                table: "LICHSUDUYETTL",
                column: "MaTT_Truoc_TL",
                principalTable: "TRANGTHAITL",
                principalColumn: "MaTT_Tl");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETTL_Tailieuhoctap_MaTL",
                table: "LICHSUDUYETTL",
                column: "MaTL",
                principalTable: "Tailieuhoctap",
                principalColumn: "MaTL");

            migrationBuilder.AddForeignKey(
                name: "FK_LOP_Giaovien_MaGV",
                table: "LOP",
                column: "MaGV",
                principalTable: "Giaovien",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK__NhomCH__ID_GiaoV__59FA5E80",
                table: "Nhomch",
                column: "ID_GiaoVienTao",
                principalTable: "Giaovien",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK__NhomCH__MaPT__59063A47",
                table: "Nhomch",
                column: "MaPT",
                principalTable: "Phanthi",
                principalColumn: "MaPT");

            migrationBuilder.AddForeignKey(
                name: "FK__PhanLoaiCH__MaCH__6E01572D",
                table: "Phanloaich",
                column: "MaCH",
                principalTable: "Cauhoi",
                principalColumn: "MaCH",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__PhanLoaiCH__MaKN__6FE99F9F",
                table: "Phanloaich",
                column: "MaKN",
                principalTable: "Kynang",
                principalColumn: "MaKN");

            migrationBuilder.AddForeignKey(
                name: "FK__PhanLoaiCH__MaPT__6EF57B66",
                table: "Phanloaich",
                column: "MaPT",
                principalTable: "Phanthi",
                principalColumn: "MaPT");

            migrationBuilder.AddForeignKey(
                name: "FK__PhanLoaiC__MaMDK__70DDC3D8",
                table: "Phanloaich",
                column: "MaMDK",
                principalTable: "MUCDOKHO",
                principalColumn: "MaMDK");

            migrationBuilder.AddForeignKey(
                name: "FK_PHANLOAITL_Kynang_MaKN",
                table: "PHANLOAITL",
                column: "MaKN",
                principalTable: "Kynang",
                principalColumn: "MaKN");

            migrationBuilder.AddForeignKey(
                name: "FK_PHANLOAITL_Phanthi_MaPL",
                table: "PHANLOAITL",
                column: "MaPL",
                principalTable: "Phanthi",
                principalColumn: "MaPT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__PhanThi__MaKN__44FF419A",
                table: "Phanthi",
                column: "MaKN",
                principalTable: "Kynang",
                principalColumn: "MaKN");

            migrationBuilder.AddForeignKey(
                name: "FK_PHIEUBAITAPONLUYEN_SINHVIEN_MaSV",
                table: "PHIEUBAITAPONLUYEN",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK__TaiLieuHo__ID_Ng__75A278F5",
                table: "Tailieuhoctap",
                column: "ID_NguoiTaiLen",
                principalTable: "Giaovien",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK__TaiLieuHo__ID_Ng__76969D2E",
                table: "Tailieuhoctap",
                column: "ID_NguoiDuyetTL",
                principalTable: "Kiemduyetvien",
                principalColumn: "MaKDV");

            migrationBuilder.AddForeignKey(
                name: "FK__TaiLieuHo__MaLoa__73BA3083",
                table: "Tailieuhoctap",
                column: "MaLoaiTL",
                principalTable: "LOAITAILIEU",
                principalColumn: "MaLoaiTL");

            migrationBuilder.AddForeignKey(
                name: "FK__TaiLieuHo__MaTT___74AE54BC",
                table: "Tailieuhoctap",
                column: "MaTT_TL",
                principalTable: "TRANGTHAITL",
                principalColumn: "MaTT_Tl");

            migrationBuilder.AddForeignKey(
                name: "FK_THAMGIA_DIENDAN_MaDD",
                table: "THAMGIA",
                column: "MaDD",
                principalTable: "DIENDAN",
                principalColumn: "MaDD",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_THAMGIA_SINHVIEN_MaSV",
                table: "THAMGIA",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_THONGKELOP_LOP_id_Lop",
                table: "THONGKELOP",
                column: "id_Lop",
                principalTable: "LOP",
                principalColumn: "id_Lop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BAIVIET_DIENDAN_MaDD",
                table: "BAIVIET");

            migrationBuilder.DropForeignKey(
                name: "FK_BAIVIET_Giaovien_MaNguoiTao",
                table: "BAIVIET");

            migrationBuilder.DropForeignKey(
                name: "FK_BIENBANTHITHU_DANGKYTHITHU_id_ThiThu",
                table: "BIENBANTHITHU");

            migrationBuilder.DropForeignKey(
                name: "FK__CauHoi__ID_GiaoV__5FB337D6",
                table: "Cauhoi");

            migrationBuilder.DropForeignKey(
                name: "FK__CauHoi__ID_Nguoi__60A75C0F",
                table: "Cauhoi");

            migrationBuilder.DropForeignKey(
                name: "FK__CauHoi__MaNhomCH__5DCAEF64",
                table: "Cauhoi");

            migrationBuilder.DropForeignKey(
                name: "FK__CauHoi__MaTT_CH__5EBF139D",
                table: "Cauhoi");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOIBAITAP_Cauhoi_MaCH",
                table: "CAUHOIBAITAP");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOIBAITAP_PHIEUBAITAPONLUYEN_id_PhieuBaiTap",
                table: "CAUHOIBAITAP");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOITRONG DETHI_Cauhoi_MaCH",
                table: "CAUHOITRONG DETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUHOITRONG DETHI_DETHIDATAO_MaDeThi",
                table: "CAUHOITRONG DETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUTRUCDETHI_MUCDOKHO_MaDoKhoPart",
                table: "CAUTRUCDETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_CAUTRUCDETHI_Phanthi_MaPT",
                table: "CAUTRUCDETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_CHITIETBAITHI_BAITHI_MaBT",
                table: "CHITIETBAITHI");

            migrationBuilder.DropForeignKey(
                name: "FK_CHITIETBAITHI_SINHVIEN_MaSV",
                table: "CHITIETBAITHI");

            migrationBuilder.DropForeignKey(
                name: "FK_D_DETHI_Cauhoi_MaCH",
                table: "D_DETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_D_DETHI_DETHI_id_DeThi",
                table: "D_DETHI");

            migrationBuilder.DropForeignKey(
                name: "FK_DANGKYONLUYEN_LOP_id_Lop",
                table: "DANGKYONLUYEN");

            migrationBuilder.DropForeignKey(
                name: "FK_DANGKYONLUYEN_SINHVIEN_MaSV",
                table: "DANGKYONLUYEN");

            migrationBuilder.DropForeignKey(
                name: "FK_DANGKYTHITHU_DETHI_id_DeThi",
                table: "DANGKYTHITHU");

            migrationBuilder.DropForeignKey(
                name: "FK_DANGKYTHITHU_LICHSUDUYETTL_MaLSD_TL",
                table: "DANGKYTHITHU");

            migrationBuilder.DropForeignKey(
                name: "FK_DANGKYTHITHU_SINHVIEN_MaSV",
                table: "DANGKYTHITHU");

            migrationBuilder.DropForeignKey(
                name: "FK__DapAn__MaCH__6477ECF3",
                table: "Dapan");

            migrationBuilder.DropForeignKey(
                name: "FK_DETHIDATAO_Giaovien_ID_GiaoVienTaoDe",
                table: "DETHIDATAO");

            migrationBuilder.DropForeignKey(
                name: "FK_DETHIDATAO_LOAIDETHI_MaLoaiDe",
                table: "DETHIDATAO");

            migrationBuilder.DropForeignKey(
                name: "FK_DETHIDATAO_SINHVIEN_ID_SinhVienTaoDe",
                table: "DETHIDATAO");

            migrationBuilder.DropForeignKey(
                name: "FK_DETHIDATAO_TRANGTHAIDETHI_MaTrangThaiDeThi",
                table: "DETHIDATAO");

            migrationBuilder.DropForeignKey(
                name: "FK_DIEMTHI_DANGKYTHITHU_id_ThiThu",
                table: "DIEMTHI");

            migrationBuilder.DropForeignKey(
                name: "FK_DIEMTHI_SINHVIEN_MaSV",
                table: "DIEMTHI");

            migrationBuilder.DropForeignKey(
                name: "FK_DIENDAN_DONDENGHITAODD_MaDDN",
                table: "DIENDAN");

            migrationBuilder.DropForeignKey(
                name: "FK_DONKHIEUNAI_BAITHI_MaBT",
                table: "DONKHIEUNAI");

            migrationBuilder.DropForeignKey(
                name: "FK_DONKHIEUNAI_SINHVIEN_MaSV",
                table: "DONKHIEUNAI");

            migrationBuilder.DropForeignKey(
                name: "FK_GIAOVIEN_DIENDAN_DIENDAN_MaDD",
                table: "GIAOVIEN_DIENDAN");

            migrationBuilder.DropForeignKey(
                name: "FK_GIAOVIEN_DIENDAN_Giaovien_MaGV",
                table: "GIAOVIEN_DIENDAN");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETCH_Cauhoi_MaCH",
                table: "LICHSUDUYETCH");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETCH_Kiemduyetvien_ID_NguoiDuyetLS",
                table: "LICHSUDUYETCH");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETCH_Trangthaich_MaTT_Sau",
                table: "LICHSUDUYETCH");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETCH_Trangthaich_MaTT_Truoc",
                table: "LICHSUDUYETCH");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETTL_Kiemduyetvien_ID_NguoiDuyetLS_TL",
                table: "LICHSUDUYETTL");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETTL_TRANGTHAITL_MaTT_Moi_TL",
                table: "LICHSUDUYETTL");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETTL_TRANGTHAITL_MaTT_Truoc_TL",
                table: "LICHSUDUYETTL");

            migrationBuilder.DropForeignKey(
                name: "FK_LICHSUDUYETTL_Tailieuhoctap_MaTL",
                table: "LICHSUDUYETTL");

            migrationBuilder.DropForeignKey(
                name: "FK_LOP_Giaovien_MaGV",
                table: "LOP");

            migrationBuilder.DropForeignKey(
                name: "FK__NhomCH__ID_GiaoV__59FA5E80",
                table: "Nhomch");

            migrationBuilder.DropForeignKey(
                name: "FK__NhomCH__MaPT__59063A47",
                table: "Nhomch");

            migrationBuilder.DropForeignKey(
                name: "FK__PhanLoaiCH__MaCH__6E01572D",
                table: "Phanloaich");

            migrationBuilder.DropForeignKey(
                name: "FK__PhanLoaiCH__MaKN__6FE99F9F",
                table: "Phanloaich");

            migrationBuilder.DropForeignKey(
                name: "FK__PhanLoaiCH__MaPT__6EF57B66",
                table: "Phanloaich");

            migrationBuilder.DropForeignKey(
                name: "FK__PhanLoaiC__MaMDK__70DDC3D8",
                table: "Phanloaich");

            migrationBuilder.DropForeignKey(
                name: "FK_PHANLOAITL_Kynang_MaKN",
                table: "PHANLOAITL");

            migrationBuilder.DropForeignKey(
                name: "FK_PHANLOAITL_Phanthi_MaPL",
                table: "PHANLOAITL");

            migrationBuilder.DropForeignKey(
                name: "FK__PhanThi__MaKN__44FF419A",
                table: "Phanthi");

            migrationBuilder.DropForeignKey(
                name: "FK_PHIEUBAITAPONLUYEN_SINHVIEN_MaSV",
                table: "PHIEUBAITAPONLUYEN");

            migrationBuilder.DropForeignKey(
                name: "FK__TaiLieuHo__ID_Ng__75A278F5",
                table: "Tailieuhoctap");

            migrationBuilder.DropForeignKey(
                name: "FK__TaiLieuHo__ID_Ng__76969D2E",
                table: "Tailieuhoctap");

            migrationBuilder.DropForeignKey(
                name: "FK__TaiLieuHo__MaLoa__73BA3083",
                table: "Tailieuhoctap");

            migrationBuilder.DropForeignKey(
                name: "FK__TaiLieuHo__MaTT___74AE54BC",
                table: "Tailieuhoctap");

            migrationBuilder.DropForeignKey(
                name: "FK_THAMGIA_DIENDAN_MaDD",
                table: "THAMGIA");

            migrationBuilder.DropForeignKey(
                name: "FK_THAMGIA_SINHVIEN_MaSV",
                table: "THAMGIA");

            migrationBuilder.DropForeignKey(
                name: "FK_THONGKELOP_LOP_id_Lop",
                table: "THONGKELOP");

            migrationBuilder.DropPrimaryKey(
                name: "PK__TrangTha__853A7EF0C0E067CB",
                table: "Trangthaich");

            migrationBuilder.DropPrimaryKey(
                name: "PK__TaiLieuH__2725007100A8DEC2",
                table: "Tailieuhoctap");

            migrationBuilder.DropPrimaryKey(
                name: "PK__PhanThi__2725E7F6D80C8DA8",
                table: "Phanthi");

            migrationBuilder.DropPrimaryKey(
                name: "PK__PhanLoai__5557D07F80AC11A1",
                table: "Phanloaich");

            migrationBuilder.DropPrimaryKey(
                name: "PK__NhomCH__5A1F247DC67BF8B8",
                table: "Nhomch");

            migrationBuilder.DropIndex(
                name: "UQ__NhomCH__672E42A04E462227",
                table: "Nhomch");

            migrationBuilder.DropPrimaryKey(
                name: "PK__KyNang__2725CF140DA899C6",
                table: "Kynang");

            migrationBuilder.DropPrimaryKey(
                name: "PK__KiemDuye__3BDEA374C697BD05",
                table: "Kiemduyetvien");

            migrationBuilder.DropIndex(
                name: "UQ__KiemDuye__B8DA919D3A066022",
                table: "Kiemduyetvien");

            migrationBuilder.DropIndex(
                name: "UQ__KiemDuye__D23D381579F74216",
                table: "Kiemduyetvien");

            migrationBuilder.DropPrimaryKey(
                name: "PK__GiaoVien__2725AEF36F8181E1",
                table: "Giaovien");

            migrationBuilder.DropIndex(
                name: "UQ__GiaoVien__6A6BEFC49AB6F408",
                table: "Giaovien");

            migrationBuilder.DropIndex(
                name: "UQ__GiaoVien__A9D1053497C9C9AF",
                table: "Giaovien");

            migrationBuilder.DropPrimaryKey(
                name: "PK__DapAn__2725867A10592A45",
                table: "Dapan");

            migrationBuilder.DropPrimaryKey(
                name: "PK__CauHoi__27258E00C4D3AB47",
                table: "Cauhoi");

            migrationBuilder.RenameTable(
                name: "Trangthaich",
                newName: "TRANGTHAICH");

            migrationBuilder.RenameTable(
                name: "Tailieuhoctap",
                newName: "TAILIEUHOCTAP");

            migrationBuilder.RenameTable(
                name: "Phanthi",
                newName: "PHANTHI");

            migrationBuilder.RenameTable(
                name: "Phanloaich",
                newName: "PHANLOAICH");

            migrationBuilder.RenameTable(
                name: "Nhomch",
                newName: "NHOMCH");

            migrationBuilder.RenameTable(
                name: "Kynang",
                newName: "KYNANG");

            migrationBuilder.RenameTable(
                name: "Kiemduyetvien",
                newName: "KIEMDUYETVIEN");

            migrationBuilder.RenameTable(
                name: "Giaovien",
                newName: "GIAOVIEN");

            migrationBuilder.RenameTable(
                name: "Dapan",
                newName: "DAPAN");

            migrationBuilder.RenameTable(
                name: "Cauhoi",
                newName: "CAUHOI");

            migrationBuilder.RenameIndex(
                name: "IX_Tailieuhoctap_MaTT_TL",
                table: "TAILIEUHOCTAP",
                newName: "IX_TAILIEUHOCTAP_MaTT_TL");

            migrationBuilder.RenameIndex(
                name: "IX_Tailieuhoctap_MaLoaiTL",
                table: "TAILIEUHOCTAP",
                newName: "IX_TAILIEUHOCTAP_MaLoaiTL");

            migrationBuilder.RenameIndex(
                name: "IX_Tailieuhoctap_ID_NguoiTaiLen",
                table: "TAILIEUHOCTAP",
                newName: "IX_TAILIEUHOCTAP_ID_NguoiTaiLen");

            migrationBuilder.RenameIndex(
                name: "IX_Tailieuhoctap_ID_NguoiDuyetTL",
                table: "TAILIEUHOCTAP",
                newName: "IX_TAILIEUHOCTAP_ID_NguoiDuyetTL");

            migrationBuilder.RenameIndex(
                name: "IX_Phanthi_MaKN",
                table: "PHANTHI",
                newName: "IX_PHANTHI_MaKN");

            migrationBuilder.RenameIndex(
                name: "IX_Phanloaich_MaPT",
                table: "PHANLOAICH",
                newName: "IX_PHANLOAICH_MaPT");

            migrationBuilder.RenameIndex(
                name: "IX_Phanloaich_MaMDK",
                table: "PHANLOAICH",
                newName: "IX_PHANLOAICH_MaMDK");

            migrationBuilder.RenameIndex(
                name: "IX_Phanloaich_MaKN",
                table: "PHANLOAICH",
                newName: "IX_PHANLOAICH_MaKN");

            migrationBuilder.RenameColumn(
                name: "KyHieu_NhomCH",
                table: "NHOMCH",
                newName: "KyHieu_NhomCh");

            migrationBuilder.RenameIndex(
                name: "IX_Nhomch_MaPT",
                table: "NHOMCH",
                newName: "IX_NHOMCH_MaPT");

            migrationBuilder.RenameIndex(
                name: "IX_Nhomch_ID_GiaoVienTao",
                table: "NHOMCH",
                newName: "IX_NHOMCH_ID_GiaoVienTao");

            migrationBuilder.RenameIndex(
                name: "IX_Dapan_MaCH",
                table: "DAPAN",
                newName: "IX_DAPAN_MaCH");

            migrationBuilder.RenameIndex(
                name: "IX_Cauhoi_MaTT_CH",
                table: "CAUHOI",
                newName: "IX_CAUHOI_MaTT_CH");

            migrationBuilder.RenameIndex(
                name: "IX_Cauhoi_MaNhomCH",
                table: "CAUHOI",
                newName: "IX_CAUHOI_MaNhomCH");

            migrationBuilder.RenameIndex(
                name: "IX_Cauhoi_ID_NguoiDuyetCH",
                table: "CAUHOI",
                newName: "IX_CAUHOI_ID_NguoiDuyetCH");

            migrationBuilder.RenameIndex(
                name: "IX_Cauhoi_ID_GiaoVienTaoCH",
                table: "CAUHOI",
                newName: "IX_CAUHOI_ID_GiaoVienTaoCH");

            migrationBuilder.AlterColumn<string>(
                name: "URL_NgoaiTL",
                table: "TAILIEUHOCTAP",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1000)",
                oldUnicode: false,
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path_FileTL",
                table: "TAILIEUHOCTAP",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldUnicode: false,
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTaiLenTL",
                table: "TAILIEUHOCTAP",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getutcdate())");

            migrationBuilder.AlterColumn<string>(
                name: "Path_AudioNhom",
                table: "NHOMCH",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldUnicode: false,
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "NgayTaoNhom",
                table: "NHOMCH",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true,
                oldDefaultValueSql: "(getutcdate())");

            migrationBuilder.AlterColumn<string>(
                name: "KyHieu_NhomCh",
                table: "NHOMCH",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenDangNhapKDV",
                table: "KIEMDUYETVIEN",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailKDV",
                table: "KIEMDUYETVIEN",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenDangNhapGV",
                table: "GIAOVIEN",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "GIAOVIEN",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bac",
                table: "DIEMTHI",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KyHieuDA",
                table: "DAPAN",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1)",
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path_HinhAnh",
                table: "CAUHOI",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldUnicode: false,
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path_AudioRieng",
                table: "CAUHOI",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldUnicode: false,
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "NgayTaoCH",
                table: "CAUHOI",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true,
                oldDefaultValueSql: "(getutcdate())");

            migrationBuilder.AlterColumn<int>(
                name: "MaBT",
                table: "BAITHI",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TRANGTHAICH",
                table: "TRANGTHAICH",
                column: "MaTT_CH");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAILIEUHOCTAP",
                table: "TAILIEUHOCTAP",
                column: "MaTL");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PHANTHI",
                table: "PHANTHI",
                column: "MaPT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PHANLOAICH",
                table: "PHANLOAICH",
                columns: new[] { "MaCH", "MaPT" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_NHOMCH",
                table: "NHOMCH",
                column: "MaNhomCH");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KYNANG",
                table: "KYNANG",
                column: "MaKN");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KIEMDUYETVIEN",
                table: "KIEMDUYETVIEN",
                column: "MaKDV");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GIAOVIEN",
                table: "GIAOVIEN",
                column: "MaGV");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DAPAN",
                table: "DAPAN",
                column: "MaDA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAUHOI",
                table: "CAUHOI",
                column: "MaCH");

            migrationBuilder.AddForeignKey(
                name: "FK_BAIVIET_DIENDAN",
                table: "BAIVIET",
                column: "MaDD",
                principalTable: "DIENDAN",
                principalColumn: "MaDD");

            migrationBuilder.AddForeignKey(
                name: "FK_BAIVIET_GIAOVIEN",
                table: "BAIVIET",
                column: "MaNguoiTao",
                principalTable: "GIAOVIEN",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK_BIENBANTHITHU_DANGKYTHITHU",
                table: "BIENBANTHITHU",
                column: "id_ThiThu",
                principalTable: "DANGKYTHITHU",
                principalColumn: "id_ThiThu");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOI_GIAOVIEN",
                table: "CAUHOI",
                column: "ID_GiaoVienTaoCH",
                principalTable: "GIAOVIEN",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOI_KIEMDUYETVIEN",
                table: "CAUHOI",
                column: "ID_NguoiDuyetCH",
                principalTable: "KIEMDUYETVIEN",
                principalColumn: "MaKDV");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOI_NHOMCH",
                table: "CAUHOI",
                column: "MaNhomCH",
                principalTable: "NHOMCH",
                principalColumn: "MaNhomCH");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOI_TRANGTHAICH",
                table: "CAUHOI",
                column: "MaTT_CH",
                principalTable: "TRANGTHAICH",
                principalColumn: "MaTT_CH");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOIBAITAP_CAUHOI",
                table: "CAUHOIBAITAP",
                column: "MaCH",
                principalTable: "CAUHOI",
                principalColumn: "MaCH");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOIBAITAP_PHIEUBAITAPONLUYEN",
                table: "CAUHOIBAITAP",
                column: "id_PhieuBaiTap",
                principalTable: "PHIEUBAITAPONLUYEN",
                principalColumn: "id_PhieuBaiTap");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOITRONG DETHI_CAUHOI",
                table: "CAUHOITRONG DETHI",
                column: "MaCH",
                principalTable: "CAUHOI",
                principalColumn: "MaCH");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUHOITRONG DETHI_DETHIDATAO",
                table: "CAUHOITRONG DETHI",
                column: "MaDeThi",
                principalTable: "DETHIDATAO",
                principalColumn: "MaDeThi");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUTRUCDETHI_MUCDOKHO",
                table: "CAUTRUCDETHI",
                column: "MaDoKhoPart",
                principalTable: "MUCDOKHO",
                principalColumn: "MaMDK");

            migrationBuilder.AddForeignKey(
                name: "FK_CAUTRUCDETHI_PHANTHI",
                table: "CAUTRUCDETHI",
                column: "MaPT",
                principalTable: "PHANTHI",
                principalColumn: "MaPT");

            migrationBuilder.AddForeignKey(
                name: "FK_CHITIETBAITHI_BAITHI",
                table: "CHITIETBAITHI",
                column: "MaBT",
                principalTable: "BAITHI",
                principalColumn: "MaBT");

            migrationBuilder.AddForeignKey(
                name: "FK_CHITIETBAITHI_SINHVIEN",
                table: "CHITIETBAITHI",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_D_DETHI_CAUHOI",
                table: "D_DETHI",
                column: "MaCH",
                principalTable: "CAUHOI",
                principalColumn: "MaCH");

            migrationBuilder.AddForeignKey(
                name: "FK_D_DETHI_DETHI",
                table: "D_DETHI",
                column: "id_DeThi",
                principalTable: "DETHI",
                principalColumn: "id_DeThi");

            migrationBuilder.AddForeignKey(
                name: "FK_DANGKYONLUYEN_LOP",
                table: "DANGKYONLUYEN",
                column: "id_Lop",
                principalTable: "LOP",
                principalColumn: "id_Lop");

            migrationBuilder.AddForeignKey(
                name: "FK_DANGKYONLUYEN_SINHVIEN",
                table: "DANGKYONLUYEN",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_DANGKYTHITHU_DETHI",
                table: "DANGKYTHITHU",
                column: "id_DeThi",
                principalTable: "DETHI",
                principalColumn: "id_DeThi");

            migrationBuilder.AddForeignKey(
                name: "FK_DANGKYTHITHU_LICHSUDUYETTL",
                table: "DANGKYTHITHU",
                column: "MaLSD_TL",
                principalTable: "LICHSUDUYETTL",
                principalColumn: "MaLSD_TL");

            migrationBuilder.AddForeignKey(
                name: "FK_DANGKYTHITHU_SINHVIEN",
                table: "DANGKYTHITHU",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_DAPAN_CAUHOI",
                table: "DAPAN",
                column: "MaCH",
                principalTable: "CAUHOI",
                principalColumn: "MaCH",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DETHIDATAO_GIAOVIEN",
                table: "DETHIDATAO",
                column: "ID_GiaoVienTaoDe",
                principalTable: "GIAOVIEN",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK_DETHIDATAO_LOAIDETHI",
                table: "DETHIDATAO",
                column: "MaLoaiDe",
                principalTable: "LOAIDETHI",
                principalColumn: "MaLoaiDe");

            migrationBuilder.AddForeignKey(
                name: "FK_DETHIDATAO_SINHVIEN",
                table: "DETHIDATAO",
                column: "ID_SinhVienTaoDe",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_DETHIDATAO_TRANGTHAIDETHI",
                table: "DETHIDATAO",
                column: "MaTrangThaiDeThi",
                principalTable: "TRANGTHAIDETHI",
                principalColumn: "MaTrangThaiDe");

            migrationBuilder.AddForeignKey(
                name: "FK_DIEMTHI_DANGKYTHITHU",
                table: "DIEMTHI",
                column: "id_ThiThu",
                principalTable: "DANGKYTHITHU",
                principalColumn: "id_ThiThu");

            migrationBuilder.AddForeignKey(
                name: "FK_DIEMTHI_SINHVIEN",
                table: "DIEMTHI",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_DIENDAN_DONDENGHITAODD",
                table: "DIENDAN",
                column: "MaDDN",
                principalTable: "DONDENGHITAODD",
                principalColumn: "MaDDN");

            migrationBuilder.AddForeignKey(
                name: "FK_DONKHIEUNAI_BAITHI",
                table: "DONKHIEUNAI",
                column: "MaBT",
                principalTable: "BAITHI",
                principalColumn: "MaBT");

            migrationBuilder.AddForeignKey(
                name: "FK_DONKHIEUNAI_SINHVIEN",
                table: "DONKHIEUNAI",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_GIAOVIEN_DIENDAN_DIENDAN",
                table: "GIAOVIEN_DIENDAN",
                column: "MaDD",
                principalTable: "DIENDAN",
                principalColumn: "MaDD");

            migrationBuilder.AddForeignKey(
                name: "FK_GIAOVIEN_DIENDAN_GIAOVIEN",
                table: "GIAOVIEN_DIENDAN",
                column: "MaGV",
                principalTable: "GIAOVIEN",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETCH_CAUHOI",
                table: "LICHSUDUYETCH",
                column: "MaCH",
                principalTable: "CAUHOI",
                principalColumn: "MaCH");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETCH_KIEMDUYETVIEN",
                table: "LICHSUDUYETCH",
                column: "ID_NguoiDuyetLS",
                principalTable: "KIEMDUYETVIEN",
                principalColumn: "MaKDV");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETCH_TRANGTHAICH",
                table: "LICHSUDUYETCH",
                column: "MaTT_Truoc",
                principalTable: "TRANGTHAICH",
                principalColumn: "MaTT_CH");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETCH_TRANGTHAICH1",
                table: "LICHSUDUYETCH",
                column: "MaTT_Sau",
                principalTable: "TRANGTHAICH",
                principalColumn: "MaTT_CH");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETTL_KIEMDUYETVIEN",
                table: "LICHSUDUYETTL",
                column: "ID_NguoiDuyetLS_TL",
                principalTable: "KIEMDUYETVIEN",
                principalColumn: "MaKDV");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETTL_TAILIEUHOCTAP",
                table: "LICHSUDUYETTL",
                column: "MaTL",
                principalTable: "TAILIEUHOCTAP",
                principalColumn: "MaTL");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETTL_TRANGTHAITL",
                table: "LICHSUDUYETTL",
                column: "MaTT_Truoc_TL",
                principalTable: "TRANGTHAITL",
                principalColumn: "MaTT_Tl");

            migrationBuilder.AddForeignKey(
                name: "FK_LICHSUDUYETTL_TRANGTHAITL1",
                table: "LICHSUDUYETTL",
                column: "MaTT_Moi_TL",
                principalTable: "TRANGTHAITL",
                principalColumn: "MaTT_Tl");

            migrationBuilder.AddForeignKey(
                name: "FK_LOP_GIAOVIEN",
                table: "LOP",
                column: "MaGV",
                principalTable: "GIAOVIEN",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK_NHOMCH_GIAOVIEN",
                table: "NHOMCH",
                column: "ID_GiaoVienTao",
                principalTable: "GIAOVIEN",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK_NHOMCH_PHANTHI",
                table: "NHOMCH",
                column: "MaPT",
                principalTable: "PHANTHI",
                principalColumn: "MaPT");

            migrationBuilder.AddForeignKey(
                name: "FK_PHANLOAICH_CAUHOI",
                table: "PHANLOAICH",
                column: "MaCH",
                principalTable: "CAUHOI",
                principalColumn: "MaCH");

            migrationBuilder.AddForeignKey(
                name: "FK_PHANLOAICH_KYNANG",
                table: "PHANLOAICH",
                column: "MaKN",
                principalTable: "KYNANG",
                principalColumn: "MaKN");

            migrationBuilder.AddForeignKey(
                name: "FK_PHANLOAICH_MUCDOKHO",
                table: "PHANLOAICH",
                column: "MaMDK",
                principalTable: "MUCDOKHO",
                principalColumn: "MaMDK");

            migrationBuilder.AddForeignKey(
                name: "FK_PHANLOAICH_PHANTHI",
                table: "PHANLOAICH",
                column: "MaPT",
                principalTable: "PHANTHI",
                principalColumn: "MaPT");

            migrationBuilder.AddForeignKey(
                name: "FK_PHANLOAITL_KYNANG",
                table: "PHANLOAITL",
                column: "MaKN",
                principalTable: "KYNANG",
                principalColumn: "MaKN");

            migrationBuilder.AddForeignKey(
                name: "FK_PHANLOAITL_PHANTHI",
                table: "PHANLOAITL",
                column: "MaPL",
                principalTable: "PHANTHI",
                principalColumn: "MaPT");

            migrationBuilder.AddForeignKey(
                name: "FK_PHANTHI_KYNANG",
                table: "PHANTHI",
                column: "MaKN",
                principalTable: "KYNANG",
                principalColumn: "MaKN");

            migrationBuilder.AddForeignKey(
                name: "FK_PHIEUBAITAPONLUYEN_SINHVIEN",
                table: "PHIEUBAITAPONLUYEN",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_TAILIEUHOCTAP_GIAOVIEN",
                table: "TAILIEUHOCTAP",
                column: "ID_NguoiTaiLen",
                principalTable: "GIAOVIEN",
                principalColumn: "MaGV");

            migrationBuilder.AddForeignKey(
                name: "FK_TAILIEUHOCTAP_KIEMDUYETVIEN",
                table: "TAILIEUHOCTAP",
                column: "ID_NguoiDuyetTL",
                principalTable: "KIEMDUYETVIEN",
                principalColumn: "MaKDV");

            migrationBuilder.AddForeignKey(
                name: "FK_TAILIEUHOCTAP_LOAITAILIEU",
                table: "TAILIEUHOCTAP",
                column: "MaLoaiTL",
                principalTable: "LOAITAILIEU",
                principalColumn: "MaLoaiTL");

            migrationBuilder.AddForeignKey(
                name: "FK_TAILIEUHOCTAP_TRANGTHAITL",
                table: "TAILIEUHOCTAP",
                column: "MaTT_TL",
                principalTable: "TRANGTHAITL",
                principalColumn: "MaTT_Tl");

            migrationBuilder.AddForeignKey(
                name: "FK_THAMGIA_DIENDAN",
                table: "THAMGIA",
                column: "MaDD",
                principalTable: "DIENDAN",
                principalColumn: "MaDD");

            migrationBuilder.AddForeignKey(
                name: "FK_THAMGIA_SINHVIEN",
                table: "THAMGIA",
                column: "MaSV",
                principalTable: "SINHVIEN",
                principalColumn: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_THONGKELOP_LOP",
                table: "THONGKELOP",
                column: "id_Lop",
                principalTable: "LOP",
                principalColumn: "id_Lop");
        }
    }
}
