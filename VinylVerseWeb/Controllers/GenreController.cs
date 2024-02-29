using Microsoft.AspNetCore.Mvc;
using VinylVerseWeb.Data;
using VinylVerseWeb.Models;

namespace VinylVerseWeb.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GenreController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Genre> genres = _context.Genres.ToList();
            return View(genres);
        }
    }
}
