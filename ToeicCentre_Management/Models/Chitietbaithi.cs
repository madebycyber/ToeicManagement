using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[PrimaryKey("MaBt", "MaSv")]
[Table("CHITIETBAITHI")]
public partial class Chitietbaithi
{
    [Key]
    [Column("MaBT")]
    public int MaBt { get; set; }

    [Key]
    [Column("MaSV")]
    public int MaSv { get; set; }

    [StringLength(25)]
    public string? PhanThi { get; set; }

    public int? SoCauDung { get; set; }

    public int? DiemSo { get; set; }

    [ForeignKey("MaBt")]
    [InverseProperty("Chitietbaithis")]
    public virtual Baithi MaBtNavigation { get; set; } = null!;

    [ForeignKey("MaSv")]
    [InverseProperty("Chitietbaithis")]
    public virtual Sinhvien MaSvNavigation { get; set; } = null!;
}
