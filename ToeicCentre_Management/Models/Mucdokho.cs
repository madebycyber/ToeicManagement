using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("MUCDOKHO")]
public partial class Mucdokho
{
    [Key]
    [Column("MaMDK")]
    public int MaMdk { get; set; }

    [Column("TenMDK")]
    [StringLength(100)]
    public string? TenMdk { get; set; }

    [InverseProperty("MaDoKhoPartNavigation")]
    public virtual ICollection<Cautrucdethi> Cautrucdethis { get; set; } = new List<Cautrucdethi>();

    [InverseProperty("MaMdkNavigation")]
    public virtual ICollection<Phanloaich> Phanloaiches { get; set; } = new List<Phanloaich>();
}
