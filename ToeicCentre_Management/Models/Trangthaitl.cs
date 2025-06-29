using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("TRANGTHAITL")]
public partial class Trangthaitl
{
    [Key]
    [Column("MaTT_Tl")]
    public int MaTtTl { get; set; }

    [Column("KyHieuTT_TL")]
    [StringLength(50)]
    public string? KyHieuTtTl { get; set; }

    [Column("TenTT_TL")]
    [StringLength(100)]
    public string? TenTtTl { get; set; }

    [Column("MoTaTT_TL")]
    public string? MoTaTtTl { get; set; }

    [InverseProperty("MaTtMoiTlNavigation")]
    public virtual ICollection<Lichsuduyettl> LichsuduyettlMaTtMoiTlNavigations { get; set; } = new List<Lichsuduyettl>();

    [InverseProperty("MaTtTruocTlNavigation")]
    public virtual ICollection<Lichsuduyettl> LichsuduyettlMaTtTruocTlNavigations { get; set; } = new List<Lichsuduyettl>();

    [InverseProperty("MaTtTlNavigation")]
    public virtual ICollection<Tailieuhoctap> Tailieuhoctaps { get; set; } = new List<Tailieuhoctap>();
}
