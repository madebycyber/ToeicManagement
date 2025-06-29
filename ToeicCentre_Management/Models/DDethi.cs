using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("D_DETHI")]
public partial class DDethi
{
    [Key]
    [Column("id_DDeThi")]
    public int IdDdeThi { get; set; }

    [Column("MaCH")]
    public int? MaCh { get; set; }

    [Column("id_DeThi")]
    public int? IdDeThi { get; set; }

    [ForeignKey("IdDeThi")]
    [InverseProperty("DDethis")]
    public virtual Dethi? IdDeThiNavigation { get; set; }

    [ForeignKey("MaCh")]
    [InverseProperty("DDethis")]
    public virtual Cauhoi? MaChNavigation { get; set; }
}
