using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using ToeicCentre_Management.Models;

namespace ToeicCentre_Management.ViewModels
{
    public class DienDanCreateViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập tiêu đề")]
        [Display(Name = "Tiêu đề")]
        public string TieuDe { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập người tạo")]
        [Display(Name = "Người tạo")]
        public string NguoiTao { get; set; } = string.Empty;

        [Display(Name = "Tên người tạo")]
        public string TenNguoiTao { get; set; } = string.Empty;

        [Display(Name = "Ghi chú")]
        public string? GhiChu { get; set; }

        [Display(Name = "Mục đích")]
        public string? MucDich { get; set; }

        [Display(Name = "Nội dung")]
        public string? NoiDung { get; set; }

        [Display(Name = "Hình thức triển khai")]
        public string? HinhThucTrienKhai { get; set; }

        [Display(Name = "Lợi ích kỳ vọng")]
        public string? LoiIchKyVong { get; set; }

        [Display(Name = "Chọn bài viết")]
        public int[]? SelectedBaiviets { get; set; }

        public IEnumerable<SelectListItem> Baiviets { get; set; } = new List<SelectListItem>();
        public IEnumerable<SelectListItem> Giaoviens { get; set; } = new List<SelectListItem>();
    }

    public class DienDanEditViewModel
    {
        public int MaDd { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tiêu đề")]
        [Display(Name = "Tiêu đề")]
        public string TieuDe { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập người tạo")]
        [Display(Name = "Người tạo")]
        public string NguoiTao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng chọn trạng thái")]
        [Display(Name = "Trạng thái")]
        public string TrangThai { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng chọn hành động")]
        [Display(Name = "Hành động")]
        public string HanhDong { get; set; } = string.Empty;

        [Display(Name = "Ghi chú")]
        public string? GhiChu { get; set; }

        public IEnumerable<SelectListItem> TrangThaiOptions { get; set; } = new List<SelectListItem>();
        public IEnumerable<SelectListItem> HanhDongOptions { get; set; } = new List<SelectListItem>();
    }

    public class DienDanPreviewViewModel
    {
        public Dondenghitaodd? DonDeNghi { get; set; }
        public string TieuDe { get; set; } = string.Empty;
        public string NguoiTao { get; set; } = string.Empty;
        public string? GhiChu { get; set; }
        public int[]? SelectedBaiviets { get; set; }
    }
}