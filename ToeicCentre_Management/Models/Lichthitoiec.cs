using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("LICHTHITOIEC")]
public partial class Lichthitoiec
{
    [Key]
    [Column("LichThiID")]
    public int LichThiId { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [StringLength(100)]
    public string? DiaDiemThi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ThoiGianTao { get; set; }
}
