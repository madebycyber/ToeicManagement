using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("LOAIDETHI")]
public partial class Loaidethi
{
    [Key]
    public int MaLoaiDe { get; set; }

    [StringLength(100)]
    public string? TenLoaiDe { get; set; }

    [InverseProperty("MaLoaiDeNavigation")]
    public virtual ICollection<Dethidatao> Dethidataos { get; set; } = new List<Dethidatao>();
}
