using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("PHIEUDANGKYTOIEC")]
public partial class Phieudangkytoiec
{
    [Key]
    public int MaPhieu { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(255)]
    public string? TenDonVi { get; set; }

    [StringLength(255)]
    public string? HoVaTen { get; set; }

    [StringLength(10)]
    public string? GioiTinh { get; set; }

    public DateOnly? NgaySinh { get; set; }

    [Column("CCCD", TypeName = "numeric(12, 0)")]
    public decimal Cccd { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal? SoDienThoai { get; set; }

    [StringLength(255)]
    public string? DiaChiLienHe { get; set; }

    [StringLength(255)]
    public string? Email { get; set; }

    [StringLength(255)]
    public string? NoiCongTac { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayGioDangKy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GioThi { get; set; }

    public DateOnly? NgayKiemTraKetQua { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? LePhiThi { get; set; }

    public DateOnly? NgayDangKy { get; set; }
}
