using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("DIEMTHI")]
public partial class Diemthi
{
    [Key]
    [Column("id_DiemThi")]
    public int IdDiemThi { get; set; }

    [Column("id_ThiThu")]
    public int? IdThiThu { get; set; }

    [Column("MaSV")]
    public int? MaSv { get; set; }

    public int? DiemPart1 { get; set; }

    public int? DiemPart2 { get; set; }

    public int? DiemPart3 { get; set; }

    public int? DiemPart4 { get; set; }

    public int? DiemPart5 { get; set; }

    public int? DiemPart6 { get; set; }

    public int? DiemPart7 { get; set; }

    public int? TongDiem { get; set; }

    [StringLength(10)]
    public string? Bac { get; set; }

    [ForeignKey("IdThiThu")]
    [InverseProperty("Diemthis")]
    public virtual Dangkythithu? IdThiThuNavigation { get; set; }

    [ForeignKey("MaSv")]
    [InverseProperty("Diemthis")]
    public virtual Sinhvien? MaSvNavigation { get; set; }
}
