using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("TAILIEUHOCTAP")]
public partial class Tailieuhoctap
{
    [Key]
    [Column("MaTL")]
    public int MaTl { get; set; }

    [Column("TieuDeTL")]
    [StringLength(500)]
    public string? TieuDeTl { get; set; }

    [Column("MoTaNganTL")]
    public string? MoTaNganTl { get; set; }

    [Column("Path_FileTL")]
    [StringLength(500)]
    public string? PathFileTl { get; set; }

    [Column("URL_NgoaiTL")]
    [StringLength(1000)]
    public string? UrlNgoaiTl { get; set; }

    public string? NoiDungVanBan { get; set; }

    [Column("MaLoaiTL")]
    public int? MaLoaiTl { get; set; }

    [Column("MaTT_TL")]
    public int? MaTtTl { get; set; }

    [Column("ID_NguoiTaiLen")]
    public int? IdNguoiTaiLen { get; set; }

    [Column("ID_NguoiDuyetTL")]
    public int? IdNguoiDuyetTl { get; set; }

    [Column("NgayTaiLenTL", TypeName = "datetime")]
    public DateTime? NgayTaiLenTl { get; set; }

    [Column("NgayDuyetTL", TypeName = "datetime")]
    public DateTime? NgayDuyetTl { get; set; }

    [Column("NgayCapNhatTL_Cuoi", TypeName = "datetime")]
    public DateTime? NgayCapNhatTlCuoi { get; set; }

    [ForeignKey("IdNguoiDuyetTl")]
    [InverseProperty("Tailieuhoctaps")]
    public virtual Kiemduyetvien? IdNguoiDuyetTlNavigation { get; set; }

    [ForeignKey("IdNguoiTaiLen")]
    [InverseProperty("Tailieuhoctaps")]
    public virtual Giaovien? IdNguoiTaiLenNavigation { get; set; }

    [InverseProperty("MaTlNavigation")]
    public virtual ICollection<Lichsuduyettl> Lichsuduyettls { get; set; } = new List<Lichsuduyettl>();

    [ForeignKey("MaLoaiTl")]
    [InverseProperty("Tailieuhoctaps")]
    public virtual Loaitailieu? MaLoaiTlNavigation { get; set; }

    [ForeignKey("MaTtTl")]
    [InverseProperty("Tailieuhoctaps")]
    public virtual Trangthaitl? MaTtTlNavigation { get; set; }

    [ForeignKey("MaTl")]
    [InverseProperty("MaTls")]
    public virtual ICollection<Chudetl> MaChuDeTls { get; set; } = new List<Chudetl>();
}
