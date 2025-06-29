using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("DANGKYTHITHU")]
public partial class Dangkythithu
{
    [Key]
    [Column("id_ThiThu")]
    public int IdThiThu { get; set; }

    [Column("MaSV")]
    public int? MaSv { get; set; }

    public DateOnly? NgayThiThu { get; set; }

    [StringLength(25)]
    public string? CaThi { get; set; }

    [StringLength(100)]
    public string? DiaDiem { get; set; }

    [StringLength(100)]
    public string? DotThiThu { get; set; }

    [Column("id_DeThi")]
    public int? IdDeThi { get; set; }

    [StringLength(500)]
    public string? GhiChu { get; set; }

    [Column("MaLSD_TL")]
    public int? MaLsdTl { get; set; }

    [InverseProperty("IdThiThuNavigation")]
    public virtual ICollection<Bienbanthithu> Bienbanthithus { get; set; } = new List<Bienbanthithu>();

    [InverseProperty("IdThiThuNavigation")]
    public virtual ICollection<Diemthi> Diemthis { get; set; } = new List<Diemthi>();

    [ForeignKey("IdDeThi")]
    [InverseProperty("Dangkythithus")]
    public virtual Dethi? IdDeThiNavigation { get; set; }

    [ForeignKey("MaLsdTl")]
    [InverseProperty("Dangkythithus")]
    public virtual Lichsuduyettl? MaLsdTlNavigation { get; set; }

    [ForeignKey("MaSv")]
    [InverseProperty("Dangkythithus")]
    public virtual Sinhvien? MaSvNavigation { get; set; }
}
