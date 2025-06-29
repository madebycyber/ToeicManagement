using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("DONDENGHITAODD")]
public partial class Dondenghitaodd
{
    [Key]
    [Column("MaDDN")]
    public int MaDdn { get; set; }

    [Column("TenNguoiDN")]
    [StringLength(25)]
    public string? TenNguoiDn { get; set; }

    [StringLength(25)]
    public string? ChucVu { get; set; }

    [StringLength(25)]
    public string? DonVi { get; set; }

    public DateOnly? NgayVietDon { get; set; }

    [StringLength(100)]
    public string? TenDienDanDeXuat { get; set; }

    [StringLength(100)]
    public string? MucDich { get; set; }

    public string? NoiDung { get; set; }

    [StringLength(100)]
    public string? HinhThucTrienKhai { get; set; }

    public string? LoiIchKyVong { get; set; }

    [InverseProperty("MaDdnNavigation")]
    public virtual ICollection<Diendan> Diendans { get; set; } = new List<Diendan>();
}
