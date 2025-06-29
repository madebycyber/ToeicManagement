using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("DIENDAN")]
public partial class Diendan
{
    [Key]
    [Column("MaDD")]
    public int MaDd { get; set; }

    [StringLength(100)]
    public string? TieuDe { get; set; }

    [StringLength(25)]
    public string? NguoiTao { get; set; }

    public int? SoBaiViet { get; set; }

    [StringLength(25)]
    public string? TrangThai { get; set; }

    [StringLength(25)]
    public string? HanhDong { get; set; }

    [StringLength(100)]
    public string? GhiChu { get; set; }

    [Column("MaDDN")]
    public int? MaDdn { get; set; }

    [InverseProperty("MaDdNavigation")]
    public virtual ICollection<Baiviet> Baiviets { get; set; } = new List<Baiviet>();

    [InverseProperty("MaDdNavigation")]
    public virtual ICollection<GiaovienDiendan> GiaovienDiendans { get; set; } = new List<GiaovienDiendan>();

    [ForeignKey("MaDdn")]
    [InverseProperty("Diendans")]
    public virtual Dondenghitaodd? MaDdnNavigation { get; set; }

    [InverseProperty("MaDdNavigation")]
    public virtual ICollection<Thamgium> Thamgia { get; set; } = new List<Thamgium>();
}
