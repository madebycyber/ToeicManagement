using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("TRANGTHAICH")]
public partial class Trangthaich
{
    [Key]
    [Column("MaTT_CH")]
    public int MaTtCh { get; set; }

    [Column("TenTT_CH")]
    [StringLength(100)]
    public string? TenTtCh { get; set; }

    [InverseProperty("MaTtChNavigation")]
    public virtual ICollection<Cauhoi> Cauhois { get; set; } = new List<Cauhoi>();

    [InverseProperty("MaTtSauNavigation")]
    public virtual ICollection<Lichsuduyetch> LichsuduyetchMaTtSauNavigations { get; set; } = new List<Lichsuduyetch>();

    [InverseProperty("MaTtTruocNavigation")]
    public virtual ICollection<Lichsuduyetch> LichsuduyetchMaTtTruocNavigations { get; set; } = new List<Lichsuduyetch>();
}
