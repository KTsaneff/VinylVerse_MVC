using VynilVerse.Models;
using VynilVerse.Models.DTOs;

namespace VynilVerse.DataAccess.Repository.Contracts
{
    public interface IAlbumRepository : IRepository<Album>
    {
        Task<IEnumerable<AlbumAdminAllDto>> AllAdminViewDtosAsync();
        Task<AlbumCreateDto> GetAlbumCreateDtoAsync();
        void Update(Album album);
    }
}
