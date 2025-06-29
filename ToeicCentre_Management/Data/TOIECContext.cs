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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LuckyBoiz\\SQLEXPRESS;Database=TOIEC;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Baithi>(entity =>
        {
            entity.Property(e => e.MaBt).ValueGeneratedNever();
            entity.Property(e => e.TglamBai).IsFixedLength();
            entity.Property(e => e.TongDiem).IsFixedLength();
        });

        modelBuilder.Entity<Baiviet>(entity =>
        {
            entity.Property(e => e.MaBv).ValueGeneratedNever();

            entity.HasOne(d => d.MaDdNavigation).WithMany(p => p.Baiviets).HasConstraintName("FK_BAIVIET_DIENDAN");

            entity.HasOne(d => d.MaNguoiTaoNavigation).WithMany(p => p.Baiviets).HasConstraintName("FK_BAIVIET_GIAOVIEN");
        });

        modelBuilder.Entity<Bienbanthithu>(entity =>
        {
            entity.Property(e => e.IdBienBanThiThu).ValueGeneratedNever();

            entity.HasOne(d => d.IdThiThuNavigation).WithMany(p => p.Bienbanthithus).HasConstraintName("FK_BIENBANTHITHU_DANGKYTHITHU");
        });

        modelBuilder.Entity<Cauhoi>(entity =>
        {
            entity.Property(e => e.MaCh).ValueGeneratedNever();

            entity.HasOne(d => d.IdGiaoVienTaoChNavigation).WithMany(p => p.Cauhois).HasConstraintName("FK_CAUHOI_GIAOVIEN");

            entity.HasOne(d => d.IdNguoiDuyetChNavigation).WithMany(p => p.Cauhois).HasConstraintName("FK_CAUHOI_KIEMDUYETVIEN");

            entity.HasOne(d => d.MaNhomChNavigation).WithMany(p => p.Cauhois).HasConstraintName("FK_CAUHOI_NHOMCH");

            entity.HasOne(d => d.MaTtChNavigation).WithMany(p => p.Cauhois).HasConstraintName("FK_CAUHOI_TRANGTHAICH");
        });

        modelBuilder.Entity<Cauhoibaitap>(entity =>
        {
            entity.Property(e => e.IdBaiTap).ValueGeneratedNever();

            entity.HasOne(d => d.IdPhieuBaiTapNavigation).WithMany(p => p.Cauhoibaitaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAUHOIBAITAP_PHIEUBAITAPONLUYEN");

            entity.HasOne(d => d.MaChNavigation).WithMany(p => p.Cauhoibaitaps).HasConstraintName("FK_CAUHOIBAITAP_CAUHOI");
        });

        modelBuilder.Entity<CauhoitrongDethi>(entity =>
        {
            entity.HasOne(d => d.MaChNavigation).WithMany(p => p.CauhoitrongDethis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAUHOITRONG DETHI_CAUHOI");

            entity.HasOne(d => d.MaDeThiNavigation).WithMany(p => p.CauhoitrongDethis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAUHOITRONG DETHI_DETHIDATAO");
        });

        modelBuilder.Entity<Cautrucdethi>(entity =>
        {
            entity.HasOne(d => d.MaDoKhoPartNavigation).WithMany(p => p.Cautrucdethis).HasConstraintName("FK_CAUTRUCDETHI_MUCDOKHO");

            entity.HasOne(d => d.MaPtNavigation).WithMany(p => p.Cautrucdethis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAUTRUCDETHI_PHANTHI");
        });

        modelBuilder.Entity<Chitietbaithi>(entity =>
        {
            entity.HasOne(d => d.MaBtNavigation).WithMany(p => p.Chitietbaithis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHITIETBAITHI_BAITHI");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.Chitietbaithis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHITIETBAITHI_SINHVIEN");
        });

        modelBuilder.Entity<Chudetl>(entity =>
        {
            entity.Property(e => e.MaChuDeTl).ValueGeneratedNever();
        });

        modelBuilder.Entity<DDethi>(entity =>
        {
            entity.Property(e => e.IdDdeThi).ValueGeneratedNever();

            entity.HasOne(d => d.IdDeThiNavigation).WithMany(p => p.DDethis).HasConstraintName("FK_D_DETHI_DETHI");

            entity.HasOne(d => d.MaChNavigation).WithMany(p => p.DDethis).HasConstraintName("FK_D_DETHI_CAUHOI");
        });

        modelBuilder.Entity<Dangkyonluyen>(entity =>
        {
            entity.Property(e => e.IdOnLuyen).ValueGeneratedNever();

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.Dangkyonluyens).HasConstraintName("FK_DANGKYONLUYEN_LOP");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.Dangkyonluyens).HasConstraintName("FK_DANGKYONLUYEN_SINHVIEN");
        });

        modelBuilder.Entity<Dangkythithu>(entity =>
        {
            entity.Property(e => e.IdThiThu).ValueGeneratedNever();

            entity.HasOne(d => d.IdDeThiNavigation).WithMany(p => p.Dangkythithus).HasConstraintName("FK_DANGKYTHITHU_DETHI");

            entity.HasOne(d => d.MaLsdTlNavigation).WithMany(p => p.Dangkythithus).HasConstraintName("FK_DANGKYTHITHU_LICHSUDUYETTL");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.Dangkythithus).HasConstraintName("FK_DANGKYTHITHU_SINHVIEN");
        });

        modelBuilder.Entity<Dapan>(entity =>
        {
            entity.Property(e => e.MaDa).ValueGeneratedNever();
            entity.Property(e => e.KyHieuDa).IsFixedLength();

            entity.HasOne(d => d.MaChNavigation).WithMany(p => p.Dapans).HasConstraintName("FK_DAPAN_CAUHOI");
        });

        modelBuilder.Entity<Dethi>(entity =>
        {
            entity.Property(e => e.IdDeThi).ValueGeneratedNever();
        });

        modelBuilder.Entity<Dethidatao>(entity =>
        {
            entity.Property(e => e.MaDeThi).ValueGeneratedNever();

            entity.HasOne(d => d.IdGiaoVienTaoDeNavigation).WithMany(p => p.Dethidataos).HasConstraintName("FK_DETHIDATAO_GIAOVIEN");

            entity.HasOne(d => d.IdSinhVienTaoDeNavigation).WithMany(p => p.Dethidataos).HasConstraintName("FK_DETHIDATAO_SINHVIEN");

            entity.HasOne(d => d.MaLoaiDeNavigation).WithMany(p => p.Dethidataos).HasConstraintName("FK_DETHIDATAO_LOAIDETHI");

            entity.HasOne(d => d.MaTrangThaiDeThiNavigation).WithMany(p => p.Dethidataos).HasConstraintName("FK_DETHIDATAO_TRANGTHAIDETHI");
        });

        modelBuilder.Entity<Diemthi>(entity =>
        {
            entity.Property(e => e.IdDiemThi).ValueGeneratedNever();
            entity.Property(e => e.Bac).IsFixedLength();

            entity.HasOne(d => d.IdThiThuNavigation).WithMany(p => p.Diemthis).HasConstraintName("FK_DIEMTHI_DANGKYTHITHU");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.Diemthis).HasConstraintName("FK_DIEMTHI_SINHVIEN");
        });

        modelBuilder.Entity<Diendan>(entity =>
        {
            entity.Property(e => e.MaDd).ValueGeneratedNever();

            entity.HasOne(d => d.MaDdnNavigation).WithMany(p => p.Diendans).HasConstraintName("FK_DIENDAN_DONDENGHITAODD");
        });

        modelBuilder.Entity<Dondenghitaodd>(entity =>
        {
            entity.Property(e => e.MaDdn).ValueGeneratedNever();
        });

        modelBuilder.Entity<Donkhieunai>(entity =>
        {
            entity.Property(e => e.MaDon).ValueGeneratedNever();

            entity.HasOne(d => d.MaBtNavigation).WithMany(p => p.Donkhieunais).HasConstraintName("FK_DONKHIEUNAI_BAITHI");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.Donkhieunais).HasConstraintName("FK_DONKHIEUNAI_SINHVIEN");
        });

        modelBuilder.Entity<Giaovien>(entity =>
        {
            entity.Property(e => e.MaGv).ValueGeneratedNever();
        });

        modelBuilder.Entity<GiaovienDiendan>(entity =>
        {
            entity.HasOne(d => d.MaDdNavigation).WithMany(p => p.GiaovienDiendans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GIAOVIEN_DIENDAN_DIENDAN");

            entity.HasOne(d => d.MaGvNavigation).WithMany(p => p.GiaovienDiendans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GIAOVIEN_DIENDAN_GIAOVIEN");
        });

        modelBuilder.Entity<Kiemduyetvien>(entity =>
        {
            entity.Property(e => e.MaKdv).ValueGeneratedNever();
        });

        modelBuilder.Entity<Kynang>(entity =>
        {
            entity.Property(e => e.MaKn).ValueGeneratedNever();
        });

        modelBuilder.Entity<Lichhoc>(entity =>
        {
            entity.Property(e => e.LichId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Lichsuduyetch>(entity =>
        {
            entity.Property(e => e.MaLsd).ValueGeneratedNever();

            entity.HasOne(d => d.IdNguoiDuyetLsNavigation).WithMany(p => p.Lichsuduyetches).HasConstraintName("FK_LICHSUDUYETCH_KIEMDUYETVIEN");

            entity.HasOne(d => d.MaChNavigation).WithMany(p => p.Lichsuduyetches).HasConstraintName("FK_LICHSUDUYETCH_CAUHOI");

            entity.HasOne(d => d.MaTtSauNavigation).WithMany(p => p.LichsuduyetchMaTtSauNavigations).HasConstraintName("FK_LICHSUDUYETCH_TRANGTHAICH1");

            entity.HasOne(d => d.MaTtTruocNavigation).WithMany(p => p.LichsuduyetchMaTtTruocNavigations).HasConstraintName("FK_LICHSUDUYETCH_TRANGTHAICH");
        });

        modelBuilder.Entity<Lichsuduyettl>(entity =>
        {
            entity.Property(e => e.MaLsdTl).ValueGeneratedNever();

            entity.HasOne(d => d.IdNguoiDuyetLsTlNavigation).WithMany(p => p.Lichsuduyettls).HasConstraintName("FK_LICHSUDUYETTL_KIEMDUYETVIEN");

            entity.HasOne(d => d.MaTlNavigation).WithMany(p => p.Lichsuduyettls).HasConstraintName("FK_LICHSUDUYETTL_TAILIEUHOCTAP");

            entity.HasOne(d => d.MaTtMoiTlNavigation).WithMany(p => p.LichsuduyettlMaTtMoiTlNavigations).HasConstraintName("FK_LICHSUDUYETTL_TRANGTHAITL1");

            entity.HasOne(d => d.MaTtTruocTlNavigation).WithMany(p => p.LichsuduyettlMaTtTruocTlNavigations).HasConstraintName("FK_LICHSUDUYETTL_TRANGTHAITL");
        });

        modelBuilder.Entity<Lichthitoiec>(entity =>
        {
            entity.Property(e => e.LichThiId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Loaidethi>(entity =>
        {
            entity.Property(e => e.MaLoaiDe).ValueGeneratedNever();
        });

        modelBuilder.Entity<Loaitailieu>(entity =>
        {
            entity.Property(e => e.MaLoaiTl).ValueGeneratedNever();
        });

        modelBuilder.Entity<Lop>(entity =>
        {
            entity.Property(e => e.IdLop).ValueGeneratedNever();

            entity.HasOne(d => d.MaGvNavigation).WithMany(p => p.Lops).HasConstraintName("FK_LOP_GIAOVIEN");
        });

        modelBuilder.Entity<Mucdokho>(entity =>
        {
            entity.Property(e => e.MaMdk).ValueGeneratedNever();
        });

        modelBuilder.Entity<Nhomch>(entity =>
        {
            entity.HasKey(e => e.MaNhomCh).HasName("PK_NHOMCH'");

            entity.Property(e => e.MaNhomCh).ValueGeneratedNever();

            entity.HasOne(d => d.IdGiaoVienTaoNavigation).WithMany(p => p.Nhomches).HasConstraintName("FK_NHOMCH_GIAOVIEN");

            entity.HasOne(d => d.MaPtNavigation).WithMany(p => p.Nhomches).HasConstraintName("FK_NHOMCH_PHANTHI");
        });

        modelBuilder.Entity<Phanloaich>(entity =>
        {
            entity.HasOne(d => d.MaChNavigation).WithMany(p => p.Phanloaiches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHANLOAICH_CAUHOI");

            entity.HasOne(d => d.MaKnNavigation).WithMany(p => p.Phanloaiches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHANLOAICH_KYNANG");

            entity.HasOne(d => d.MaMdkNavigation).WithMany(p => p.Phanloaiches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHANLOAICH_MUCDOKHO");

            entity.HasOne(d => d.MaPtNavigation).WithMany(p => p.Phanloaiches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHANLOAICH_PHANTHI");
        });

        modelBuilder.Entity<Phanloaitl>(entity =>
        {
            entity.Property(e => e.MaPl).ValueGeneratedNever();

            entity.HasOne(d => d.MaKnNavigation).WithMany(p => p.Phanloaitls).HasConstraintName("FK_PHANLOAITL_KYNANG");

            entity.HasOne(d => d.MaPlNavigation).WithOne(p => p.Phanloaitl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHANLOAITL_PHANTHI");
        });

        modelBuilder.Entity<Phanthi>(entity =>
        {
            entity.Property(e => e.MaPt).ValueGeneratedNever();

            entity.HasOne(d => d.MaKnNavigation).WithMany(p => p.Phanthis).HasConstraintName("FK_PHANTHI_KYNANG");
        });

        modelBuilder.Entity<Phieubaitaponluyen>(entity =>
        {
            entity.Property(e => e.IdPhieuBaiTap).ValueGeneratedNever();

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.Phieubaitaponluyens).HasConstraintName("FK_PHIEUBAITAPONLUYEN_SINHVIEN");
        });

        modelBuilder.Entity<Phieudangkytoiec>(entity =>
        {
            entity.Property(e => e.MaPhieu).ValueGeneratedNever();
        });

        modelBuilder.Entity<Sinhvien>(entity =>
        {
            entity.Property(e => e.MaSv).ValueGeneratedNever();
        });

        modelBuilder.Entity<Tailieuhoctap>(entity =>
        {
            entity.Property(e => e.MaTl).ValueGeneratedNever();

            entity.HasOne(d => d.IdNguoiDuyetTlNavigation).WithMany(p => p.Tailieuhoctaps).HasConstraintName("FK_TAILIEUHOCTAP_KIEMDUYETVIEN");

            entity.HasOne(d => d.IdNguoiTaiLenNavigation).WithMany(p => p.Tailieuhoctaps).HasConstraintName("FK_TAILIEUHOCTAP_GIAOVIEN");

            entity.HasOne(d => d.MaLoaiTlNavigation).WithMany(p => p.Tailieuhoctaps).HasConstraintName("FK_TAILIEUHOCTAP_LOAITAILIEU");

            entity.HasOne(d => d.MaTtTlNavigation).WithMany(p => p.Tailieuhoctaps).HasConstraintName("FK_TAILIEUHOCTAP_TRANGTHAITL");

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

        modelBuilder.Entity<Thamgium>(entity =>
        {
            entity.HasOne(d => d.MaDdNavigation).WithMany(p => p.Thamgia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_THAMGIA_DIENDAN");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.Thamgia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_THAMGIA_SINHVIEN");
        });

        modelBuilder.Entity<Thongkelop>(entity =>
        {
            entity.Property(e => e.IdThongke).ValueGeneratedNever();

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.Thongkelops).HasConstraintName("FK_THONGKELOP_LOP");
        });

        modelBuilder.Entity<Trangthaich>(entity =>
        {
            entity.Property(e => e.MaTtCh).ValueGeneratedNever();
        });

        modelBuilder.Entity<Trangthaidethi>(entity =>
        {
            entity.Property(e => e.MaTrangThaiDe).ValueGeneratedNever();
        });

        modelBuilder.Entity<Trangthaitl>(entity =>
        {
            entity.Property(e => e.MaTtTl).ValueGeneratedNever();
        });

        modelBuilder.Entity<TtLichthitoiec>(entity =>
        {
            entity.Property(e => e.MaTtLichThi).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
