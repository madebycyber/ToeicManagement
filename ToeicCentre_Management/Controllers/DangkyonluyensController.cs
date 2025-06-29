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
    public class DangkyonluyensController : Controller
    {
        private readonly TOIECContext _context;

        public DangkyonluyensController(TOIECContext context)
        {
            _context = context;
        }

        // GET: Dangkyonluyens
        public async Task<IActionResult> Index()
        {
            var tOIECContext = _context.Dangkyonluyens.Include(d => d.IdLopNavigation).Include(d => d.MaSvNavigation);
            return View(await tOIECContext.ToListAsync());
        }

        // GET: Dangkyonluyens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangkyonluyen = await _context.Dangkyonluyens
                .Include(d => d.IdLopNavigation)
                .Include(d => d.MaSvNavigation)
                .FirstOrDefaultAsync(m => m.IdOnLuyen == id);
            if (dangkyonluyen == null)
            {
                return NotFound();
            }

            return View(dangkyonluyen);
        }

        // GET: Dangkyonluyens/Create
        public IActionResult Create()
        {
            ViewData["IdLop"] = new SelectList(_context.Lops, "IdLop", "IdLop");
            ViewData["MaSv"] = new SelectList(_context.Sinhviens, "MaSv", "MaSv");
            return View();
        }

        // POST: Dangkyonluyens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdOnLuyen,MaSv,IdLop,TrinhDoHienTai,DiemToiecMucTieu,HinhThucHoc,GhiChu")] Dangkyonluyen dangkyonluyen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dangkyonluyen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdLop"] = new SelectList(_context.Lops, "IdLop", "IdLop", dangkyonluyen.IdLop);
            ViewData["MaSv"] = new SelectList(_context.Sinhviens, "MaSv", "MaSv", dangkyonluyen.MaSv);
            return View(dangkyonluyen);
        }

        // GET: Dangkyonluyens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangkyonluyen = await _context.Dangkyonluyens.FindAsync(id);
            if (dangkyonluyen == null)
            {
                return NotFound();
            }
            ViewData["IdLop"] = new SelectList(_context.Lops, "IdLop", "IdLop", dangkyonluyen.IdLop);
            ViewData["MaSv"] = new SelectList(_context.Sinhviens, "MaSv", "MaSv", dangkyonluyen.MaSv);
            return View(dangkyonluyen);
        }

        // POST: Dangkyonluyens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdOnLuyen,MaSv,IdLop,TrinhDoHienTai,DiemToiecMucTieu,HinhThucHoc,GhiChu")] Dangkyonluyen dangkyonluyen)
        {
            if (id != dangkyonluyen.IdOnLuyen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dangkyonluyen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DangkyonluyenExists(dangkyonluyen.IdOnLuyen))
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
            ViewData["IdLop"] = new SelectList(_context.Lops, "IdLop", "IdLop", dangkyonluyen.IdLop);
            ViewData["MaSv"] = new SelectList(_context.Sinhviens, "MaSv", "MaSv", dangkyonluyen.MaSv);
            return View(dangkyonluyen);
        }

        // GET: Dangkyonluyens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangkyonluyen = await _context.Dangkyonluyens
                .Include(d => d.IdLopNavigation)
                .Include(d => d.MaSvNavigation)
                .FirstOrDefaultAsync(m => m.IdOnLuyen == id);
            if (dangkyonluyen == null)
            {
                return NotFound();
            }

            return View(dangkyonluyen);
        }

        // POST: Dangkyonluyens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dangkyonluyen = await _context.Dangkyonluyens.FindAsync(id);
            if (dangkyonluyen != null)
            {
                _context.Dangkyonluyens.Remove(dangkyonluyen);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DangkyonluyenExists(int id)
        {
            return _context.Dangkyonluyens.Any(e => e.IdOnLuyen == id);
        }
    }
}
