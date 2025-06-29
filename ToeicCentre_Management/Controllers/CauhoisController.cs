using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToeicCentre_Management.Data;
using ToeicCentre_Management.Models;
using ToeicCentre_Management.ViewModels;

namespace ToeicCentre_Management.Controllers
{
    public class CauhoisController : Controller
    {
        private readonly TOIECContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CauhoisController(TOIECContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // Action hiển thị danh sách câu hỏi và xử lý lọc
        public async Task<IActionResult> Index(QuestionBankViewModel vm)
        {
            IQueryable<Cauhoi> query = _context.Cauhois.AsNoTracking()
                                            .Include(q => q.MaTtChNavigation)
                                            .Include(q => q.IdGiaoVienTaoChNavigation)
                                            .Include(q => q.Phanloaiches)
                                                .ThenInclude(pl => pl.MaPtNavigation)
                                            .Include(q => q.Phanloaiches)
                                                .ThenInclude(pl => pl.MaKnNavigation)
                                            .Include(q => q.Phanloaiches)
                                                .ThenInclude(pl => pl.MaMdkNavigation);

            if (!string.IsNullOrEmpty(vm.SearchKeyword))
            {
                var keyword = vm.SearchKeyword.ToLower();
                query = query.Where(q =>
                    (q.NdCauHoi != null && q.NdCauHoi.ToLower().Contains(keyword)) ||
                    (q.GiaiThichDa != null && q.GiaiThichDa.ToLower().Contains(keyword)) ||
                    (q.IdGiaoVienTaoChNavigation != null && q.IdGiaoVienTaoChNavigation.TenGiaoVien.ToLower().Contains(keyword)) ||
                    (q.MaTtChNavigation != null && q.MaTtChNavigation.TenTtCh.ToLower().Contains(keyword)) ||
                    q.Phanloaiches.Any(pl =>
                        (pl.MaPtNavigation != null && pl.MaPtNavigation.TenPt != null && pl.MaPtNavigation.TenPt.ToLower().Contains(keyword)) ||
                        (pl.MaKnNavigation != null && pl.MaKnNavigation.TenKn != null && pl.MaKnNavigation.TenKn.ToLower().Contains(keyword)) ||
                        (pl.MaMdkNavigation != null && pl.MaMdkNavigation.TenMdk != null && pl.MaMdkNavigation.TenMdk.ToLower().Contains(keyword))
                    )
                );
            }

            if (vm.SelectedStatusId.HasValue)
            {
                query = query.Where(q => q.MaTtCh == vm.SelectedStatusId.Value);
            }
            if (vm.SelectedPartId.HasValue)
            {
                query = query.Where(q => q.Phanloaiches.Any(pl => pl.MaPt == vm.SelectedPartId.Value));
            }
            if (vm.SelectedSkillId.HasValue)
            {
                query = query.Where(q => q.Phanloaiches.Any(pl => pl.MaKn == vm.SelectedSkillId.Value));
            }
            if (vm.SelectedDifficultyId.HasValue)
            {
                query = query.Where(q => q.Phanloaiches.Any(pl => pl.MaMdk == vm.SelectedDifficultyId.Value));
            }

            var viewModel = new QuestionBankViewModel
            {
                Questions = await query.ToListAsync(),
                Statuses = new SelectList(await _context.Trangthaiches.AsNoTracking().ToListAsync(), "MaTtCh", "TenTtCh", vm.SelectedStatusId),
                Parts = new SelectList(await _context.Phanthis.AsNoTracking().ToListAsync(), "MaPt", "TenPt", vm.SelectedPartId),
                Skills = new SelectList(await _context.Kynangs.AsNoTracking().ToListAsync(), "MaKn", "TenKn", vm.SelectedSkillId),
                Difficulties = new SelectList(await _context.Mucdokhos.AsNoTracking().ToListAsync(), "MaMdk", "TenMdk", vm.SelectedDifficultyId),
                SearchKeyword = vm.SearchKeyword,
                SelectedStatusId = vm.SelectedStatusId,
                SelectedPartId = vm.SelectedPartId,
                SelectedSkillId = vm.SelectedSkillId,
                SelectedDifficultyId = vm.SelectedDifficultyId
            };

            return View(viewModel);
        }

        // GET: QuestionBank/Create
        public async Task<IActionResult> Create()
        {
            var viewModel = new QuestionFormViewModel
            {
                Parts = new SelectList(await _context.Phanthis.AsNoTracking().ToListAsync(), "MaPt", "TenPt")
            };
            return View("QuestionForm", viewModel);
        }

        // GET: QuestionBank/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var question = await _context.Cauhois
                                         .Include(q => q.Dapans)
                                         .Include(q => q.Phanloaiches)
                                         .FirstOrDefaultAsync(q => q.MaCh == id);

            if (question == null)
            {
                return NotFound();
            }

            var viewModel = new QuestionFormViewModel
            {
                Id = question.MaCh,
                QuestionContent = question.NdCauHoi,
                Explanation = question.GiaiThichDa,
                ExistingImagePath = question.PathHinhAnh,
                ExistingAudioPath = question.PathAudioRieng,
                SelectedPartId = question.Phanloaiches.FirstOrDefault()?.MaPt,
                AnswerA = question.Dapans.FirstOrDefault(a => a.KyHieuDa == "A")?.NdDapAn,
                AnswerB = question.Dapans.FirstOrDefault(a => a.KyHieuDa == "B")?.NdDapAn,
                AnswerC = question.Dapans.FirstOrDefault(a => a.KyHieuDa == "C")?.NdDapAn,
                AnswerD = question.Dapans.FirstOrDefault(a => a.KyHieuDa == "D")?.NdDapAn,
                CorrectAnswerKey = question.Dapans.FirstOrDefault(a => a.LaDapAnDung == true)?.KyHieuDa,
                Parts = new SelectList(await _context.Phanthis.AsNoTracking().ToListAsync(), "MaPt", "TenPt", question.Phanloaiches.FirstOrDefault()?.MaPt)
            };

            return View("QuestionForm", viewModel);
        }

