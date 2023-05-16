using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BTL_Nhom03.Models;
using BTL_Nhom03.Models.Process;

namespace BTL_Nhom03.Controllers
{
    public class DonhangController : Controller
    {
        private readonly ApplicationDbContext _context;


        public DonhangController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Donhang
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Donhang.Include(d => d.Khachhang).Include(d => d.Sanpham);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Donhang/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Donhang == null)
            {
                return NotFound();
            }

            var donhang = await _context.Donhang
                .Include(d => d.Khachhang)
                .Include(d => d.Sanpham)
                .FirstOrDefaultAsync(m => m.MaDonHang == id);
            if (donhang == null)
            {
                return NotFound();
            }

            return View(donhang);
        }

        // GET: Donhang/Create
        public IActionResult Create()
        {
            ViewData["MaKhachHang"] = new SelectList(_context.Khachhang, "MaKhachHang", "TenKhachHang");
            ViewData["MaSP"] = new SelectList(_context.Sanpham, "MaSP", "TenSP");
            
            return View();
        }

        // POST: Donhang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDonHang,MaKhachHang,MaSP,GiaTien,NgayBan")] Donhang donhang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donhang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKhachHang"] = new SelectList(_context.Khachhang, "MaKhachHang", "TenKhachHang", donhang.MaKhachHang);
            ViewData["MaSP"] = new SelectList(_context.Sanpham, "MaSP", "TenSP", donhang.MaSP);
            return View(donhang);
        }

        // GET: Donhang/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Donhang == null)
            {
                return NotFound();
            }

            var donhang = await _context.Donhang.FindAsync(id);
            if (donhang == null)
            {
                return NotFound();
            }
            ViewData["MaKhachHang"] = new SelectList(_context.Khachhang, "MaKhachHang", "TenKhachHang", donhang.MaKhachHang);
            ViewData["MaSP"] = new SelectList(_context.Sanpham, "MaSP", "TenSP", donhang.MaSP);
            return View(donhang);
        }

        // POST: Donhang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaDonHang,MaKhachHang,MaSP,GiaTien,NgayBan")] Donhang donhang)
        {
            if (id != donhang.MaDonHang)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donhang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonhangExists(donhang.MaDonHang))
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
            ViewData["MaKhachHang"] = new SelectList(_context.Khachhang, "MaKhachHang", "TenKhachHang", donhang.MaKhachHang);
            ViewData["MaSP"] = new SelectList(_context.Sanpham, "MaSP", "TenSP", donhang.MaSP);
            return View(donhang);
        }

        // GET: Donhang/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Donhang == null)
            {
                return NotFound();
            }

            var donhang = await _context.Donhang
                .Include(d => d.Khachhang)
                .Include(d => d.Sanpham)
                .FirstOrDefaultAsync(m => m.MaDonHang == id);
            if (donhang == null)
            {
                return NotFound();
            }

            return View(donhang);
        }

        // POST: Donhang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Donhang == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Donhang'  is null.");
            }
            var donhang = await _context.Donhang.FindAsync(id);
            if (donhang != null)
            {
                _context.Donhang.Remove(donhang);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonhangExists(string id)
        {
          return (_context.Donhang?.Any(e => e.MaDonHang == id)).GetValueOrDefault();
        }
    }
}
