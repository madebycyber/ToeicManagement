using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("DANGKYONLUYEN")]
public partial class Dangkyonluyen
{
    [Key]
    [Column("id_OnLuyen")]
    public int IdOnLuyen { get; set; }

    [Column("MaSV")]
    public int? MaSv { get; set; }

    [Column("id_Lop")]
    public int? IdLop { get; set; }

    [StringLength(25)]
    public string? TrinhDoHienTai { get; set; }

    public int? DiemToiecMucTieu { get; set; }

    [StringLength(255)]
    public string? HinhThucHoc { get; set; }

    [StringLength(500)]
    public string? GhiChu { get; set; }

    [ForeignKey("IdLop")]
    [InverseProperty("Dangkyonluyens")]
    public virtual Lop? IdLopNavigation { get; set; }

    [ForeignKey("MaSv")]
    [InverseProperty("Dangkyonluyens")]
    public virtual Sinhvien? MaSvNavigation { get; set; }
}
