using Microsoft.AspNetCore.Mvc;
using VynilVerse.DataAccess.Repository.Contracts;
using VynilVerse.Models;

namespace VinylVerseWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AlbumController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AlbumController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Album> albums = _unitOfWork.Album.GetAll().ToList();
            return View(albums);
        }
    }
}
