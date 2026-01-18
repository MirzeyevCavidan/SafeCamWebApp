using SafeCamWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SafeCamWebApp.DAL.Context;

namespace SafeCamWebApp.Controllers
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
            List<Worker> workers = await _context.Workers.Include(w => w.Designation).ToListAsync();

            return View(workers);
        }

    }
}