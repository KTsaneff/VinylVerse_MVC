using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VynilVerseWebRazor_Temp.Data;
using VynilVerseWebRazor_Temp.Models;

namespace VynilVerseWebRazor_Temp.Pages.Genres
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public Genre Genre { get; set; } = null!;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet(int  id)
        {
            if(id != null && id != 0)
            {
                Genre = _context.Genres.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Genres.Update(Genre);
                _context.SaveChanges();

                TempData["success"] = "Genre updated successfully";

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
