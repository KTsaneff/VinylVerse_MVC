using VynilVerse.Models;
using VynilVerse.Models.DTOs;

namespace VynilVerse.DataAccess.Repository.Contracts
{
    public interface IAlbumRepository : IRepository<Album>
    {
        Task<IEnumerable<AlbumAdminAllDto>> AllAdminViewDtosAsync();
        Task DeleteAlbumAsync(int id);
        Task EditAlbumAsync(AlbumAdminEditDto album);
        Task<AlbumAdminCreateDto> GetAlbumCreateDtoAsync();
        Task<AlbumAdminEditDto> GetAlbumEditDtoAsync(int id);
        Task<AlbumAdminDeleteDto> GetDeleteDtoAsync(int? id);
        Task UpdateAsync(Album album);
    }
}
