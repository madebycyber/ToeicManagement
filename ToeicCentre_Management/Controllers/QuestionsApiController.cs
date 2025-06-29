using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToeicCentre_Management.Models;
using System.ComponentModel.DataAnnotations;
using ToeicCentre_Management.Data; // Thêm using này

namespace ToeicCentre_Management.Controllers
{
	[Route("api/questions")]
	[ApiController]
	public class QuestionsApiController : ControllerBase
	{
		private readonly TOIECContext _context;

		public QuestionsApiController(TOIECContext context)
		{
			_context = context;
		}

		// GET: api/questions/{id}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetQuestionDetails(int id)
		{
			var question = await _context.Cauhois.AsNoTracking()
				.Include(q => q.Dapans)
				.Include(q => q.MaTtChNavigation)
				.Include(q => q.IdGiaoVienTaoChNavigation)
				.Include(q => q.Phanloaiches)
				.FirstOrDefaultAsync(q => q.MaCh == id);

			if (question == null)
			{
				return NotFound();
			}

			if (question.Phanloaiches.Any())
			{
				var pl = question.Phanloaiches.First();
				await _context.Entry(pl).Reference(p => p.MaPtNavigation).LoadAsync();
				await _context.Entry(pl).Reference(p => p.MaKnNavigation).LoadAsync();
				await _context.Entry(pl).Reference(p => p.MaMdkNavigation).LoadAsync();
			}

			var result = new
			{
				id = question.MaCh,
				questionText = question.NdCauHoi,
				explanation = question.GiaiThichDa,
				imagePath = question.PathHinhAnh,
				audioPath = question.PathAudioRieng,
				statusName = question.MaTtChNavigation?.TenTtCh ?? "N/A",
				creatorName = question.IdGiaoVienTaoChNavigation?.TenGiaoVien ?? "N/A",
				createdAt = question.NgayTaoCh,
				partName = question.Phanloaiches.FirstOrDefault()?.MaPtNavigation?.TenPt ?? "Chưa phân loại",
				skillName = question.Phanloaiches.FirstOrDefault()?.MaKnNavigation?.TenKn ?? "Chưa phân loại",
				difficultyName = question.Phanloaiches.FirstOrDefault()?.MaMdkNavigation?.TenMdk ?? "Chưa phân loại",
				answers = question.Dapans.Select(a => new
				{
					displayOrder = a.KyHieuDa,
					text = a.NdDapAn,
					isCorrect = a.LaDapAnDung
				}).OrderBy(a => a.displayOrder)
			};

			return Ok(result);
		}

		// DELETE: api/questions/{id}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteQuestion(int id)
		{
			var question = await _context.Cauhois.FindAsync(id);
			if (question == null) return NotFound();

			try
			{
				_context.Cauhois.Remove(question);
				await _context.SaveChangesAsync();
				return NoContent();
			}
			catch (DbUpdateException)
			{
				return BadRequest("Không thể xóa câu hỏi này vì nó đang được sử dụng trong một đề thi hoặc có lịch sử duyệt. Vui lòng kiểm tra lại.");
			}
		}

		// GET: api/questions/{id}/classification
		[HttpGet("{id}/classification")]
		public async Task<IActionResult> GetClassification(int id)
		{
			var classification = await _context.Phanloaiches.AsNoTracking().FirstOrDefaultAsync(p => p.MaCh == id);
			if (classification == null)
			{
				return Ok(new { skillId = "", partId = "", difficultyId = "" });
			}
			return Ok(new
			{
				skillId = classification.MaKn,
				partId = classification.MaPt,
				difficultyId = classification.MaMdk
			});
		}

		// POST: api/questions/classify
		[HttpPost("classify")]
		public async Task<IActionResult> ClassifyQuestion([FromBody] ClassificationModel model)
		{
			if (!ModelState.IsValid) return BadRequest(ModelState);

			var partInfo = await _context.Phanthis.FindAsync(model.PartId);
			if (partInfo == null) return BadRequest("Part ID không hợp lệ.");

			var classification = await _context.Phanloaiches.FirstOrDefaultAsync(p => p.MaCh == model.QuestionId);
			if (classification == null)
			{
				classification = new Phanloaich { MaCh = model.QuestionId };
				_context.Phanloaiches.Add(classification);
			}

			classification.MaPt = model.PartId;
			classification.MaMdk = model.DifficultyId;
			classification.MaKn = partInfo.MaKn.HasValue ? partInfo.MaKn.Value : 0;


            await _context.SaveChangesAsync();
			return Ok(new { message = "Phân loại thành công!" });
		}

		// POST: api/questions/approve
		[HttpPost("approve")]
		public async Task<IActionResult> ApproveQuestion([FromBody] ApprovalModel model)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var question = await _context.Cauhois
										 .Include(q => q.MaTtChNavigation)
										 .FirstOrDefaultAsync(q => q.MaCh == model.QuestionId);

			if (question == null)
			{
				return NotFound(new { message = "Không tìm thấy câu hỏi." });
			}

			var oldStatusId = question.MaTtCh;

			var newStatus = await _context.Trangthaiches
										  .FirstOrDefaultAsync(ts => ts.TenTtCh == model.NewStatus);

			if (newStatus == null)
			{
				return BadRequest(new { message = $"Trạng thái '{model.NewStatus}' không hợp lệ." });
			}

			question.MaTtCh = newStatus.MaTtCh;
			question.NgayDuyetCh = DateOnly.FromDateTime(DateTime.UtcNow);
			question.IdNguoiDuyetCh = 1; // Giả sử admin có ID là 1

			var history = new Lichsuduyetch
			{
				MaCh = question.MaCh,
				IdNguoiDuyetLs = 1, // Giả sử admin có ID là 1
				MaTtTruoc = oldStatusId,
				MaTtSau = newStatus.MaTtCh,
				GhiChuDuyet = model.Comment,
				ThoiDiemDuyet = DateTime.UtcNow
			};
			_context.Lichsuduyetches.Add(history);

			await _context.SaveChangesAsync();

			return Ok(new
			{
				message = $"Đã cập nhật trạng thái thành công sang '{newStatus.TenTtCh}'.",
				newStatusName = newStatus.TenTtCh
			});
		}

		// Model để nhận dữ liệu từ JS
		public class ClassificationModel
		{
			public int QuestionId { get; set; }
			public int PartId { get; set; }
			public int DifficultyId { get; set; }
		}

		public class ApprovalModel
		{
			[Required]
			public int QuestionId { get; set; }
			[Required]
			public string NewStatus { get; set; }
			public string? Comment { get; set; }
		}
	}
}