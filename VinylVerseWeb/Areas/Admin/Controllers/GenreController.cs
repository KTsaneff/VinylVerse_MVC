using Microsoft.AspNetCore.Mvc;
using VynilVerse.DataAccess.Data;
using VynilVerse.DataAccess.Repository.Contracts;
using VynilVerse.Models;

namespace VinylVerseWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenreController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenreController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Genre> genres = _unitOfWork.Genre.GetAll().OrderBy(g => g.Name).ToList();
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
                _unitOfWork.Genre.Add(genre);
                _unitOfWork.Save();

                TempData["success"] = "Genre added successfully";

                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Genre? genre = await _unitOfWork.Genre.GetAsync(x => x.Id == id);

            if (genre == null)
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
                _unitOfWork.Genre.Update(genre);
                _unitOfWork.Save();

                TempData["success"] = "Genre updated successfully";

                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Genre? genre = await _unitOfWork.Genre.GetAsync(x => x.Id == id);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Genre genreToDelete = await _unitOfWork.Genre.GetAsync(x => x.Id == id);
            if (genreToDelete == null)
            {
                return NotFound();
            }

            if (_unitOfWork.Album.GetAll().Any(a => a.GenreId == id))
            {
                TempData["error"] = "Cannot delete genre because it has associated albums.";
                return RedirectToAction("Index");
            }

            _unitOfWork.Genre.Remove(genreToDelete);
            _unitOfWork.Save();

            TempData["success"] = "Genre deleted successfully";

            return RedirectToAction("Index");
        }
    }
}
