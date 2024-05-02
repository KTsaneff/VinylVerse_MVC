using Microsoft.AspNetCore.Mvc;
using VynilVerse.DataAccess.Repository.Contracts;
using VynilVerse.Models;

namespace VinylVerseWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArtistController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArtistController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Artist> artists = _unitOfWork.Artist.GetAll().OrderBy(a => a.Name).ToList();
            return View(artists);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Artist artist)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Artist.Add(artist);
                _unitOfWork.Save();

                TempData["success"] = "Artist added successfully";

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

            Artist? artist = await _unitOfWork.Artist.GetAsync(x => x.Id == id);

            if (artist == null)
            {
                return NotFound();
            }

            return View(artist);
        }

        [HttpPost]
        public IActionResult Edit(Artist artist)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Artist.Update(artist);
                _unitOfWork.Save();

                TempData["success"] = "Artist updated successfully";

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

            Artist? artist = await _unitOfWork.Artist.GetAsync(x => x.Id == id);

            if (artist == null)
            {
                return NotFound();
            }

            return View(artist);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Artist artistToDelete = await _unitOfWork.Artist.GetAsync(x => x.Id == id);
            if (artistToDelete == null)
            {
                return NotFound();
            }

            if (_unitOfWork.Album.GetAll().Any(a => a.ArtistId == id))
            {
                TempData["error"] = "Cannot delete artist because it has associated albums.";
                return RedirectToAction("Index");
            }

            _unitOfWork.Artist.Remove(artistToDelete);
            _unitOfWork.Save();

            TempData["success"] = "Artist deleted successfully";

            return RedirectToAction("Index");
        }
    }
}
