using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToeicCentre_Management.Data;
using ToeicCentre_Management.Models;

namespace ToeicCentre_Management.Controllers
{
    public class PhieubaitaponluyensController : Controller
    {
        private readonly TOIECContext _context;

        public PhieubaitaponluyensController(TOIECContext context)
        {
            _context = context;
        }

        // GET: Phieubaitaponluyens
        public async Task<IActionResult> Index()
        {
            var tOIECContext = _context.Phieubaitaponluyens
                .Include(p => p.MaSvNavigation)
                .Include(p => p.Cauhoibaitaps).ThenInclude(c => c.MaChNavigation);
            ViewBag.Sinhviens = await _context.Sinhviens
                .Select(s => new { s.MaSv, HoTen = $"{s.MaSv} - {s.HoTenSv}" })
                .ToListAsync();
            ViewBag.CauHois = await _context.Cauhois.ToListAsync();
            // Truyền danh sách MaCh đã chọn cho mỗi phiếu bài tập
            var selectedCauHoiIds = await _context.Cauhoibaitaps
                .GroupBy(c => c.IdPhieuBaiTap)
                .ToDictionaryAsync(g => g.Key, g => g.Select(c => c.MaCh).ToList());
            ViewBag.SelectedCauHoiIds = selectedCauHoiIds;
            return View(await tOIECContext.ToListAsync());
        }

        // GET: Phieubaitaponluyens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieubaitaponluyen = await _context.Phieubaitaponluyens
                .Include(p => p.MaSvNavigation)
                .Include(p => p.Cauhoibaitaps).ThenInclude(c => c.MaChNavigation)
                .FirstOrDefaultAsync(m => m.IdPhieuBaiTap == id);
            if (phieubaitaponluyen == null)
            {
                return NotFound();
            }

            return View(phieubaitaponluyen);
        }

        // GET: Phieubaitaponluyens/Create
        public IActionResult Create()
        {
            ViewBag.Sinhviens = new SelectList(
                _context.Sinhviens.Select(s => new { s.MaSv, HoTen = $"{s.MaSv} - {s.HoTenSv}" }),
                "MaSv",
                "HoTen"
            );
            ViewBag.CauHois = _context.Cauhois.ToList();
            return View();
        }

        // POST: Phieubaitaponluyens/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPhieuBaiTap,MaSv,Lop,DangCauHoi,ThoiGianGiao,ThoiGianNop,DiemSo,NhanXet")] Phieubaitaponluyen phieubaitaponluyen, int[] CauHoiIds)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phieubaitaponluyen);
                await _context.SaveChangesAsync();

                // Add linked questions to CAUHOIBAITAP
                if (CauHoiIds != null && CauHoiIds.Length > 0)
                {
                    foreach (var cauHoiId in CauHoiIds)
                    {
                        _context.Cauhoibaitaps.Add(new Cauhoibaitap
                        {
                            IdPhieuBaiTap = phieubaitaponluyen.IdPhieuBaiTap,
                            MaCh = cauHoiId
                        });
                    }
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }
            ViewBag.Sinhviens = new SelectList(
                _context.Sinhviens.Select(s => new { s.MaSv, HoTen = $"{s.MaSv} - {s.HoTenSv}" }),
                "MaSv",
                "HoTen",
                phieubaitaponluyen.MaSv
            );
            ViewBag.CauHois = _context.Cauhois.ToList();
            return View(phieubaitaponluyen);
        }

        // GET: Phieubaitaponluyens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieubaitaponluyen = await _context.Phieubaitaponluyens
                .Include(p => p.Cauhoibaitaps)
                .FirstOrDefaultAsync(m => m.IdPhieuBaiTap == id);
            if (phieubaitaponluyen == null)
            {
                return NotFound();
            }
            ViewBag.Sinhviens = new SelectList(
                _context.Sinhviens.Select(s => new { s.MaSv, HoTen = $"{s.MaSv} - {s.HoTenSv}" }),
                "MaSv",
                "HoTen",
                phieubaitaponluyen.MaSv
            );
            ViewBag.CauHois = _context.Cauhois.ToList();
            ViewBag.SelectedCauHoiIds = phieubaitaponluyen.Cauhoibaitaps.Select(c => c.MaCh).ToList();
            return View(phieubaitaponluyen);
        }

        // POST: Phieubaitaponluyens/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPhieuBaiTap,MaSv,Lop,DangCauHoi,ThoiGianGiao,ThoiGianNop,DiemSo,NhanXet")] Phieubaitaponluyen phieubaitaponluyen, int[] CauHoiIds)
        {
            if (id != phieubaitaponluyen.IdPhieuBaiTap)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phieubaitaponluyen);
                    // Update linked questions in CAUHOIBAITAP
                    var existingCauHois = _context.Cauhoibaitaps.Where(c => c.IdPhieuBaiTap == id).ToList();
                    _context.Cauhoibaitaps.RemoveRange(existingCauHois);
                    if (CauHoiIds != null && CauHoiIds.Length > 0)
                    {
                        foreach (var cauHoiId in CauHoiIds)
                        {
                            _context.Cauhoibaitaps.Add(new Cauhoibaitap
                            {
                                IdPhieuBaiTap = phieubaitaponluyen.IdPhieuBaiTap,
                                MaCh = cauHoiId
                            });
                        }
                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhieubaitaponluyenExists(phieubaitaponluyen.IdPhieuBaiTap))
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
            ViewBag.Sinhviens = new SelectList(
                _context.Sinhviens.Select(s => new { s.MaSv, HoTen = $"{s.MaSv} - {s.HoTenSv}" }),
                "MaSv",
                "HoTen",
                phieubaitaponluyen.MaSv
            );
            ViewBag.CauHois = _context.Cauhois.ToList();
            ViewBag.SelectedCauHoiIds = phieubaitaponluyen.Cauhoibaitaps.Select(c => c.MaCh).ToList();
            return View(phieubaitaponluyen);
        }

        // GET: Phieubaitaponluyens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieubaitaponluyen = await _context.Phieubaitaponluyens
                .Include(p => p.MaSvNavigation)
                .Include(p => p.Cauhoibaitaps)
                .FirstOrDefaultAsync(m => m.IdPhieuBaiTap == id);
            if (phieubaitaponluyen == null)
            {
                return NotFound();
            }

            return View(phieubaitaponluyen);
        }

        // POST: Phieubaitaponluyens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phieubaitaponluyen = await _context.Phieubaitaponluyens
                .Include(p => p.Cauhoibaitaps)
                .FirstOrDefaultAsync(p => p.IdPhieuBaiTap == id);
            if (phieubaitaponluyen != null)
            {
                _context.Cauhoibaitaps.RemoveRange(phieubaitaponluyen.Cauhoibaitaps);
                _context.Phieubaitaponluyens.Remove(phieubaitaponluyen);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool PhieubaitaponluyenExists(int id)
        {
            return _context.Phieubaitaponluyens.Any(e => e.IdPhieuBaiTap == id);
        }
    }
}