using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("LICHSUDUYETTL")]
public partial class Lichsuduyettl
{
    [Key]
    [Column("MaLSD_TL")]
    public int MaLsdTl { get; set; }

    [Column("MaTL")]
    public int? MaTl { get; set; }

    [Column("ID_NguoiDuyetLS_TL")]
    public int? IdNguoiDuyetLsTl { get; set; }

    [Column("MaTT_Truoc_TL")]
    public int? MaTtTruocTl { get; set; }

    [Column("MaTT_Moi_TL")]
    public int? MaTtMoiTl { get; set; }

    [Column("GhiChuDuyetTL")]
    public string? GhiChuDuyetTl { get; set; }

    [Column("ThoiDiemDuyetTL", TypeName = "datetime")]
    public DateTime? ThoiDiemDuyetTl { get; set; }

    [InverseProperty("MaLsdTlNavigation")]
    public virtual ICollection<Dangkythithu> Dangkythithus { get; set; } = new List<Dangkythithu>();

    [ForeignKey("IdNguoiDuyetLsTl")]
    [InverseProperty("Lichsuduyettls")]
    public virtual Kiemduyetvien? IdNguoiDuyetLsTlNavigation { get; set; }

    [ForeignKey("MaTl")]
    [InverseProperty("Lichsuduyettls")]
    public virtual Tailieuhoctap? MaTlNavigation { get; set; }

    [ForeignKey("MaTtMoiTl")]
    [InverseProperty("LichsuduyettlMaTtMoiTlNavigations")]
    public virtual Trangthaitl? MaTtMoiTlNavigation { get; set; }

    [ForeignKey("MaTtTruocTl")]
    [InverseProperty("LichsuduyettlMaTtTruocTlNavigations")]
    public virtual Trangthaitl? MaTtTruocTlNavigation { get; set; }
}
