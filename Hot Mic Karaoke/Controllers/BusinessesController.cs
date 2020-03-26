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
    public class BusinessesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BusinessesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Businesses
        public async Task<IActionResult> Index()
        {
            //List<Message> bMsg = new List<Message>();
            //BusinessMessages bizMsg = new BusinessMessages();
            //bizMsg.Messages = bMsg;
            var applicationDbContext = _context.Business.Include(b => b.Address).Include(b => b.AppUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Businesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Business
                .Include(b => b.Address)
                .Include(b => b.AppUser)
               // .Include(b => b.Kevents)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (business == null)
            {
                return NotFound();
            }

            return View(business);
        }

        // GET: Businesses/Create
        public IActionResult Create()
        {

            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id");
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id");
            //ViewData["KeventsId"] = new SelectList(_context.Set<Kevents>(), "Id", "EventLocation");
            return View();
        }

        // POST: Businesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Business business)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                business.AppUserId = userId;
                _context.Add(business);
                await _context.SaveChangesAsync();
                return RedirectToAction("BusinessHomePage", "Businesses");
            }
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", business.AddressId);
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", business.AppUserId);
           // ViewData["KeventsId"] = new SelectList(_context.Set<Kevents>(), "Id", "EventLocation", business.KeventsId);
            return View(business);
        }

        // GET: Businesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Business.FindAsync(id);
            if (business == null)
            {
                return NotFound();
            }
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", business.AddressId);
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", business.AppUserId);
            //ViewData["KeventsId"] = new SelectList(_context.Set<Kevents>(), "Id", "EventLocation", business.KeventsId);
            return View(business);
        }

        // POST: Businesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BusinessName,AdminFirstName,AdminLastName,BusinessPhoneNumber,AppUserId,AddressId,KeventsId")] Business business)
        {
            if (id != business.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(business);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusinessExists(business.Id))
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
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", business.AddressId);
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", business.AppUserId);
           // ViewData["KeventsId"] = new SelectList(_context.Set<Kevents>(), "Id", "EventLocation", business.KeventsId);
            return View(business);
        }

        // GET: Businesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Business
                .Include(b => b.Address)
                .Include(b => b.AppUser)
               // .Include(b => b.Kevents)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (business == null)
            {
                return NotFound();
            }

            return View(business);
        }

        // POST: Businesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var business = await _context.Business.FindAsync(id);
            _context.Business.Remove(business);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BusinessExists(int id)
        {
            return _context.Business.Any(e => e.Id == id);
        }
        public IActionResult BusinessHomePage()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var currentUser = _context.Business.Where(c => c.AppUserId == userId).Include("Address").FirstOrDefault();

            return View();
            
        }

    }
}
