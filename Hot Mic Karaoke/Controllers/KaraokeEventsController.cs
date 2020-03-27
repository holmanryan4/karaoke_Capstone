using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hot_Mic_Karaoke.Data;
using Hot_Mic_Karaoke.Models;
using System.Security.Claims;

namespace Hot_Mic_Karaoke.Controllers
{
    public class KaraokeEventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KaraokeEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: KaraokeEvents
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.KaraokeEvent.Include(k => k.Address).Include(k => k.AppUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: KaraokeEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var karaokeEvent = await _context.KaraokeEvent
                .Include(k => k.Address)
                .Include(k => k.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (karaokeEvent == null)
            {
                return NotFound();
            }

            return View(karaokeEvent);
        }

        // GET: KaraokeEvents/Create
        public IActionResult Create()
        {
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id");
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: KaraokeEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( KaraokeEvent karaokeEvent)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                karaokeEvent.AppUserId = userId;

               
               
                _context.Add(karaokeEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            //ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", karaokeEvent.AddressId);
            //ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", karaokeEvent.AppUserId);
            return View(karaokeEvent);
        }

        // GET: KaraokeEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var karaokeEvent = await _context.KaraokeEvent.FindAsync(id);
            if (karaokeEvent == null)
            {
                return NotFound();
            }
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", karaokeEvent.AddressId);
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", karaokeEvent.AppUserId);
            return View(karaokeEvent);
        }

        // POST: KaraokeEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventName,EventInfo,DateAndTime,AppUserId,AddressId")] KaraokeEvent karaokeEvent)
        {
            if (id != karaokeEvent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(karaokeEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KaraokeEventExists(karaokeEvent.Id))
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
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", karaokeEvent.AddressId);
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", karaokeEvent.AppUserId);
            return View(karaokeEvent);
        }

        // GET: KaraokeEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var karaokeEvent = await _context.KaraokeEvent
                .Include(k => k.Address)
                .Include(k => k.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (karaokeEvent == null)
            {
                return NotFound();
            }

            return View(karaokeEvent);
        }

        // POST: KaraokeEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var karaokeEvent = await _context.KaraokeEvent.FindAsync(id);
            _context.KaraokeEvent.Remove(karaokeEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KaraokeEventExists(int id)
        {
            return _context.KaraokeEvent.Any(e => e.Id == id);
        }
    }
}
