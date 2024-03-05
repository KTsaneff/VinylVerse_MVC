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
            List<Artist> artists = _unitOfWork.Artist.GetAll().ToList();
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
    }
}
