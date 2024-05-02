﻿using Microsoft.AspNetCore.Mvc;
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
            AlbumAdminCreateDto model = await _unitOfWork.Album.GetAlbumCreateDtoAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AlbumAdminCreateDto model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            throw new NotImplementedException();
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
    }
}
