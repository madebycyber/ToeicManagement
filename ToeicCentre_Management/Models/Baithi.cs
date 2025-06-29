using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("BAITHI")]
public partial class Baithi
{
    [Key]
    [Column("MaBT")]
    public int MaBt { get; set; }

    public DateOnly? NgayLap { get; set; }

    [StringLength(255)]
    public string? TenBaiThi { get; set; }

    public DateOnly? NgayThi { get; set; }

    [Column("TGLamBai")]
    [StringLength(10)]
    public string? TglamBai { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TongDiem { get; set; }

    [InverseProperty("MaBtNavigation")]
    public virtual ICollection<Chitietbaithi> Chitietbaithis { get; set; } = new List<Chitietbaithi>();

    [InverseProperty("MaBtNavigation")]
    public virtual ICollection<Donkhieunai> Donkhieunais { get; set; } = new List<Donkhieunai>();
}
