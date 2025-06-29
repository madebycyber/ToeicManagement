using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("CAUHOIBAITAP")]
public partial class Cauhoibaitap
{
    [Key]
    [Column("id_BaiTap")]
    public int IdBaiTap { get; set; }

    [Column("id_PhieuBaiTap")]
    public int IdPhieuBaiTap { get; set; }

    [Column("MaCH")]
    public int? MaCh { get; set; }

    [ForeignKey("IdPhieuBaiTap")]
    [InverseProperty("Cauhoibaitaps")]
    public virtual Phieubaitaponluyen IdPhieuBaiTapNavigation { get; set; } = null!;

    [ForeignKey("MaCh")]
    [InverseProperty("Cauhoibaitaps")]
    public virtual Cauhoi? MaChNavigation { get; set; }
}
