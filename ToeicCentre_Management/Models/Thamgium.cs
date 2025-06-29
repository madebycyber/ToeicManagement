using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[PrimaryKey("MaDd", "MaSv")]
[Table("THAMGIA")]
public partial class Thamgium
{
    [Key]
    [Column("MaDD")]
    public int MaDd { get; set; }

    [Key]
    [Column("MaSV")]
    public int MaSv { get; set; }

    [Column("TGThamGia", TypeName = "datetime")]
    public DateTime? TgthamGia { get; set; }

    [ForeignKey("MaDd")]
    [InverseProperty("Thamgia")]
    public virtual Diendan MaDdNavigation { get; set; } = null!;

    [ForeignKey("MaSv")]
    [InverseProperty("Thamgia")]
    public virtual Sinhvien MaSvNavigation { get; set; } = null!;
}
