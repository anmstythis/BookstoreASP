using BookStore_gladkova.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BookStore_gladkova.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AppDbContext _appDbContext;
        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Catalogue(string type)
        {
            var book = string.IsNullOrEmpty(type)
                ? _appDbContext.Books.Include(b => b.Author).Include(b => b.TypeOfBook).ToListAsync()
                : _appDbContext.Books.Include(b => b.Author).Include(b => b.TypeOfBook)
                .Where(b => b.TypeOfBook.Name_Type == type).ToListAsync();

            if (book == null)
            {
                return NotFound();
            }

            return View(await book);
        }

        public IActionResult About() => View();

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
