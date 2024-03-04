using VynilVerse.Models;

namespace VynilVerse.DataAccess.Repository
{
    public interface IGenreRepository : IRepository<Genre>
    {
        void Update(Genre genre);
        void Save();
    }
}
