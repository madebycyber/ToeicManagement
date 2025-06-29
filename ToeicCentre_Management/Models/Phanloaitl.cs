using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("PHANLOAITL")]
public partial class Phanloaitl
{
    [Key]
    [Column("MaPL")]
    public int MaPl { get; set; }

    [Column("MaKN")]
    public int? MaKn { get; set; }

    [Column("MaPT")]
    public int? MaPt { get; set; }

    [ForeignKey("MaKn")]
    [InverseProperty("Phanloaitls")]
    public virtual Kynang? MaKnNavigation { get; set; }

    [ForeignKey("MaPl")]
    [InverseProperty("Phanloaitl")]
    public virtual Phanthi MaPlNavigation { get; set; } = null!;
}
