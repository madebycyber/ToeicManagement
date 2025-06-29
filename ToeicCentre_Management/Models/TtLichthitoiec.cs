using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("TT_LICHTHITOIEC")]
public partial class TtLichthitoiec
{
    [Key]
    [Column("MaTT_LichThi")]
    public int MaTtLichThi { get; set; }

    [Column("LichThiID")]
    public int? LichThiId { get; set; }

    public DateOnly? NgayThi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GioThuTuc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GioBatDauLamBai { get; set; }

    [StringLength(100)]
    public string? LoaiBaiThi { get; set; }
}
