using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("PHANTHI")]
public partial class Phanthi
{
    [Key]
    [Column("MaPT")]
    public int MaPt { get; set; }

    [Column("TenPT")]
    [StringLength(100)]
    public string? TenPt { get; set; }

    [Column("MaKN")]
    public int? MaKn { get; set; }

    [InverseProperty("MaPtNavigation")]
    public virtual ICollection<Cautrucdethi> Cautrucdethis { get; set; } = new List<Cautrucdethi>();

    [ForeignKey("MaKn")]
    [InverseProperty("Phanthis")]
    public virtual Kynang? MaKnNavigation { get; set; }

    [InverseProperty("MaPtNavigation")]
    public virtual ICollection<Nhomch> Nhomches { get; set; } = new List<Nhomch>();

    [InverseProperty("MaPtNavigation")]
    public virtual ICollection<Phanloaich> Phanloaiches { get; set; } = new List<Phanloaich>();

    [InverseProperty("MaPlNavigation")]
    public virtual Phanloaitl? Phanloaitl { get; set; }
}
