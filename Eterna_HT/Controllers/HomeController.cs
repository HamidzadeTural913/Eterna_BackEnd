using Eterna_HT.DAL;
using Eterna_HT.Models;
using Eterna_HT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna_HT.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

      

        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Boxs = await _context.Boxs.ToListAsync(),
                Skills = await _context.Skills.FirstOrDefaultAsync(),
                Progresses = await _context.Progresses.ToListAsync(),
                SocialContacts = await _context.SocialContacts.ToListAsync()
            };
            return View(model);
        }
     
    }
}
