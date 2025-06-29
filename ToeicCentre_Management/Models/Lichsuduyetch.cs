using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("LICHSUDUYETCH")]
public partial class Lichsuduyetch
{
    [Key]
    [Column("MaLSD")]
    public int MaLsd { get; set; }

    [Column("MaCH")]
    public int? MaCh { get; set; }

    [Column("ID_NguoiDuyetLS")]
    public int? IdNguoiDuyetLs { get; set; }

    [Column("MaTT_Truoc")]
    public int? MaTtTruoc { get; set; }

    [Column("MaTT_Sau")]
    public int? MaTtSau { get; set; }

    [Column("GhiCHuDuyet")]
    public string? GhiChuDuyet { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ThoiDiemDuyet { get; set; }

    [ForeignKey("IdNguoiDuyetLs")]
    [InverseProperty("Lichsuduyetches")]
    public virtual Kiemduyetvien? IdNguoiDuyetLsNavigation { get; set; }

    [ForeignKey("MaCh")]
    [InverseProperty("Lichsuduyetches")]
    public virtual Cauhoi? MaChNavigation { get; set; }

    [ForeignKey("MaTtSau")]
    [InverseProperty("LichsuduyetchMaTtSauNavigations")]
    public virtual Trangthaich? MaTtSauNavigation { get; set; }

    [ForeignKey("MaTtTruoc")]
    [InverseProperty("LichsuduyetchMaTtTruocNavigations")]
    public virtual Trangthaich? MaTtTruocNavigation { get; set; }
}
