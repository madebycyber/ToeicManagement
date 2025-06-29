using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("GIAOVIEN")]
public partial class Giaovien
{
    [Key]
    [Column("MaGV")]
    public int MaGv { get; set; }

    [StringLength(255)]
    public string? TenGiaoVien { get; set; }

    [StringLength(500)]
    public string? DiaChi { get; set; }

    [Column("SDT", TypeName = "numeric(10, 0)")]
    public decimal? Sdt { get; set; }

    [StringLength(255)]
    public string? Email { get; set; }

    [StringLength(100)]
    public string? CapBac { get; set; }

    [StringLength(100)]
    public string? ChucVu { get; set; }

    [Column("TenDangNhapGV")]
    [StringLength(255)]
    public string? TenDangNhapGv { get; set; }

    [Column("MatKhauGV")]
    [StringLength(255)]
    public string? MatKhauGv { get; set; }

    [InverseProperty("MaNguoiTaoNavigation")]
    public virtual ICollection<Baiviet> Baiviets { get; set; } = new List<Baiviet>();

    [InverseProperty("IdGiaoVienTaoChNavigation")]
    public virtual ICollection<Cauhoi> Cauhois { get; set; } = new List<Cauhoi>();

    [InverseProperty("IdGiaoVienTaoDeNavigation")]
    public virtual ICollection<Dethidatao> Dethidataos { get; set; } = new List<Dethidatao>();

    [InverseProperty("MaGvNavigation")]
    public virtual ICollection<GiaovienDiendan> GiaovienDiendans { get; set; } = new List<GiaovienDiendan>();

    [InverseProperty("MaGvNavigation")]
    public virtual ICollection<Lop> Lops { get; set; } = new List<Lop>();

    [InverseProperty("IdGiaoVienTaoNavigation")]
    public virtual ICollection<Nhomch> Nhomches { get; set; } = new List<Nhomch>();

    [InverseProperty("IdNguoiTaiLenNavigation")]
    public virtual ICollection<Tailieuhoctap> Tailieuhoctaps { get; set; } = new List<Tailieuhoctap>();
}
