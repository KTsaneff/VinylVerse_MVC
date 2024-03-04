using System.Linq.Expressions;
using VynilVerse.DataAccess.Data;
using VynilVerse.DataAccess.Repository.Contracts;
using VynilVerse.Models;

namespace VynilVerse.DataAccess.Repository
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        private ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Genre genre)
        {
            _context.Genres.Update(genre);
        }
    }
}
