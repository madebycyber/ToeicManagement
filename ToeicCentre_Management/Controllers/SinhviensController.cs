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
    public class SinhviensController : Controller
    {
        private readonly TOIECContext _context;

        public SinhviensController(TOIECContext context)
        {
            _context = context;
        }

        // GET: Sinhviens
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sinhviens.ToListAsync());
        }

        // GET: Sinhviens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinhvien = await _context.Sinhviens
                .FirstOrDefaultAsync(m => m.MaSv == id);
            if (sinhvien == null)
            {
                return NotFound();
            }

            return View(sinhvien);
        }

        // GET: Sinhviens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sinhviens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSv,HoTenSv,Lop,Email,NgaySinh,DiaChi,Cccd,TenDangNhapSv,MatKhauSv")] Sinhvien sinhvien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sinhvien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sinhvien);
        }

        // GET: Sinhviens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinhvien = await _context.Sinhviens.FindAsync(id);
            if (sinhvien == null)
            {
                return NotFound();
            }
            return View(sinhvien);
        }

        // POST: Sinhviens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaSv,HoTenSv,Lop,Email,NgaySinh,DiaChi,Cccd,TenDangNhapSv,MatKhauSv")] Sinhvien sinhvien)
        {
            if (id != sinhvien.MaSv)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sinhvien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SinhvienExists(sinhvien.MaSv))
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
            return View(sinhvien);
        }

        // GET: Sinhviens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinhvien = await _context.Sinhviens
                .FirstOrDefaultAsync(m => m.MaSv == id);
            if (sinhvien == null)
            {
                return NotFound();
            }

            return View(sinhvien);
        }

        // POST: Sinhviens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sinhvien = await _context.Sinhviens.FindAsync(id);
            if (sinhvien != null)
            {
                _context.Sinhviens.Remove(sinhvien);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SinhvienExists(int id)
        {
            return _context.Sinhviens.Any(e => e.MaSv == id);
        }
    }
}
