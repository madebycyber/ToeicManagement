using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("CHUDETL")]
public partial class Chudetl
{
    [Key]
    [Column("MaChuDeTL")]
    public int MaChuDeTl { get; set; }

    [Column("TenChuDeTL")]
    [StringLength(255)]
    public string? TenChuDeTl { get; set; }

    [Column("MoTaChuDeTL")]
    public string? MoTaChuDeTl { get; set; }

    [ForeignKey("MaChuDeTl")]
    [InverseProperty("MaChuDeTls")]
    public virtual ICollection<Tailieuhoctap> MaTls { get; set; } = new List<Tailieuhoctap>();
}
