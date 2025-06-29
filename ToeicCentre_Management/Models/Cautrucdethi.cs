using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[PrimaryKey("MaDeThi", "MaPt")]
[Table("CAUTRUCDETHI")]
public partial class Cautrucdethi
{
    [Key]
    public int MaDeThi { get; set; }

    [Key]
    [Column("MaPT")]
    public int MaPt { get; set; }

    public int? SoLuongCau { get; set; }

    public int? MaDoKhoPart { get; set; }

    [ForeignKey("MaDoKhoPart")]
    [InverseProperty("Cautrucdethis")]
    public virtual Mucdokho? MaDoKhoPartNavigation { get; set; }

    [ForeignKey("MaPt")]
    [InverseProperty("Cautrucdethis")]
    public virtual Phanthi MaPtNavigation { get; set; } = null!;
}
