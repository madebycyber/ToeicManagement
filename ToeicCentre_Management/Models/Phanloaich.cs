using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[PrimaryKey("MaCh", "MaPt")]
[Table("PHANLOAICH")]
public partial class Phanloaich
{
    [Key]
    [Column("MaCH")]
    public int MaCh { get; set; }

    [Key]
    [Column("MaPT")]
    public int MaPt { get; set; }

    [Column("MaKN")]
    public int MaKn { get; set; }

    [Column("MaMDK")]
    public int MaMdk { get; set; }

    [ForeignKey("MaCh")]
    [InverseProperty("Phanloaiches")]
    public virtual Cauhoi MaChNavigation { get; set; } = null!;

    [ForeignKey("MaKn")]
    [InverseProperty("Phanloaiches")]
    public virtual Kynang MaKnNavigation { get; set; } = null!;

    [ForeignKey("MaMdk")]
    [InverseProperty("Phanloaiches")]
    public virtual Mucdokho MaMdkNavigation { get; set; } = null!;

    [ForeignKey("MaPt")]
    [InverseProperty("Phanloaiches")]
    public virtual Phanthi MaPtNavigation { get; set; } = null!;
}
