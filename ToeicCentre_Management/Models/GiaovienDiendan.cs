using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[PrimaryKey("MaDd", "MaGv")]
[Table("GIAOVIEN_DIENDAN")]
public partial class GiaovienDiendan
{
    [Key]
    [Column("MaDD")]
    public int MaDd { get; set; }

    [Key]
    [Column("MaGV")]
    public int MaGv { get; set; }

    [Column("TG_Tao", TypeName = "datetime")]
    public DateTime? TgTao { get; set; }

    [StringLength(25)]
    public string? TrangThai { get; set; }

    [ForeignKey("MaDd")]
    [InverseProperty("GiaovienDiendans")]
    public virtual Diendan MaDdNavigation { get; set; } = null!;

    [ForeignKey("MaGv")]
    [InverseProperty("GiaovienDiendans")]
    public virtual Giaovien MaGvNavigation { get; set; } = null!;
}
