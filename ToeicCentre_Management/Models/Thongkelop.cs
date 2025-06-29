using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("THONGKELOP")]
public partial class Thongkelop
{
    [Key]
    [Column("id_Thongke")]
    public int IdThongke { get; set; }

    [Column("id_Lop")]
    public int? IdLop { get; set; }

    public int? TongHocVien { get; set; }

    public int? TrungBinhDiem { get; set; }

    public int? SoTren450 { get; set; }

    public int? SoTren600 { get; set; }

    [StringLength(500)]
    public string? NhanXet { get; set; }

    [StringLength(255)]
    public string? DotThiThu { get; set; }

    [ForeignKey("IdLop")]
    [InverseProperty("Thongkelops")]
    public virtual Lop? IdLopNavigation { get; set; }
}
