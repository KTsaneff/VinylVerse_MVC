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
                .OrderBy(a => a.Title)
                .ToListAsync();
            return albums;
        }

        public async Task EditAlbumAsync(AlbumAdminEditDto album)
        {
            Album albumToEdit = await _context.Albums.FindAsync(album.Id);

            albumToEdit.Title = album.Title;
            albumToEdit.ArtistId = album.ArtistId;
            albumToEdit.GenreId = album.GenreId;
            albumToEdit.YearOfRelease = album.YearOfRelease;
            albumToEdit.CoverImageUrl = album.CoverImageUrl;
            albumToEdit.Description = album.Description;
            albumToEdit.Price = album.Price;
            albumToEdit.Quantity = album.Quantity;
            albumToEdit.Rating = album.Rating;
            albumToEdit.TrackList = album.Tracks;

            _context.Albums.Update(albumToEdit);
            _context.SaveChanges();
        }

        public async Task<AlbumAdminCreateDto> GetAlbumCreateDtoAsync()
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

            AlbumAdminCreateDto albumCreateDto = new AlbumAdminCreateDto
            {
                Artists = artists,
                Genres = genres
            };
            return albumCreateDto;
        }

        public async Task<AlbumAdminEditDto> GetAlbumEditDtoAsync(int id)
        {
            Album album = await _context.Albums.FindAsync(id);

            if (album == null)
            {
                return null;
            }

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

            AlbumAdminEditDto albumEditDto = new AlbumAdminEditDto
            {
                Id = album.Id,
                Title = album.Title,
                ArtistId = album.ArtistId,
                GenreId = album.GenreId,
                YearOfRelease = album.YearOfRelease,
                CoverImageUrl = album.CoverImageUrl,
                Description = album.Description,
                Price = album.Price,
                Quantity = album.Quantity,
                Rating = album.Rating,
                Tracks = album.TrackList,
                Artists = artists,
                Genres = genres
            };

            return albumEditDto;
        }

        public async Task UpdateAsync(Album album)
        {
            _context.Albums.Update(album);
            await _context.SaveChangesAsync();
        }
    }
}