        // POST: QuestionBank/Save
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(QuestionFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Parts = new SelectList(await _context.Phanthis.AsNoTracking().ToListAsync(), "MaPt", "TenPt", viewModel.SelectedPartId);
                return View("QuestionForm", viewModel);
            }

            var currentUserId = 1;

            var question = viewModel.Id > 0
                ? await _context.Cauhois.Include(q => q.Dapans).FirstOrDefaultAsync(q => q.MaCh == viewModel.Id)
                : new Cauhoi();

            if (question == null) return NotFound();

            if (viewModel.CreateNewGroup && (viewModel.GroupPassageText != null || viewModel.GroupAudioFile != null))
            {
                var newGroup = new Nhomch
                {
                    NdDoanVan = viewModel.GroupPassageText,
                    IdGiaoVienTao = currentUserId,
                    MaPt = viewModel.SelectedPartId.HasValue ? viewModel.SelectedPartId.Value : 0 // Kiểm tra nullable
                };
                if (viewModel.GroupAudioFile != null)
                {
                    newGroup.PathAudioNhom = await SaveFile(viewModel.GroupAudioFile);
                }
                _context.Nhomches.Add(newGroup);
                question.MaNhomChNavigation = newGroup;
            }

            question.NdCauHoi = viewModel.QuestionContent;
            question.GiaiThichDa = viewModel.Explanation;
            question.SttTrongNhom = viewModel.OrderInGroup;

            if (viewModel.ImageFile != null)
            {
                question.PathHinhAnh = await SaveFile(viewModel.ImageFile);
            }
            if (viewModel.AudioFile != null)
            {
                question.PathAudioRieng = await SaveFile(viewModel.AudioFile);
            }

            if (viewModel.Id == 0) // Tạo mới
            {
                question.IdGiaoVienTaoCh = currentUserId;
                question.MaTtCh = 1; // 1 = Chờ duyệt
                question.NgayTaoCh = DateOnly.FromDateTime(DateTime.UtcNow); // Sử dụng DateOnly
                _context.Cauhois.Add(question);
            }
            else // Cập nhật
            {
                question.NgayCapNhatCh = DateOnly.FromDateTime(DateTime.UtcNow); // Sử dụng DateOnly
            }

            UpdateAnswers(question, viewModel);
            await _context.SaveChangesAsync();

            // Chỉ tạo phân loại khi là câu hỏi mới
            if (viewModel.Id == 0 && viewModel.SelectedPartId.HasValue)
            {
                var partInfo = await _context.Phanthis.AsNoTracking().FirstOrDefaultAsync(p => p.MaPt == viewModel.SelectedPartId.Value);
                if (partInfo != null)
                {
                    var classification = new Phanloaich
                    {
                        MaCh = question.MaCh,
                        MaPt = viewModel.SelectedPartId.Value,
                        MaKn = partInfo.MaKn.HasValue ? partInfo.MaKn.Value : 0,
                        MaMdk = 2 // Tạm gán mức độ Trung bình
                    };
                    _context.Phanloaiches.Add(classification);
                    await _context.SaveChangesAsync();
                }
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = Path.GetFileName(file.FileName);
            var uniqueFileName = $"{Guid.NewGuid()}_{originalFileName}";
            var uploadsRootFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads");
            var uploadsQuestionFolder = Path.Combine(uploadsRootFolder, "questions");

            if (!Directory.Exists(uploadsQuestionFolder))
            {
                Directory.CreateDirectory(uploadsQuestionFolder);
            }

            var filePath = Path.Combine(uploadsQuestionFolder, uniqueFileName);

            await using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Path.Combine("uploads", "questions", uniqueFileName).Replace('\\', '/');
        }

        private void UpdateAnswers(Cauhoi question, QuestionFormViewModel viewModel)
        {
            question.Dapans.Clear();
            question.Dapans.Add(new Dapan
            {
                KyHieuDa = "A",
                NdDapAn = viewModel.AnswerA,
                LaDapAnDung = viewModel.CorrectAnswerKey != null && viewModel.CorrectAnswerKey == "A"
            });
            question.Dapans.Add(new Dapan
            {
                KyHieuDa = "B",
                NdDapAn = viewModel.AnswerB,
                LaDapAnDung = viewModel.CorrectAnswerKey != null && viewModel.CorrectAnswerKey == "B"
            });
            question.Dapans.Add(new Dapan
            {
                KyHieuDa = "C",
                NdDapAn = viewModel.AnswerC,
                LaDapAnDung = viewModel.CorrectAnswerKey != null && viewModel.CorrectAnswerKey == "C"
            });

            if (viewModel.SelectedPartId != 2) // Part 2 không có đáp án D
            {
                question.Dapans.Add(new Dapan
                {
                    KyHieuDa = "D",
                    NdDapAn = viewModel.AnswerD,
                    LaDapAnDung = viewModel.CorrectAnswerKey != null && viewModel.CorrectAnswerKey == "D"
                });
            }
        }
    }
}