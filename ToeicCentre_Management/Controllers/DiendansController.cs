using System;
using System.Collections.Generic;
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
    public class DiendansController : Controller
    {
        private readonly TOIECContext _context;

        public DiendansController(TOIECContext context)
        {
            _context = context;
        }

        // GET: Diendans
        public async Task<IActionResult> Index()
        {
            var diendans = _context.Diendans
                .Include(d => d.MaDdnNavigation)
                .Include(d => d.Baiviets)
                .Include(d => d.GiaovienDiendans)
                    .ThenInclude(gd => gd.MaGvNavigation);

            return View(await diendans.ToListAsync());
        }

        // GET: Diendans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diendan = await _context.Diendans
                .Include(d => d.MaDdnNavigation)
                .Include(d => d.Baiviets)
                .Include(d => d.GiaovienDiendans)
                    .ThenInclude(gd => gd.MaGvNavigation)
                .FirstOrDefaultAsync(m => m.MaDd == id);

            if (diendan == null)
            {
                return NotFound();
            }

            return View(diendan);
        }

        // GET: Diendans/Create
        public IActionResult Create()
        {
            var viewModel = new DienDanCreateViewModel
            {
                Baiviets = new SelectList(_context.Baiviets.ToList(), "MaBv", "TenBv"),
                Giaoviens = new SelectList(_context.Giaoviens.ToList(), "MaGv", "TenGiaoVien")
            };
            return View(viewModel);
        }

        // POST: Diendans/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DienDanCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Tạo đơn đề nghị trước
                var donDeNghi = new Dondenghitaodd
                {
                    TenNguoiDn = viewModel.TenNguoiTao,
                    ChucVu = "Giảng viên",
                    DonVi = "Khoa Ngoại ngữ",
                    NgayVietDon = DateOnly.FromDateTime(DateTime.Now),
                    TenDienDanDeXuat = viewModel.TieuDe,
                    MucDich = viewModel.MucDich,
                    NoiDung = viewModel.NoiDung,
                    HinhThucTrienKhai = viewModel.HinhThucTrienKhai,
                    LoiIchKyVong = viewModel.LoiIchKyVong
                };

                _context.Dondenghitaodds.Add(donDeNghi);
                await _context.SaveChangesAsync();

                // Truyền dữ liệu để preview
                var previewData = new DienDanPreviewViewModel
                {
                    DonDeNghi = donDeNghi,
                    TieuDe = viewModel.TieuDe,
                    NguoiTao = viewModel.NguoiTao,
                    GhiChu = viewModel.GhiChu,
                    SelectedBaiviets = viewModel.SelectedBaiviets
                };

                return View("Preview", previewData);
            }

            viewModel.Baiviets = new SelectList(_context.Baiviets.ToList(), "MaBv", "TenBv", viewModel.SelectedBaiviets);
            viewModel.Giaoviens = new SelectList(_context.Giaoviens.ToList(), "MaGv", "TenGiaoVien", viewModel.NguoiTao);
            return View(viewModel);
        }

        // POST: Diendans/ConfirmCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmCreate(DienDanPreviewViewModel previewData)
        {
            if (previewData.DonDeNghi?.MaDdn != null)
            {
                // Tạo diễn đàn
                var diendan = new Diendan
                {
                    TieuDe = previewData.TieuDe,
                    NguoiTao = previewData.NguoiTao,
                    SoBaiViet = previewData.SelectedBaiviets?.Length ?? 0,
                    TrangThai = "Chờ duyệt",
                    HanhDong = "Mở",
                    GhiChu = previewData.GhiChu,
                    MaDdn = previewData.DonDeNghi.MaDdn
                };

                _context.Diendans.Add(diendan);
                await _context.SaveChangesAsync();

                // Tạo quan hệ giáo viên - diễn đàn
                if (!string.IsNullOrEmpty(previewData.NguoiTao))
                {
                    var giaovien = await _context.Giaoviens
                        .FirstOrDefaultAsync(g => g.TenGiaoVien == previewData.NguoiTao);

                    if (giaovien != null)
                    {
                        var gvDiendan = new GiaovienDiendan
                        {
                            MaDd = diendan.MaDd,
                            MaGv = giaovien.MaGv,
                            TgTao = DateTime.Now,
                            TrangThai = "Hoạt động"
                        };
                        _context.GiaovienDiendans.Add(gvDiendan);
                    }
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }

        // GET: Diendans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diendan = await _context.Diendans
                .Include(d => d.MaDdnNavigation)
                .FirstOrDefaultAsync(d => d.MaDd == id);

            if (diendan == null)
            {
                return NotFound();
            }

            var viewModel = new DienDanEditViewModel
            {
                MaDd = diendan.MaDd,
                TieuDe = diendan.TieuDe,
                NguoiTao = diendan.NguoiTao,
                TrangThai = diendan.TrangThai,
                HanhDong = diendan.HanhDong,
                GhiChu = diendan.GhiChu,
                TrangThaiOptions = new SelectList(new[]
                {
                    new { Value = "Chờ duyệt", Text = "Chờ duyệt" },
                    new { Value = "Đã duyệt", Text = "Đã duyệt" },
                    new { Value = "Từ chối", Text = "Từ chối" }
                }, "Value", "Text", diendan.TrangThai),
                HanhDongOptions = new SelectList(new[]
                {
                    new { Value = "Mở", Text = "Mở" },
                    new { Value = "Đóng", Text = "Đóng" }
                }, "Value", "Text", diendan.HanhDong)
            };

            return View(viewModel);
        }

        // POST: Diendans/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, DienDanEditViewModel viewModel)
        {
            if (id != viewModel.MaDd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var diendan = await _context.Diendans.FindAsync(id);
                    if (diendan == null)
                    {
                        return NotFound();
                    }

                    diendan.TieuDe = viewModel.TieuDe;
                    diendan.NguoiTao = viewModel.NguoiTao;
                    diendan.TrangThai = viewModel.TrangThai;
                    diendan.HanhDong = viewModel.HanhDong;
                    diendan.GhiChu = viewModel.GhiChu;

                    _context.Update(diendan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DienDanExists(viewModel.MaDd))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            viewModel.TrangThaiOptions = new SelectList(new[]
            {
                new { Value = "Chờ duyệt", Text = "Chờ duyệt" },
                new { Value = "Đã duyệt", Text = "Đã duyệt" },
                new { Value = "Từ chối", Text = "Từ chối" }
            }, "Value", "Text", viewModel.TrangThai);

            viewModel.HanhDongOptions = new SelectList(new[]
            {
                new { Value = "Mở", Text = "Mở" },
                new { Value = "Đóng", Text = "Đóng" }
            }, "Value", "Text", viewModel.HanhDong);

            return View(viewModel);
        }

        // GET: Diendans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diendan = await _context.Diendans
                .Include(d => d.MaDdnNavigation)
                .Include(d => d.Baiviets)
                .FirstOrDefaultAsync(m => m.MaDd == id);

            if (diendan == null)
            {
                return NotFound();
            }

            return View(diendan);
        }

        // POST: Diendans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diendan = await _context.Diendans
                .Include(d => d.GiaovienDiendans)
                .Include(d => d.Baiviets)
                .FirstOrDefaultAsync(d => d.MaDd == id);

            if (diendan != null)
            {
                // Xóa các quan hệ trước
                _context.GiaovienDiendans.RemoveRange(diendan.GiaovienDiendans);
                _context.Baiviets.RemoveRange(diendan.Baiviets);

                // Xóa diễn đàn
                _context.Diendans.Remove(diendan);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool DienDanExists(int id)
        {
            return _context.Diendans.Any(e => e.MaDd == id);
        }
    }
}