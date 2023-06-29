using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaiThiTXT.Models;

namespace BaiThiTXT.Controllers
{
    public class TXTCau3Controller : Controller
    {
        private readonly ApplicationDbContext _context;


        public TXTCau3Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TXTCau3
        public async Task<IActionResult> Index()
        {
              return _context.TXTCau3 != null ? 
                          View(await _context.TXTCau3.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TXTCau3'  is null.");
        }

        // GET: TXTCau3/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TXTCau3 == null)
            {
                return NotFound();
            }

            var tXTCau3 = await _context.TXTCau3
                .FirstOrDefaultAsync(m => m.MaLop == id);
            if (tXTCau3 == null)
            {
                return NotFound();
            }

            return View(tXTCau3);
        }

        // GET: TXTCau3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TXTCau3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLop,TenLop,KhoaHoc")] TXTCau3 tXTCau3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tXTCau3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tXTCau3);
        }

        // GET: TXTCau3/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TXTCau3 == null)
            {
                return NotFound();
            }

            var tXTCau3 = await _context.TXTCau3.FindAsync(id);
            if (tXTCau3 == null)
            {
                return NotFound();
            }
            return View(tXTCau3);
        }

        // POST: TXTCau3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("MaLop,TenLop,KhoaHoc")] TXTCau3 tXTCau3)
        {
            if (id != tXTCau3.MaLop)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tXTCau3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TXTCau3Exists(tXTCau3.MaLop))
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
            return View(tXTCau3);
        }

        // GET: TXTCau3/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TXTCau3 == null)
            {
                return NotFound();
            }

            var tXTCau3 = await _context.TXTCau3
                .FirstOrDefaultAsync(m => m.MaLop == id);
            if (tXTCau3 == null)
            {
                return NotFound();
            }

            return View(tXTCau3);
        }

        // POST: TXTCau3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.TXTCau3 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TXTCau3'  is null.");
            }
            var tXTCau3 = await _context.TXTCau3.FindAsync(id);
            if (tXTCau3 != null)
            {
                _context.TXTCau3.Remove(tXTCau3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TXTCau3Exists(int? id)
        {
          return (_context.TXTCau3?.Any(e => e.MaLop == id)).GetValueOrDefault();
        }
    }
}
