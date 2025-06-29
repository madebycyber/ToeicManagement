using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("SINHVIEN")]
public partial class Sinhvien
{
    [Key]
    [Column("MaSV")]
    public int MaSv { get; set; }

    [Column("HoTenSV")]
    [StringLength(255)]
    public string? HoTenSv { get; set; }

    [StringLength(100)]
    public string? Lop { get; set; }

    [StringLength(255)]
    public string? Email { get; set; }

    public DateOnly? NgaySinh { get; set; }

    [StringLength(500)]
    public string? DiaChi { get; set; }

    [Column("CCCD", TypeName = "numeric(12, 0)")]
    public decimal? Cccd { get; set; }

    [StringLength(100)]
    public string? TenDangNhapSv { get; set; }

    [Column("MatKhauSV")]
    [StringLength(255)]
    public string? MatKhauSv { get; set; }

    [InverseProperty("MaSvNavigation")]
    public virtual ICollection<Chitietbaithi> Chitietbaithis { get; set; } = new List<Chitietbaithi>();

    [InverseProperty("MaSvNavigation")]
    public virtual ICollection<Dangkyonluyen> Dangkyonluyens { get; set; } = new List<Dangkyonluyen>();

    [InverseProperty("MaSvNavigation")]
    public virtual ICollection<Dangkythithu> Dangkythithus { get; set; } = new List<Dangkythithu>();

    [InverseProperty("IdSinhVienTaoDeNavigation")]
    public virtual ICollection<Dethidatao> Dethidataos { get; set; } = new List<Dethidatao>();

    [InverseProperty("MaSvNavigation")]
    public virtual ICollection<Diemthi> Diemthis { get; set; } = new List<Diemthi>();

    [InverseProperty("MaSvNavigation")]
    public virtual ICollection<Donkhieunai> Donkhieunais { get; set; } = new List<Donkhieunai>();

    [InverseProperty("MaSvNavigation")]
    public virtual ICollection<Phieubaitaponluyen> Phieubaitaponluyens { get; set; } = new List<Phieubaitaponluyen>();

    [InverseProperty("MaSvNavigation")]
    public virtual ICollection<Thamgium> Thamgia { get; set; } = new List<Thamgium>();
}
