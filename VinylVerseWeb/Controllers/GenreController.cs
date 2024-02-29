using Microsoft.AspNetCore.Mvc;

namespace VinylVerseWeb.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
