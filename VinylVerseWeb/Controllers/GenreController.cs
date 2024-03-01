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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            if (genre.Name != null && !genre.Name.All(char.IsLetter))
            {
                ModelState.AddModelError("Name", "Genre cannot contain special symbols or digits.");
            }

            if (ModelState.IsValid)
            {
                _context.Genres.Add(genre);
                _context.SaveChanges();

                TempData["success"] = "Genre added successfully";

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            Genre? genre = _context.Genres.Find(id);

            if(genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        [HttpPost]
        public IActionResult Edit(Genre genre)
        {           
            if (ModelState.IsValid)
            {
                _context.Genres.Update(genre);
                _context.SaveChanges();

                TempData["success"] = "Genre updated successfully";

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Genre? genre = _context.Genres.Find(id);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Genre genreToDelete = _context.Genres.Find(id);
            if(genreToDelete == null)
            {
                return NotFound();
            }
            _context.Genres.Remove(genreToDelete);
            _context.SaveChanges();

            TempData["success"] = "Genre deleted successfully";

            return RedirectToAction("Index");
        }
    }
}
