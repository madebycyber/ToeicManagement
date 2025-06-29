using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("LOAITAILIEU")]
public partial class Loaitailieu
{
    [Key]
    [Column("MaLoaiTL")]
    public int MaLoaiTl { get; set; }

    [Column("TenLoaiTL")]
    [StringLength(100)]
    public string? TenLoaiTl { get; set; }

    [Column("MoTaLoaiTL")]
    public string? MoTaLoaiTl { get; set; }

    [InverseProperty("MaLoaiTlNavigation")]
    public virtual ICollection<Tailieuhoctap> Tailieuhoctaps { get; set; } = new List<Tailieuhoctap>();
}
