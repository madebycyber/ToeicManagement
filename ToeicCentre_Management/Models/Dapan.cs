using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("DAPAN")]
public partial class Dapan
{
    [Key]
    [Column("MaDA")]
    public int MaDa { get; set; }

    [Column("MaCH")]
    public int? MaCh { get; set; }

    [Column("ND_DapAn")]
    public string? NdDapAn { get; set; }

    public bool? LaDapAnDung { get; set; }

    [Column("KyHieuDA")]
    [StringLength(1)]
    [Unicode(false)]
    public string? KyHieuDa { get; set; }

    [ForeignKey("MaCh")]
    [InverseProperty("Dapans")]
    public virtual Cauhoi? MaChNavigation { get; set; }
}
