using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("KYNANG")]
public partial class Kynang
{
    [Key]
    [Column("MaKN")]
    public int MaKn { get; set; }

    [Column("TenKN")]
    [StringLength(100)]
    public string? TenKn { get; set; }

    [InverseProperty("MaKnNavigation")]
    public virtual ICollection<Phanloaich> Phanloaiches { get; set; } = new List<Phanloaich>();

    [InverseProperty("MaKnNavigation")]
    public virtual ICollection<Phanloaitl> Phanloaitls { get; set; } = new List<Phanloaitl>();

    [InverseProperty("MaKnNavigation")]
    public virtual ICollection<Phanthi> Phanthis { get; set; } = new List<Phanthi>();
}
