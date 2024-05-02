using VynilVerse.Models;

namespace VynilVerse.DataAccess.Repository.Contracts
{
    public interface IGenreRepository : IRepository<Genre>
    {
        Task UpdateAsync(Genre genre);
    }
}
