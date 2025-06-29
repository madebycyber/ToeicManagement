using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("LICHHOC")]
public partial class Lichhoc
{
    [Key]
    [Column("LichID")]
    public int LichId { get; set; }

    [Column("LopID")]
    public int? LopId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ThoiGianBatDau { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ThoiGianKetThuc { get; set; }
}
