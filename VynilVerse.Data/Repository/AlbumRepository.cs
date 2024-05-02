using Microsoft.EntityFrameworkCore;
using VynilVerse.DataAccess.Data;
using VynilVerse.DataAccess.Repository.Contracts;
using VynilVerse.Models;
using VynilVerse.Models.DTOs;

namespace VynilVerse.DataAccess.Repository
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        private ApplicationDbContext _context;
        public AlbumRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AlbumAdminAllDto>> AllAdminViewDtosAsync()
        {
            IEnumerable<AlbumAdminAllDto> albums = await _context.Albums
                .Select(a => new AlbumAdminAllDto
                {
                    Id = a.Id,
                    Title = a.Title,
                    ArtistName = a.Artist.Name,
                    CoverImageUrl = a.CoverImageUrl
                })
                .ToListAsync();
            return albums;
        }

        public async Task<AlbumCreateDto> GetAlbumCreateDtoAsync()
        {
            IEnumerable<ArtistSelectDto> artists = await _context.Artists
                .Select(a => new ArtistSelectDto
                {
                    Id = a.Id,
                    Name = a.Name
                })
                .ToListAsync();

            IEnumerable<GenreSelectDto> genres = await _context.Genres
                .Select(g => new GenreSelectDto
                {
                    Id = g.Id,
                    Name = g.Name
                })
                .ToListAsync();

            AlbumCreateDto albumCreateDto = new AlbumCreateDto
            {
                Artists = artists,
                Genres = genres
            };
            return albumCreateDto;
        }

        public void Update(Album album)
        {
            _context.Albums.Update(album);
        }
    }
}
