using VynilVerse.Models;

namespace VynilVerse.DataAccess.Repository.Contracts
{
    public interface IAlbumRepository : IRepository<Album>
    {
        void Update(Album album);
    }
}
