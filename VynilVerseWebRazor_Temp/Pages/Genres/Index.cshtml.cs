using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VynilVerseWebRazor_Temp.Data;
using VynilVerseWebRazor_Temp.Models;

namespace VynilVerseWebRazor_Temp.Pages.Genres
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Genre> GenreList { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            GenreList = _context.Genres.ToList();
        }
    }
}
