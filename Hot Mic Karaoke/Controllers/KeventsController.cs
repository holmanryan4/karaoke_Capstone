using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hot_Mic_Karaoke.Data;
using Hot_Mic_Karaoke.Models;

namespace Hot_Mic_Karaoke.Controllers
{
    public class KeventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KeventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Kevents
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kevents.ToListAsync());
        }

        // GET: Kevents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kevents = await _context.Kevents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kevents == null)
            {
                return NotFound();
            }

            return View(kevents);
        }

        // GET: Kevents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kevents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventLocation,DateAndTime")] Kevents kevents)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kevents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kevents);
        }

        // GET: Kevents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kevents = await _context.Kevents.FindAsync(id);
            if (kevents == null)
            {
                return NotFound();
            }
            return View(kevents);
        }

        // POST: Kevents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventLocation,DateAndTime")] Kevents kevents)
        {
            if (id != kevents.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kevents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KeventsExists(kevents.Id))
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
            return View(kevents);
        }

        // GET: Kevents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kevents = await _context.Kevents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kevents == null)
            {
                return NotFound();
            }

            return View(kevents);
        }

        // POST: Kevents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kevents = await _context.Kevents.FindAsync(id);
            _context.Kevents.Remove(kevents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KeventsExists(int id)
        {
            return _context.Kevents.Any(e => e.Id == id);
        }
    }
}
