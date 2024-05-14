using VynilVerse.Models;
using VynilVerse.Models.DTOs;

namespace VynilVerse.DataAccess.Repository.Contracts
{
    public interface IAlbumRepository : IRepository<Album>
    {
        Task AddNewAlbumAsync(AlbumAdminDto album);
        Task<IEnumerable<AlbumAdminAllDto>> AllAdminViewDtosAsync();
        Task DeleteAlbumAsync(int id);

        //Task EditAlbumAsync(AlbumAdminEditDto album);

        Task<AlbumAdminDto> GetAlbumDtoAsync(int? id);
        Task<AlbumAdminDeleteDto> GetDeleteDtoAsync(int? id);
        Task UpdateAsync(Album album);
    }
}
