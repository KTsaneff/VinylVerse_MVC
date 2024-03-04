using Microsoft.AspNetCore.Mvc;
using VynilVerse.DataAccess.Data;
using VynilVerse.DataAccess.Repository;
using VynilVerse.Models;

namespace VinylVerseWeb.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreRepository _repo;

        public GenreController(IGenreRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            List<Genre> genres = _repo.GetAll().ToList();
            return View(genres);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            if (genre.Name != null && genre.Name.Any(char.IsDigit) && genre.Name.Any(char.IsPunctuation))
            {
                ModelState.AddModelError("Name", "Genre cannot contain special symbols or digits.");
            }

            if (ModelState.IsValid)
            {
                _repo.Add(genre);
                _repo.Save();

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

            Genre? genre = _repo.Get(x => x.Id == id);

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
                _repo.Update(genre);
                _repo.Save();

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

            Genre? genre = _repo.Get(x => x.Id == id);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Genre genreToDelete = _repo.Get(x => x.Id == id);
            if(genreToDelete == null)
            {
                return NotFound();
            }
            _repo.Remove(genreToDelete);
            _repo.Save();

            TempData["success"] = "Genre deleted successfully";

            return RedirectToAction("Index");
        }
    }
}
