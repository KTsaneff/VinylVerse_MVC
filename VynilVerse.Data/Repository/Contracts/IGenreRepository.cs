using VynilVerse.Models;

namespace VynilVerse.DataAccess.Repository.Contracts
{
    public interface IGenreRepository : IRepository<Genre>
    {
        void Update(Genre genre);
    }
}
