using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("NHOMCH")]
public partial class Nhomch
{
    [Key]
    [Column("MaNhomCH")]
    public int MaNhomCh { get; set; }

    [Column("KyHieu_NhomCh")]
    [StringLength(50)]
    public string? KyHieuNhomCh { get; set; }

    [Column("ND_DoanVan")]
    public string? NdDoanVan { get; set; }

    [Column("ND_HoiThoai")]
    public string? NdHoiThoai { get; set; }

    [Column("Path_AudioNhom")]
    [StringLength(500)]
    public string? PathAudioNhom { get; set; }

    [Column("ID_GiaoVienTao")]
    public int? IdGiaoVienTao { get; set; }

    public DateOnly? NgayTaoNhom { get; set; }

    [Column("MaPT")]
    public int? MaPt { get; set; }

    [InverseProperty("MaNhomChNavigation")]
    public virtual ICollection<Cauhoi> Cauhois { get; set; } = new List<Cauhoi>();

    [ForeignKey("IdGiaoVienTao")]
    [InverseProperty("Nhomches")]
    public virtual Giaovien? IdGiaoVienTaoNavigation { get; set; }

    [ForeignKey("MaPt")]
    [InverseProperty("Nhomches")]
    public virtual Phanthi? MaPtNavigation { get; set; }
}
