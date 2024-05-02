using VynilVerse.DataAccess.Data;
using VynilVerse.DataAccess.Repository.Contracts;

namespace VynilVerse.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;

        public IGenreRepository Genre { get; private set; }

        public IAlbumRepository Album { get; private set; }

        public IArtistRepository Artist { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Genre = new GenreRepository(_context);
            Album = new AlbumRepository(_context);
            Artist = new ArtistRepository(_context);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
