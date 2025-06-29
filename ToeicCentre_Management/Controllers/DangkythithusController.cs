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
    public class DangkythithusController : Controller
    {
        private readonly TOIECContext _context;

        public DangkythithusController(TOIECContext context)
        {
            _context = context;
        }

        // GET: Dangkythithus
        public async Task<IActionResult> Index()
        {
            var tOIECContext = _context.Dangkythithus.Include(d => d.IdDeThiNavigation).Include(d => d.MaLsdTlNavigation).Include(d => d.MaSvNavigation);
            return View(await tOIECContext.ToListAsync());
        }

        // GET: Dangkythithus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangkythithu = await _context.Dangkythithus
                .Include(d => d.IdDeThiNavigation)
                .Include(d => d.MaLsdTlNavigation)
                .Include(d => d.MaSvNavigation)
                .FirstOrDefaultAsync(m => m.IdThiThu == id);
            if (dangkythithu == null)
            {
                return NotFound();
            }

            return View(dangkythithu);
        }

        // GET: Dangkythithus/Create
        public IActionResult Create()
        {
            ViewData["IdDeThi"] = new SelectList(_context.Dethis, "IdDeThi", "IdDeThi");
            ViewData["MaLsdTl"] = new SelectList(_context.Lichsuduyettls, "MaLsdTl", "MaLsdTl");
            ViewData["MaSv"] = new SelectList(_context.Sinhviens, "MaSv", "MaSv");
            return View();
        }

        // POST: Dangkythithus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdThiThu,MaSv,NgayThiThu,CaThi,DiaDiem,DotThiThu,IdDeThi,GhiChu,MaLsdTl")] Dangkythithu dangkythithu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dangkythithu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDeThi"] = new SelectList(_context.Dethis, "IdDeThi", "IdDeThi", dangkythithu.IdDeThi);
            ViewData["MaLsdTl"] = new SelectList(_context.Lichsuduyettls, "MaLsdTl", "MaLsdTl", dangkythithu.MaLsdTl);
            ViewData["MaSv"] = new SelectList(_context.Sinhviens, "MaSv", "MaSv", dangkythithu.MaSv);
            return View(dangkythithu);
        }

        // GET: Dangkythithus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangkythithu = await _context.Dangkythithus.FindAsync(id);
            if (dangkythithu == null)
            {
                return NotFound();
            }
            ViewData["IdDeThi"] = new SelectList(_context.Dethis, "IdDeThi", "IdDeThi", dangkythithu.IdDeThi);
            ViewData["MaLsdTl"] = new SelectList(_context.Lichsuduyettls, "MaLsdTl", "MaLsdTl", dangkythithu.MaLsdTl);
            ViewData["MaSv"] = new SelectList(_context.Sinhviens, "MaSv", "MaSv", dangkythithu.MaSv);
            return View(dangkythithu);
        }

        // POST: Dangkythithus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdThiThu,MaSv,NgayThiThu,CaThi,DiaDiem,DotThiThu,IdDeThi,GhiChu,MaLsdTl")] Dangkythithu dangkythithu)
        {
            if (id != dangkythithu.IdThiThu)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dangkythithu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DangkythithuExists(dangkythithu.IdThiThu))
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
            ViewData["IdDeThi"] = new SelectList(_context.Dethis, "IdDeThi", "IdDeThi", dangkythithu.IdDeThi);
            ViewData["MaLsdTl"] = new SelectList(_context.Lichsuduyettls, "MaLsdTl", "MaLsdTl", dangkythithu.MaLsdTl);
            ViewData["MaSv"] = new SelectList(_context.Sinhviens, "MaSv", "MaSv", dangkythithu.MaSv);
            return View(dangkythithu);
        }

        // GET: Dangkythithus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangkythithu = await _context.Dangkythithus
                .Include(d => d.IdDeThiNavigation)
                .Include(d => d.MaLsdTlNavigation)
                .Include(d => d.MaSvNavigation)
                .FirstOrDefaultAsync(m => m.IdThiThu == id);
            if (dangkythithu == null)
            {
                return NotFound();
            }

            return View(dangkythithu);
        }

        // POST: Dangkythithus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dangkythithu = await _context.Dangkythithus.FindAsync(id);
            if (dangkythithu != null)
            {
                _context.Dangkythithus.Remove(dangkythithu);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DangkythithuExists(int id)
        {
            return _context.Dangkythithus.Any(e => e.IdThiThu == id);
        }
    }
}
