using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToeicCentre_Management.Models;

[Table("CAUHOI")]
public partial class Cauhoi
{
    [Key]
    [Column("MaCH")]
    public int MaCh { get; set; }

    [Column("MaNhomCH")]
    public int? MaNhomCh { get; set; }

    [Column("ND_CauHoi")]
    public string? NdCauHoi { get; set; }

    [Column("Path_AudioRieng")]
    [StringLength(500)]
    public string? PathAudioRieng { get; set; }

    [Column("Path_HinhAnh")]
    [StringLength(500)]
    public string? PathHinhAnh { get; set; }

    [Column("GiaiThichDA")]
    public string? GiaiThichDa { get; set; }

    [Column("MaTT_CH")]
    public int? MaTtCh { get; set; }

    [Column("ID_GiaoVienTaoCH")]
    public int? IdGiaoVienTaoCh { get; set; }

    [Column("ID_NguoiDuyetCH")]
    public int? IdNguoiDuyetCh { get; set; }

    [Column("STT_TrongNhom")]
    public int? SttTrongNhom { get; set; }

    [Column("NgayTaoCH")]
    public DateOnly? NgayTaoCh { get; set; }

    [Column("NgayDuyetCH")]
    public DateOnly? NgayDuyetCh { get; set; }

    [Column("NgayCapNhatCH")]
    public DateOnly? NgayCapNhatCh { get; set; }

    [InverseProperty("MaChNavigation")]
    public virtual ICollection<Cauhoibaitap> Cauhoibaitaps { get; set; } = new List<Cauhoibaitap>();

    [InverseProperty("MaChNavigation")]
    public virtual ICollection<CauhoitrongDethi> CauhoitrongDethis { get; set; } = new List<CauhoitrongDethi>();

    [InverseProperty("MaChNavigation")]
    public virtual ICollection<DDethi> DDethis { get; set; } = new List<DDethi>();

    [InverseProperty("MaChNavigation")]
    public virtual ICollection<Dapan> Dapans { get; set; } = new List<Dapan>();

    [ForeignKey("IdGiaoVienTaoCh")]
    [InverseProperty("Cauhois")]
    public virtual Giaovien? IdGiaoVienTaoChNavigation { get; set; }

    [ForeignKey("IdNguoiDuyetCh")]
    [InverseProperty("Cauhois")]
    public virtual Kiemduyetvien? IdNguoiDuyetChNavigation { get; set; }

    [InverseProperty("MaChNavigation")]
    public virtual ICollection<Lichsuduyetch> Lichsuduyetches { get; set; } = new List<Lichsuduyetch>();

    [ForeignKey("MaNhomCh")]
    [InverseProperty("Cauhois")]
    public virtual Nhomch? MaNhomChNavigation { get; set; }

    [ForeignKey("MaTtCh")]
    [InverseProperty("Cauhois")]
    public virtual Trangthaich? MaTtChNavigation { get; set; }

    [InverseProperty("MaChNavigation")]
    public virtual ICollection<Phanloaich> Phanloaiches { get; set; } = new List<Phanloaich>();
}
