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
    public class CauhoibaitapsController : Controller
    {
        private readonly TOIECContext _context;

        public CauhoibaitapsController(TOIECContext context)
        {
            _context = context;
        }

        // GET: Cauhoibaitaps
        public async Task<IActionResult> Index()
        {
            var tOIECContext = _context.Cauhoibaitaps.Include(c => c.IdPhieuBaiTapNavigation).Include(c => c.MaChNavigation);
            return View(await tOIECContext.ToListAsync());
        }

        // GET: Cauhoibaitaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauhoibaitap = await _context.Cauhoibaitaps
                .Include(c => c.IdPhieuBaiTapNavigation)
                .Include(c => c.MaChNavigation)
                .FirstOrDefaultAsync(m => m.IdBaiTap == id);
            if (cauhoibaitap == null)
            {
                return NotFound();
            }

            return View(cauhoibaitap);
        }

        // GET: Cauhoibaitaps/Create
        public IActionResult Create()
        {
            ViewData["IdPhieuBaiTap"] = new SelectList(_context.Phieubaitaponluyens, "IdPhieuBaiTap", "IdPhieuBaiTap");
            ViewData["MaCh"] = new SelectList(_context.Cauhois, "MaCh", "MaCh");
            return View();
        }

        // POST: Cauhoibaitaps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBaiTap,IdPhieuBaiTap,MaCh")] Cauhoibaitap cauhoibaitap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cauhoibaitap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPhieuBaiTap"] = new SelectList(_context.Phieubaitaponluyens, "IdPhieuBaiTap", "IdPhieuBaiTap", cauhoibaitap.IdPhieuBaiTap);
            ViewData["MaCh"] = new SelectList(_context.Cauhois, "MaCh", "MaCh", cauhoibaitap.MaCh);
            return View(cauhoibaitap);
        }

        // GET: Cauhoibaitaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauhoibaitap = await _context.Cauhoibaitaps.FindAsync(id);
            if (cauhoibaitap == null)
            {
                return NotFound();
            }
            ViewData["IdPhieuBaiTap"] = new SelectList(_context.Phieubaitaponluyens, "IdPhieuBaiTap", "IdPhieuBaiTap", cauhoibaitap.IdPhieuBaiTap);
            ViewData["MaCh"] = new SelectList(_context.Cauhois, "MaCh", "MaCh", cauhoibaitap.MaCh);
            return View(cauhoibaitap);
        }

        // POST: Cauhoibaitaps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdBaiTap,IdPhieuBaiTap,MaCh")] Cauhoibaitap cauhoibaitap)
        {
            if (id != cauhoibaitap.IdBaiTap)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cauhoibaitap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CauhoibaitapExists(cauhoibaitap.IdBaiTap))
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
            ViewData["IdPhieuBaiTap"] = new SelectList(_context.Phieubaitaponluyens, "IdPhieuBaiTap", "IdPhieuBaiTap", cauhoibaitap.IdPhieuBaiTap);
            ViewData["MaCh"] = new SelectList(_context.Cauhois, "MaCh", "MaCh", cauhoibaitap.MaCh);
            return View(cauhoibaitap);
        }

        // GET: Cauhoibaitaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauhoibaitap = await _context.Cauhoibaitaps
                .Include(c => c.IdPhieuBaiTapNavigation)
                .Include(c => c.MaChNavigation)
                .FirstOrDefaultAsync(m => m.IdBaiTap == id);
            if (cauhoibaitap == null)
            {
                return NotFound();
            }

            return View(cauhoibaitap);
        }

        // POST: Cauhoibaitaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cauhoibaitap = await _context.Cauhoibaitaps.FindAsync(id);
            if (cauhoibaitap != null)
            {
                _context.Cauhoibaitaps.Remove(cauhoibaitap);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CauhoibaitapExists(int id)
        {
            return _context.Cauhoibaitaps.Any(e => e.IdBaiTap == id);
        }
    }
}
