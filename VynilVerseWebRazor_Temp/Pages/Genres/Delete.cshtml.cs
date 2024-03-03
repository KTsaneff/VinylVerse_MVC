using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VynilVerseWebRazor_Temp.Data;
using VynilVerseWebRazor_Temp.Models;

namespace VynilVerseWebRazor_Temp.Pages.Genres
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public Genre Genre { get; set; } = null!;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            if (id != null && id != 0)
            {
                Genre = _context.Genres.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            Genre? genreToDelete = _context.Genres.Find(Genre.Id);
            if (genreToDelete == null)
            {
                return NotFound();
            }
            _context.Genres.Remove(genreToDelete);
            _context.SaveChanges();
            TempData["success"] = "Category deleted";
            return RedirectToPage("Index");
        }
    }
}
