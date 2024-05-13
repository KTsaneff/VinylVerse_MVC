using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

            IEnumerable<SelectListItem> genreList = await _unitOfWork.Genre
                .GetAllAsync()
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                });

            return View(albums);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            AlbumAdminCreateDto album = await _unitOfWork.Album.GetAlbumCreateDtoAsync();
            return View(album);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AlbumAdminCreateDto album)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Album.AddNewAlbumAsync(album);

                TempData["success"] = "Album added successfully";

                return RedirectToAction("Index");
            }

            return View(album);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            int identifier = id.GetValueOrDefault();

            AlbumAdminEditDto album = await _unitOfWork.Album.GetAlbumEditDtoAsync(identifier);

            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AlbumAdminEditDto album)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Album.EditAlbumAsync(album);

                TempData["success"] = "Album updated successfully";

                return RedirectToAction("Index");
            }
            return View(album);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            AlbumAdminDeleteDto albumToDelete = await _unitOfWork.Album.GetDeleteDtoAsync(id);

            if (albumToDelete == null)
            {
                return NotFound();
            }

            return View(albumToDelete);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeletePost(AlbumAdminDeleteDto deleteDto)
        {
            if (deleteDto == null)
            {
                return NotFound();
            }

            Album albumToDelete = await _unitOfWork.Album.GetAsync(x => x.Id == deleteDto.Id);
            if (albumToDelete == null)
            {
                return NotFound();
            }

            _unitOfWork.Album.Remove(albumToDelete);
            await _unitOfWork.Save();

            return RedirectToAction("Index");
        }
    }
}
