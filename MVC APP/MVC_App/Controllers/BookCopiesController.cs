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
    public class BookCopiesController : Controller
    {
        private readonly MVC_AppDbContext _context;

        public BookCopiesController(MVC_AppDbContext context)
        {
            _context = context;
        }

        // GET: BookCopies
        public async Task<IActionResult> Index()
        {
              return View(await _context.BookCopies.ToListAsync());
        }

        // GET: BookCopies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BookCopies == null)
            {
                return NotFound();
            }

            var bookCopies = await _context.BookCopies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookCopies == null)
            {
                return NotFound();
            }

            return View(bookCopies);
        }

        // GET: BookCopies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookCopies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CopiesFK_Book,CopiesNumberOfCopies,CopiesFK_Library")] BookCopies bookCopies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookCopies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookCopies);
        }

        // GET: BookCopies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BookCopies == null)
            {
                return NotFound();
            }

            var bookCopies = await _context.BookCopies.FindAsync(id);
            if (bookCopies == null)
            {
                return NotFound();
            }
            return View(bookCopies);
        }

        // POST: BookCopies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CopiesFK_Book,CopiesNumberOfCopies,CopiesFK_Library")] BookCopies bookCopies)
        {
            if (id != bookCopies.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookCopies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookCopiesExists(bookCopies.Id))
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
            return View(bookCopies);
        }

        // GET: BookCopies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BookCopies == null)
            {
                return NotFound();
            }

            var bookCopies = await _context.BookCopies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookCopies == null)
            {
                return NotFound();
            }

            return View(bookCopies);
        }

        // POST: BookCopies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BookCopies == null)
            {
                return Problem("Entity set 'MVC_AppDbContext.BookCopies'  is null.");
            }
            var bookCopies = await _context.BookCopies.FindAsync(id);
            if (bookCopies != null)
            {
                _context.BookCopies.Remove(bookCopies);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookCopiesExists(int id)
        {
          return _context.BookCopies.Any(e => e.Id == id);
        }
    }
}
