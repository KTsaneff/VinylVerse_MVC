using Microsoft.AspNetCore.Mvc;
using VynilVerse.DataAccess.Repository.Contracts;
using VynilVerse.Models;
using VynilVerse.Models.DTOs;

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

        public async Task<IActionResult> Index()
        {
            List<AlbumAdminAllDto> albums = (List<AlbumAdminAllDto>)await _unitOfWork.Album.AllAdminViewDtosAsync();
            return View(albums);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            AlbumCreateDto model = await _unitOfWork.Album.GetAlbumCreateDtoAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AlbumCreateDto model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            throw new NotImplementedException();
        }
    }
}
