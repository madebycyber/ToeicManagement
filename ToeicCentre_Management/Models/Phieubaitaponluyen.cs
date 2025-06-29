using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("PHIEUBAITAPONLUYEN")]
public partial class Phieubaitaponluyen
{
    [Key]
    [Column("id_PhieuBaiTap")]
    public int IdPhieuBaiTap { get; set; }

    [Column("MaSV")]
    public int? MaSv { get; set; }

    [StringLength(25)]
    public string? Lop { get; set; }

    [StringLength(25)]
    public string? DangCauHoi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ThoiGianGiao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ThoiGianNop { get; set; }

    public int? DiemSo { get; set; }

    [StringLength(500)]
    public string? NhanXet { get; set; }

    [InverseProperty("IdPhieuBaiTapNavigation")]
    public virtual ICollection<Cauhoibaitap> Cauhoibaitaps { get; set; } = new List<Cauhoibaitap>();

    [ForeignKey("MaSv")]
    [InverseProperty("Phieubaitaponluyens")]
    public virtual Sinhvien? MaSvNavigation { get; set; }
}
