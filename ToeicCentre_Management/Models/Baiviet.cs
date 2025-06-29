using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("BAIVIET")]
public partial class Baiviet
{
    [Key]
    [Column("MaBV")]
    public int MaBv { get; set; }

    [Column("TenBV")]
    [StringLength(50)]
    public string? TenBv { get; set; }

    public string? NoiDung { get; set; }

    [Column("MaDD")]
    public int? MaDd { get; set; }

    public int? MaNguoiTao { get; set; }

    [ForeignKey("MaDd")]
    [InverseProperty("Baiviets")]
    public virtual Diendan? MaDdNavigation { get; set; }

    [ForeignKey("MaNguoiTao")]
    [InverseProperty("Baiviets")]
    public virtual Giaovien? MaNguoiTaoNavigation { get; set; }
}
