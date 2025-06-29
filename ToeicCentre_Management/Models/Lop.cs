using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("LOP")]
public partial class Lop
{
    [Key]
    [Column("id_Lop")]
    public int IdLop { get; set; }

    [StringLength(25)]
    public string? TenLop { get; set; }

    public DateOnly? ThangBatDau { get; set; }

    public DateOnly? ThangKetThuc { get; set; }

    [Column("MaGV")]
    public int? MaGv { get; set; }

    [InverseProperty("IdLopNavigation")]
    public virtual ICollection<Dangkyonluyen> Dangkyonluyens { get; set; } = new List<Dangkyonluyen>();

    [ForeignKey("MaGv")]
    [InverseProperty("Lops")]
    public virtual Giaovien? MaGvNavigation { get; set; }

    [InverseProperty("IdLopNavigation")]
    public virtual ICollection<Thongkelop> Thongkelops { get; set; } = new List<Thongkelop>();
}
