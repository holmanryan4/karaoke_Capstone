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
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;

namespace Hot_Mic_Karaoke.Controllers
{
    public class MembersController : Controller
    {
        private readonly ApplicationDbContext _context;
       

        public MembersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Members
        public async Task<IActionResult> Index()
        {
            //List<Message> msg  = new List<Message>();
            //MemberMessages memberMsg = new MemberMessages();
            //memberMsg.Messages = msg;
            //var applicationDbContext = _context.Member.Include(m => m.Address).Include(m => m.AppUser).Include(m => m.Kevents);
            var applicationDbContext = _context.Member.Include("Address").Include("SongLists");
            //var songs = _context.SongList.Include("Title").Include("Artist").Include("Comment").Include("Rating");
            return View(await applicationDbContext.ToListAsync());
        }
        
       

        // GET: Members/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member
                .Include(m => m.Address)
                .Include(m => m.AppUser)
                //.Include(m => m.Kevents)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // GET: Members/Create
        public IActionResult Create()
        {
           ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id");
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id");
           ViewData["SonglistId"] = new SelectList(_context.Set<SongList>(), "Id", "Id");
            //ViewData["KeventsId"] = new SelectList(_context.Set<Kevents>(), "Id");
            return View();
        }

        // POST: Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Member member)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                member.AppUserId = userId;

                ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", member.AddressId);
                ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", member.AppUserId);
                //ViewData["SonglistId"] = new SelectList(_context.Set<SongList>(), "Id", "Id", member.SongListId);
                _context.Add(member);
                
                await _context.SaveChangesAsync();
                return RedirectToAction("MemberHomePage", "Members");
            }
            //ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", member.AddressId);
            //ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", member.AppUserId);
            //ViewData["SonglistId"] = new SelectList(_context.Set<SongList>(), "Id", "Id", member.SongListId);
            return View(member);
        }

        // GET: Members/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", member.AddressId);
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", member.AppUserId);
          //  ViewData["KeventsId"] = new SelectList(_context.Set<Kevents>(), "Id", "EventLocation", member.KeventsId);
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,AppUserId,AddressId,KeventsId")] Member member)
        {
            if (id != member.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(member);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.Id))
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
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", member.AddressId);
            ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", member.AppUserId);
            //ViewData["KeventsId"] = new SelectList(_context.Set<Kevents>(), "Id", "EventLocation", member.KeventsId);
            return View(member);
        }

        // GET: Members/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member
                .Include(m => m.Address)
                .Include(m => m.AppUser)
               // .Include(m => m.Kevents)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var member = await _context.Member.FindAsync(id);
            _context.Member.Remove(member);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberExists(int id)
        {
            return _context.Member.Any(e => e.Id == id);
        }
        public IActionResult MemberHomePage()
        {
            var applicationDbContext = _context.Member.Include("Address").Include("SongList");
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var currentUser = _context.Member.Where(c => c.AppUserId == userId).Include("Address").FirstOrDefault();
            

            return View();

        }
       

    }
}
