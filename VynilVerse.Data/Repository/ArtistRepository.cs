using VynilVerse.DataAccess.Data;
using VynilVerse.DataAccess.Repository.Contracts;
using VynilVerse.Models;

namespace VynilVerse.DataAccess.Repository
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        private ApplicationDbContext _context;
        public ArtistRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
