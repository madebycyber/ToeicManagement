using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("DONKHIEUNAI")]
public partial class Donkhieunai
{
    [Key]
    public int MaDon { get; set; }

    public int? CauSo { get; set; }

    [StringLength(25)]
    public string? HinhThucCauHoi { get; set; }

    [StringLength(100)]
    public string? MoTaSaiSot { get; set; }

    [StringLength(100)]
    public string? DeNghiXemXet { get; set; }

    [StringLength(25)]
    public string? NguoiLap { get; set; }

    [Column("MaBT")]
    public int? MaBt { get; set; }

    [Column("MaSV")]
    public int? MaSv { get; set; }

    [ForeignKey("MaBt")]
    [InverseProperty("Donkhieunais")]
    public virtual Baithi? MaBtNavigation { get; set; }

    [ForeignKey("MaSv")]
    [InverseProperty("Donkhieunais")]
    public virtual Sinhvien? MaSvNavigation { get; set; }
}
