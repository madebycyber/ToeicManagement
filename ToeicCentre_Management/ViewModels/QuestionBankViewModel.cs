using Microsoft.AspNetCore.Mvc.Rendering;
using ToeicCentre_Management.Models;

namespace ToeicCentre_Management.ViewModels
{
	public class QuestionBankViewModel
	{
		public IEnumerable<Cauhoi> Questions { get; set; }

		public IEnumerable<SelectListItem> Statuses { get; set; }
		public IEnumerable<SelectListItem> Parts { get; set; }
		public IEnumerable<SelectListItem> Skills { get; set; }
		public IEnumerable<SelectListItem> Difficulties { get; set; }

		public string? SearchKeyword { get; set; }
		public int? SelectedStatusId { get; set; }
		public int? SelectedPartId { get; set; }
		public int? SelectedSkillId { get; set; } // Thêm
		public int? SelectedDifficultyId { get; set; } // Thêm
	}
}