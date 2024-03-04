using VynilVerse.DataAccess.Data;
using VynilVerse.DataAccess.Repository.Contracts;

namespace VynilVerse.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public IGenreRepository Genre { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Genre = new GenreRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
