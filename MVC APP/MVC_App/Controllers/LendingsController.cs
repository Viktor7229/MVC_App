using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_App_Domain;
using MVC_App_Domain.Models;

namespace MVC_App.Controllers
{
    public class LendingsController : Controller
    {
        private readonly MVC_AppDbContext _context;

        public LendingsController(MVC_AppDbContext context)
        {
            _context = context;
        }

        // GET: Lendings
        public async Task<IActionResult> Index()
        {
              return View(await _context.Lending.ToListAsync());
        }

        // GET: Lendings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lending == null)
            {
                return NotFound();
            }

            var lending = await _context.Lending
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lending == null)
            {
                return NotFound();
            }

            return View(lending);
        }

        // GET: Lendings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lendings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FK_Book,FK_Client,DateLending,DateGivenBack")] Lending lending)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lending);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lending);
        }

        // GET: Lendings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lending == null)
            {
                return NotFound();
            }

            var lending = await _context.Lending.FindAsync(id);
            if (lending == null)
            {
                return NotFound();
            }
            return View(lending);
        }

        // POST: Lendings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FK_Book,FK_Client,DateLending,DateGivenBack")] Lending lending)
        {
            if (id != lending.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lending);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LendingExists(lending.Id))
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
            return View(lending);
        }

        // GET: Lendings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lending == null)
            {
                return NotFound();
            }

            var lending = await _context.Lending
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lending == null)
            {
                return NotFound();
            }

            return View(lending);
        }

        // POST: Lendings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lending == null)
            {
                return Problem("Entity set 'MVC_AppDbContext.Lending'  is null.");
            }
            var lending = await _context.Lending.FindAsync(id);
            if (lending != null)
            {
                _context.Lending.Remove(lending);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LendingExists(int id)
        {
          return _context.Lending.Any(e => e.Id == id);
        }
    }
}
