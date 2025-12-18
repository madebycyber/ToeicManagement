using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ToeicCentre_Management.Models;

namespace ToeicCentre_Management.Data;

public partial class TOIECContext : DbContext
{
    public TOIECContext()
    {
    }

    public TOIECContext(DbContextOptions<TOIECContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Baithi> Baithis { get; set; }
    public virtual DbSet<Baiviet> Baiviets { get; set; }
    public virtual DbSet<Bienbanthithu> Bienbanthithus { get; set; }
    public virtual DbSet<Cauhoi> Cauhois { get; set; }
    public virtual DbSet<Cauhoibaitap> Cauhoibaitaps { get; set; }
    public virtual DbSet<CauhoitrongDethi> CauhoitrongDethis { get; set; }
    public virtual DbSet<Cautrucdethi> Cautrucdethis { get; set; }
    public virtual DbSet<Chitietbaithi> Chitietbaithis { get; set; }
    public virtual DbSet<Chudetl> Chudetls { get; set; }
    public virtual DbSet<DDethi> DDethis { get; set; }
    public virtual DbSet<Dangkyonluyen> Dangkyonluyens { get; set; }
    public virtual DbSet<Dangkythithu> Dangkythithus { get; set; }
    public virtual DbSet<Dapan> Dapans { get; set; }
    public virtual DbSet<Dethi> Dethis { get; set; }
    public virtual DbSet<Dethidatao> Dethidataos { get; set; }
    public virtual DbSet<Diemthi> Diemthis { get; set; }
    public virtual DbSet<Diendan> Diendans { get; set; }
    public virtual DbSet<Dondenghitaodd> Dondenghitaodds { get; set; }
    public virtual DbSet<Donkhieunai> Donkhieunais { get; set; }
    public virtual DbSet<Giaovien> Giaoviens { get; set; }
    public virtual DbSet<GiaovienDiendan> GiaovienDiendans { get; set; }
    public virtual DbSet<Kiemduyetvien> Kiemduyetviens { get; set; }
    public virtual DbSet<Kynang> Kynangs { get; set; }
    public virtual DbSet<Lichhoc> Lichhocs { get; set; }
    public virtual DbSet<Lichsuduyetch> Lichsuduyetches { get; set; }
    public virtual DbSet<Lichsuduyettl> Lichsuduyettls { get; set; }
    public virtual DbSet<Lichthitoiec> Lichthitoiecs { get; set; }
    public virtual DbSet<Loaidethi> Loaidethis { get; set; }
    public virtual DbSet<Loaitailieu> Loaitailieus { get; set; }
    public virtual DbSet<Lop> Lops { get; set; }
    public virtual DbSet<Mucdokho> Mucdokhos { get; set; }
    public virtual DbSet<Nhomch> Nhomches { get; set; }
    public virtual DbSet<Phanloaich> Phanloaiches { get; set; }
    public virtual DbSet<Phanloaitl> Phanloaitls { get; set; }
    public virtual DbSet<Phanthi> Phanthis { get; set; }
    public virtual DbSet<Phieubaitaponluyen> Phieubaitaponluyens { get; set; }
    public virtual DbSet<Phieudangkytoiec> Phieudangkytoiecs { get; set; }
    public virtual DbSet<Sinhvien> Sinhviens { get; set; }
    public virtual DbSet<Tailieuhoctap> Tailieuhoctaps { get; set; }
    public virtual DbSet<Thamgium> Thamgia { get; set; }
    public virtual DbSet<Thongkelop> Thongkelops { get; set; }
    public virtual DbSet<Trangthaich> Trangthaiches { get; set; }
    public virtual DbSet<Trangthaidethi> Trangthaidethis { get; set; }
    public virtual DbSet<Trangthaitl> Trangthaitls { get; set; }
    public virtual DbSet<TtLichthitoiec> TtLichthitoiecs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-BHAD8K5V;Database=Toeic_CentrerDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Cấu hình từ ToeicOnlineDbContext cho các bảng chung
        modelBuilder.Entity<Cauhoi>(entity =>
        {
            entity.HasKey(e => e.MaCh).HasName("PK__CauHoi__27258E00C4D3AB47");
            entity.ToTable("Cauhoi");
            entity.Property(e => e.MaCh).HasColumnName("MaCH");
            entity.Property(e => e.GiaiThichDa).HasColumnName("GiaiThichDA");
            entity.Property(e => e.IdGiaoVienTaoCh).HasColumnName("ID_GiaoVienTaoCH");
            entity.Property(e => e.IdNguoiDuyetCh).HasColumnName("ID_NguoiDuyetCH");
            entity.Property(e => e.MaNhomCh).HasColumnName("MaNhomCH");
            entity.Property(e => e.MaTtCh).HasColumnName("MaTT_CH");
            entity.Property(e => e.NdCauHoi).HasColumnName("ND_CauHoi");
            entity.Property(e => e.NgayCapNhatCh).HasColumnName("NgayCapNhatCH");
            entity.Property(e => e.NgayDuyetCh).HasColumnName("NgayDuyetCH");
            entity.Property(e => e.NgayTaoCh)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnName("NgayTaoCH");
            entity.Property(e => e.PathAudioRieng)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Path_AudioRieng");
            entity.Property(e => e.PathHinhAnh)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Path_HinhAnh");
            entity.Property(e => e.SttTrongNhom).HasColumnName("STT_TrongNhom");

            entity.HasOne(d => d.IdGiaoVienTaoChNavigation).WithMany(p => p.Cauhois)
                .HasForeignKey(d => d.IdGiaoVienTaoCh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CauHoi__ID_GiaoV__5FB337D6");

            entity.HasOne(d => d.IdNguoiDuyetChNavigation).WithMany(p => p.Cauhois)
                .HasForeignKey(d => d.IdNguoiDuyetCh)
                .HasConstraintName("FK__CauHoi__ID_Nguoi__60A75C0F");

            entity.HasOne(d => d.MaNhomChNavigation).WithMany(p => p.Cauhois)
                .HasForeignKey(d => d.MaNhomCh)
                .HasConstraintName("FK__CauHoi__MaNhomCH__5DCAEF64");

            entity.HasOne(d => d.MaTtChNavigation).WithMany(p => p.Cauhois)
                .HasForeignKey(d => d.MaTtCh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CauHoi__MaTT_CH__5EBF139D");
        });

        modelBuilder.Entity<Dapan>(entity =>
        {
            entity.HasKey(e => e.MaDa).HasName("PK__DapAn__2725867A10592A45");
            entity.ToTable("Dapan");
            entity.Property(e => e.MaDa).HasColumnName("MaDA");
            entity.Property(e => e.KyHieuDa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("KyHieuDA");
            entity.Property(e => e.MaCh).HasColumnName("MaCH");
            entity.Property(e => e.NdDapAn).HasColumnName("ND_DapAn");

            entity.HasOne(d => d.MaChNavigation).WithMany(p => p.Dapans)
                .HasForeignKey(d => d.MaCh)
                .HasConstraintName("FK__DapAn__MaCH__6477ECF3");
        });

        modelBuilder.Entity<Giaovien>(entity =>
        {
            entity.HasKey(e => e.MaGv).HasName("PK__GiaoVien__2725AEF36F8181E1");
            entity.ToTable("Giaovien");
            entity.HasIndex(e => e.TenDangNhapGv, "UQ__GiaoVien__6A6BEFC49AB6F408").IsUnique();
            entity.HasIndex(e => e.Email, "UQ__GiaoVien__A9D1053497C9C9AF").IsUnique();
            entity.Property(e => e.MaGv).HasColumnName("MaGV");
            entity.Property(e => e.CapBac).HasMaxLength(100);
            entity.Property(e => e.ChucVu).HasMaxLength(100);
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MatKhauGv)
                .HasMaxLength(255)
                .HasColumnName("MatKhauGV");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenDangNhapGv)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TenDangNhapGV");
            entity.Property(e => e.TenGiaoVien).HasMaxLength(255);
        });

        modelBuilder.Entity<Kiemduyetvien>(entity =>
        {
            entity.HasKey(e => e.MaKdv).HasName("PK__KiemDuye__3BDEA374C697BD05");
            entity.ToTable("Kiemduyetvien");
            entity.HasIndex(e => e.EmailKdv, "UQ__KiemDuye__B8DA919D3A066022").IsUnique();
            entity.HasIndex(e => e.TenDangNhapKdv, "UQ__KiemDuye__D23D381579F74216").IsUnique();
            entity.Property(e => e.MaKdv).HasColumnName("MaKDV");
            entity.Property(e => e.EmailKdv)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EmailKDV");
            entity.Property(e => e.HoTenKdv)
                .HasMaxLength(255)
                .HasColumnName("HoTenKDV");
            entity.Property(e => e.MatKhauKdv)
                .HasMaxLength(255)
                .HasColumnName("MatKhauKDV");
            entity.Property(e => e.TenDangNhapKdv)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TenDangNhapKDV");
        });

        modelBuilder.Entity<Kynang>(entity =>
        {
            entity.HasKey(e => e.MaKn).HasName("PK__KyNang__2725CF140DA899C6");
            entity.ToTable("Kynang");
            entity.Property(e => e.MaKn).HasColumnName("MaKN");
            entity.Property(e => e.TenKn)
                .HasMaxLength(100)
                .HasColumnName("TenKN");
        });

        modelBuilder.Entity<Nhomch>(entity =>
        {
            entity.HasKey(e => e.MaNhomCh).HasName("PK__NhomCH__5A1F247DC67BF8B8");
            entity.ToTable("Nhomch");
            entity.HasIndex(e => e.KyHieuNhomCh, "UQ__NhomCH__672E42A04E462227").IsUnique();
            entity.Property(e => e.MaNhomCh).HasColumnName("MaNhomCH");
            entity.Property(e => e.IdGiaoVienTao).HasColumnName("ID_GiaoVienTao");
            entity.Property(e => e.KyHieuNhomCh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KyHieu_NhomCH");
            entity.Property(e => e.MaPt).HasColumnName("MaPT");
            entity.Property(e => e.NdDoanVan).HasColumnName("ND_DoanVan");
            entity.Property(e => e.NdHoiThoai).HasColumnName("ND_HoiThoai");
            entity.Property(e => e.NgayTaoNhom).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.PathAudioNhom)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Path_AudioNhom");

            entity.HasOne(d => d.IdGiaoVienTaoNavigation).WithMany(p => p.Nhomches)
                .HasForeignKey(d => d.IdGiaoVienTao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NhomCH__ID_GiaoV__59FA5E80");

            entity.HasOne(d => d.MaPtNavigation).WithMany(p => p.Nhomches)
                .HasForeignKey(d => d.MaPt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NhomCH__MaPT__59063A47");
        });

        modelBuilder.Entity<Phanloaich>(entity =>
        {
            entity.HasKey(e => new { e.MaCh, e.MaPt }).HasName("PK__PhanLoai__5557D07F80AC11A1");
            entity.ToTable("Phanloaich");
            entity.Property(e => e.MaCh).HasColumnName("MaCH");
            entity.Property(e => e.MaPt).HasColumnName("MaPT");
            entity.Property(e => e.MaKn).HasColumnName("MaKN");
            entity.Property(e => e.MaMdk).HasColumnName("MaMDK");

            entity.HasOne(d => d.MaChNavigation).WithMany(p => p.Phanloaiches)
                .HasForeignKey(d => d.MaCh)
                .HasConstraintName("FK__PhanLoaiCH__MaCH__6E01572D");

            entity.HasOne(d => d.MaKnNavigation).WithMany(p => p.Phanloaiches)
                .HasForeignKey(d => d.MaKn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhanLoaiCH__MaKN__6FE99F9F");

            entity.HasOne(d => d.MaMdkNavigation).WithMany(p => p.Phanloaiches)
                .HasForeignKey(d => d.MaMdk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhanLoaiC__MaMDK__70DDC3D8");

            entity.HasOne(d => d.MaPtNavigation).WithMany(p => p.Phanloaiches)
                .HasForeignKey(d => d.MaPt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhanLoaiCH__MaPT__6EF57B66");
        });

        modelBuilder.Entity<Phanthi>(entity =>
        {
            entity.HasKey(e => e.MaPt).HasName("PK__PhanThi__2725E7F6D80C8DA8");
            entity.ToTable("Phanthi");
            entity.Property(e => e.MaPt).HasColumnName("MaPT");
            entity.Property(e => e.MaKn).HasColumnName("MaKN");
            entity.Property(e => e.TenPt)
                .HasMaxLength(100)
                .HasColumnName("TenPT");

            entity.HasOne(d => d.MaKnNavigation).WithMany(p => p.Phanthis)
                .HasForeignKey(d => d.MaKn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhanThi__MaKN__44FF419A");
        });

        modelBuilder.Entity<Tailieuhoctap>(entity =>
        {
            entity.HasKey(e => e.MaTl).HasName("PK__TaiLieuH__2725007100A8DEC2");
            entity.ToTable("Tailieuhoctap");
            entity.Property(e => e.MaTl).HasColumnName("MaTL");
            entity.Property(e => e.IdNguoiDuyetTl).HasColumnName("ID_NguoiDuyetTL");
            entity.Property(e => e.IdNguoiTaiLen).HasColumnName("ID_NguoiTaiLen");
            entity.Property(e => e.MaLoaiTl).HasColumnName("MaLoaiTL");
            entity.Property(e => e.MaTtTl).HasColumnName("MaTT_TL");
            entity.Property(e => e.MoTaNganTl).HasColumnName("MoTaNganTL");
            entity.Property(e => e.NgayCapNhatTlCuoi).HasColumnName("NgayCapNhatTL_Cuoi");
            entity.Property(e => e.NgayDuyetTl).HasColumnName("NgayDuyetTL");
            entity.Property(e => e.NgayTaiLenTl)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnName("NgayTaiLenTL");
            entity.Property(e => e.PathFileTl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Path_FileTL");
            entity.Property(e => e.TieuDeTl)
                .HasMaxLength(500)
                .HasColumnName("TieuDeTL");
            entity.Property(e => e.UrlNgoaiTl)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("URL_NgoaiTL");

            entity.HasOne(d => d.IdNguoiDuyetTlNavigation).WithMany(p => p.Tailieuhoctaps)
                .HasForeignKey(d => d.IdNguoiDuyetTl)
                .HasConstraintName("FK__TaiLieuHo__ID_Ng__76969D2E");

            entity.HasOne(d => d.IdNguoiTaiLenNavigation).WithMany(p => p.Tailieuhoctaps)
                .HasForeignKey(d => d.IdNguoiTaiLen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaiLieuHo__ID_Ng__75A278F5");

            entity.HasOne(d => d.MaLoaiTlNavigation).WithMany(p => p.Tailieuhoctaps)
                .HasForeignKey(d => d.MaLoaiTl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaiLieuHo__MaLoa__73BA3083");

            entity.HasOne(d => d.MaTtTlNavigation).WithMany(p => p.Tailieuhoctaps)
                .HasForeignKey(d => d.MaTtTl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaiLieuHo__MaTT___74AE54BC");

            entity.HasMany(d => d.MaChuDeTls).WithMany(p => p.MaTls)
                .UsingEntity<Dictionary<string, object>>(
                    "TailieuChude",
                    r => r.HasOne<Chudetl>().WithMany()
                        .HasForeignKey("MaChuDeTl")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TAILIEU_CHUDE_CHUDETL"),
                    l => l.HasOne<Tailieuhoctap>().WithMany()
                        .HasForeignKey("MaTl")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TAILIEU_CHUDE_TAILIEUHOCTAP"),
                    j =>
                    {
                        j.HasKey("MaTl", "MaChuDeTl");
                        j.ToTable("TAILIEU_CHUDE");
                        j.IndexerProperty<int>("MaTl").HasColumnName("MaTL");
                        j.IndexerProperty<int>("MaChuDeTl").HasColumnName("MaChuDeTL");
                    });
        });

        modelBuilder.Entity<Trangthaich>(entity =>
        {
            entity.HasKey(e => e.MaTtCh).HasName("PK__TrangTha__853A7EF0C0E067CB");
            entity.ToTable("Trangthaich");
            entity.Property(e => e.MaTtCh).HasColumnName("MaTT_CH");
            entity.Property(e => e.TenTtCh)
                .HasMaxLength(100)
                .HasColumnName("TenTT_CH");
        });

        // Giữ cấu hình hiện tại cho các bảng khác
        modelBuilder.Entity<Baithi>(entity =>
        {
            entity.Property(e => e.MaBt).ValueGeneratedNever();
            entity.Property(e => e.TglamBai).IsFixedLength();
            entity.Property(e => e.TongDiem).IsFixedLength();
        });

        // Thêm các cấu hình khác tương tự cho các bảng còn lại...

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}