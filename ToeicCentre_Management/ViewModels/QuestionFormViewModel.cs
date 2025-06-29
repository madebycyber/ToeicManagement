using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ToeicCentre_Management.ViewModels
{
	public class QuestionFormViewModel
	{
		public int Id { get; set; } // Sẽ bằng 0 nếu là thêm mới, > 0 nếu là sửa

		// ==== Phần chọn Part ====
		[Required(ErrorMessage = "Vui lòng chọn một phần thi.")]
		[Display(Name = "Phần thi (Part)")]
		public int? SelectedPartId { get; set; }

		// ==== Phần chọn/tạo nhóm ====
		public bool CreateNewGroup { get; set; } = true; // Mặc định là tạo nhóm mới

		[Display(Name = "Chọn nhóm có sẵn")]
		public int? ExistingGroupId { get; set; }

		// ==== Phần nhóm câu hỏi ====
		[Display(Name = "Nội dung đoạn văn (Part 6, 7)")]
		public string? GroupPassageText { get; set; }
		[Display(Name = "Kịch bản hội thoại (Part 3, 4)")]
		public string? GroupTranscript { get; set; }
		[Display(Name = "Audio cho nhóm")]
		public IFormFile? GroupAudioFile { get; set; }
		[Display(Name = "Thứ tự trong nhóm")]
		public int? OrderInGroup { get; set; }

		// ==== Phần câu hỏi riêng lẻ ====
		[Display(Name = "Hình ảnh (Part 1)")]
		public IFormFile? ImageFile { get; set; }
		[Display(Name = "Audio riêng (Part 2, 3, 4)")]
		public IFormFile? AudioFile { get; set; }

		[Display(Name = "Nội dung câu hỏi")]
		public string? QuestionContent { get; set; }

		// ==== Phần đáp án ====
		[Required]
		public string AnswerA { get; set; }
		[Required]
		public string AnswerB { get; set; }
		[Required]
		public string AnswerC { get; set; }
		public string? AnswerD { get; set; } // Không bắt buộc cho Part 2

		[Required(ErrorMessage = "Vui lòng chọn đáp án đúng.")]
		public string CorrectAnswerKey { get; set; } // 'A', 'B', 'C', 'D'

		[Display(Name = "Giải thích đáp án")]
		public string? Explanation { get; set; }

		// --- Dữ liệu để hiển thị trên form ---
		public IEnumerable<SelectListItem> Parts { get; set; } = new List<SelectListItem>();

		// --- Thuộc tính để hiển thị đường dẫn file cũ khi edit ---
		public string? ExistingImagePath { get; set; }
		public string? ExistingAudioPath { get; set; }
	}
}