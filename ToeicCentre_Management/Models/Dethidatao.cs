using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("DETHIDATAO")]
public partial class Dethidatao
{
    [Key]
    public int MaDeThi { get; set; }

    [StringLength(500)]
    public string? TenDeThi { get; set; }

    public int? MaLoaiDe { get; set; }

    public int? MaTrangThaiDeThi { get; set; }

    public string? MoTaDe { get; set; }

    [Column("ThoiGianLamBai_Phut")]
    public int? ThoiGianLamBaiPhut { get; set; }

    [StringLength(255)]
    public string? NguonGocThamKhao { get; set; }

    public int? NamThamKhao { get; set; }

    public int? DoKhoTongThe { get; set; }

    public string? Tags { get; set; }

    [StringLength(50)]
    public string? ChoPhepXemDapAn { get; set; }

    public bool? ChoPhepLamLai { get; set; }

    public int? SoLanLamLaiMax { get; set; }

    [Column("ID_GiaoVienTaoDe")]
    public int? IdGiaoVienTaoDe { get; set; }

    [Column("ID_SinhVienTaoDe")]
    public int? IdSinhVienTaoDe { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayTaoDe { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayXuatBan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayCapNhatCuoi { get; set; }

    [InverseProperty("MaDeThiNavigation")]
    public virtual ICollection<CauhoitrongDethi> CauhoitrongDethis { get; set; } = new List<CauhoitrongDethi>();

    [ForeignKey("IdGiaoVienTaoDe")]
    [InverseProperty("Dethidataos")]
    public virtual Giaovien? IdGiaoVienTaoDeNavigation { get; set; }

    [ForeignKey("IdSinhVienTaoDe")]
    [InverseProperty("Dethidataos")]
    public virtual Sinhvien? IdSinhVienTaoDeNavigation { get; set; }

    [ForeignKey("MaLoaiDe")]
    [InverseProperty("Dethidataos")]
    public virtual Loaidethi? MaLoaiDeNavigation { get; set; }

    [ForeignKey("MaTrangThaiDeThi")]
    [InverseProperty("Dethidataos")]
    public virtual Trangthaidethi? MaTrangThaiDeThiNavigation { get; set; }
}
