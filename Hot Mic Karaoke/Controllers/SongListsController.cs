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
    public class SongListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SongListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SongLists
        public  IActionResult Index(Member member)
        {
            var user = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userMember = _context.Member.Where(s => s.AppUserId == user).FirstOrDefault();
            //var applicationDbContext = _context.Member.Include("SongList");
            List<SongList> songs = _context.SongList
            .Where(o => o.Member.Id == userMember.Id) 
             .Distinct() // To eliminate duplicate customers in the result
             .ToList();

            return View(songs);
        }

        // GET: SongLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songList = await _context.SongList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (songList == null)
            {
                return NotFound();
            }

            return View(songList);
        }

        // GET: SongLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SongLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SongList songList)
        {
            if (ModelState.IsValid)
            {
                var user = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userMember = _context.Member.Where(s => s.AppUserId == user).FirstOrDefault();
                songList.MemberId = userMember.Id;
                _context.Add(songList);
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           // ViewData["MemberId"] = new SelectList(_context.Set<Member>(), "Id", "Id", SongList.);
            return View(songList);
        }

        // GET: SongLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songList = await _context.SongList.FindAsync(id);
            if (songList == null)
            {
                return NotFound();
            }
            return View(songList);
        }

        // POST: SongLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Artist,Comments,Rating")] SongList songList)
        {
            if (id != songList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(songList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongListExists(songList.Id))
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
            return View(songList);
        }

        // GET: SongLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songList = await _context.SongList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (songList == null)
            {
                return NotFound();
            }

            return View(songList);
        }

        // POST: SongLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var songList = await _context.SongList.FindAsync(id);
            _context.SongList.Remove(songList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SongListExists(int id)
        {
            return _context.SongList.Any(e => e.Id == id);
        }
    }
}
