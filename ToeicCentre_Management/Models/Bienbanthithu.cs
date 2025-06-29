using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("BIENBANTHITHU")]
public partial class Bienbanthithu
{
    [Key]
    [Column("id_BienBanThiThu")]
    public int IdBienBanThiThu { get; set; }

    [Column("id_ThiThu")]
    public int? IdThiThu { get; set; }

    [StringLength(25)]
    public string? DotThiThu { get; set; }

    [StringLength(100)]
    public string? DiaDiem { get; set; }

    [StringLength(25)]
    public string? GiamThiCoiThi1 { get; set; }

    [StringLength(25)]
    public string? GiamThiCoiThi2 { get; set; }

    [ForeignKey("IdThiThu")]
    [InverseProperty("Bienbanthithus")]
    public virtual Dangkythithu? IdThiThuNavigation { get; set; }
}
