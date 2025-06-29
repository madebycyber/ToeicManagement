using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("TRANGTHAIDETHI")]
public partial class Trangthaidethi
{
    [Key]
    public int MaTrangThaiDe { get; set; }

    [StringLength(100)]
    public string? TenTrangThaiDe { get; set; }

    [InverseProperty("MaTrangThaiDeThiNavigation")]
    public virtual ICollection<Dethidatao> Dethidataos { get; set; } = new List<Dethidatao>();
}
