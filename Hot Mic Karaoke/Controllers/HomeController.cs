using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hot_Mic_Karaoke.Models;
using Hot_Mic_Karaoke.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hot_Mic_Karaoke.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
        public readonly UserManager<AppUser> _userManager;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext options, UserManager<AppUser> userManager)
        {
            _context = options;
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userMember = _context.Member.Where(s => s.AppUserId == user).FirstOrDefault();

            var userBusiness = _context.Business.Where(s => s.AppUserId == user).FirstOrDefault();
            var currentUser = await _userManager.GetUserAsync(User);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentUserName = currentUser.UserName;
            }
           
            var messages = await _context.Messages.ToListAsync();

           
            
            if (User.IsInRole("Member") && userMember == null)
            {
                return RedirectToAction("Create", "Members");
            }
            else if (userMember != null)
            {
                return RedirectToAction("MemberHomePage", "Member");
            }
            if (User.IsInRole("Business") && userBusiness == null)
            {
                return RedirectToAction("Create", "Businesses");
            }
            else if (userBusiness != null)
            {
                return RedirectToAction("BusinessHomePage", "Businesses");
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> Create(Message message)
        {
            if (ModelState.IsValid)
            {
                message.UserName = User.Identity.Name;
                var sender = await _userManager.GetUserAsync(User);
                message.UserID = sender.Id;
                await _context.Messages.AddAsync(message);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return Error();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
