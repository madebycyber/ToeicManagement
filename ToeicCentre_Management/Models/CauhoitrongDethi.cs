using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[PrimaryKey("MaDeThi", "MaCh")]
[Table("CAUHOITRONG DETHI")]
public partial class CauhoitrongDethi
{
    [Key]
    public int MaDeThi { get; set; }

    [Key]
    [Column("MaCH")]
    public int MaCh { get; set; }

    [Column("STT_CH_TrongDe")]
    public int? SttChTrongDe { get; set; }

    [ForeignKey("MaCh")]
    [InverseProperty("CauhoitrongDethis")]
    public virtual Cauhoi MaChNavigation { get; set; } = null!;

    [ForeignKey("MaDeThi")]
    [InverseProperty("CauhoitrongDethis")]
    public virtual Dethidatao MaDeThiNavigation { get; set; } = null!;
}
