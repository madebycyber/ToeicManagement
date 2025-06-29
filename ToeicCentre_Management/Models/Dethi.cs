using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("DETHI")]
public partial class Dethi
{
    [Key]
    [Column("id_DeThi")]
    public int IdDeThi { get; set; }

    [StringLength(25)]
    public string? LoaiDde { get; set; }

    [StringLength(25)]
    public string? HinhThuc { get; set; }

    public int? ThoiGian { get; set; }

    [InverseProperty("IdDeThiNavigation")]
    public virtual ICollection<DDethi> DDethis { get; set; } = new List<DDethi>();

    [InverseProperty("IdDeThiNavigation")]
    public virtual ICollection<Dangkythithu> Dangkythithus { get; set; } = new List<Dangkythithu>();
}
