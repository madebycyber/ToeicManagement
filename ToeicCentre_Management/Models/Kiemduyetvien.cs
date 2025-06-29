using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("KIEMDUYETVIEN")]
public partial class Kiemduyetvien
{
    [Key]
    [Column("MaKDV")]
    public int MaKdv { get; set; }

    [Column("HoTenKDV")]
    [StringLength(255)]
    public string? HoTenKdv { get; set; }

    [Column("EmailKDV")]
    [StringLength(255)]
    public string? EmailKdv { get; set; }

    [Column("TenDangNhapKDV")]
    [StringLength(100)]
    public string? TenDangNhapKdv { get; set; }

    [Column("MatKhauKDV")]
    [StringLength(255)]
    public string? MatKhauKdv { get; set; }

    [InverseProperty("IdNguoiDuyetChNavigation")]
    public virtual ICollection<Cauhoi> Cauhois { get; set; } = new List<Cauhoi>();

    [InverseProperty("IdNguoiDuyetLsNavigation")]
    public virtual ICollection<Lichsuduyetch> Lichsuduyetches { get; set; } = new List<Lichsuduyetch>();

    [InverseProperty("IdNguoiDuyetLsTlNavigation")]
    public virtual ICollection<Lichsuduyettl> Lichsuduyettls { get; set; } = new List<Lichsuduyettl>();

    [InverseProperty("IdNguoiDuyetTlNavigation")]
    public virtual ICollection<Tailieuhoctap> Tailieuhoctaps { get; set; } = new List<Tailieuhoctap>();
}
