using VynilVerse.Models;

namespace VynilVerse.DataAccess.Repository.Contracts
{
    public interface IArtistRepository : IRepository<Artist>
    {
        Task UpdateAsync(Artist artist);
    }
}
