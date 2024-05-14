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

        public async Task AddNewAlbumAsync(AlbumAdminDto album)
        {
            Album newAlbum = new Album
            {
                Title = album.Title,
                ArtistId = album.ArtistId,
                GenreId = album.GenreId,
                YearOfRelease = album.YearOfRelease,
                CoverImageUrl = album.CoverImageUrl,
                Description = album.Description,
                Price = album.Price,
                Quantity = album.Quantity,
                Rating = album.Rating,
                TrackList = album.Tracks
            };

            await _context.Albums.AddAsync(newAlbum);
            await _context.SaveChangesAsync();
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

        public async Task DeleteAlbumAsync(int id)
        {
            Album album = _context.Albums.Find(id);
            _context.Albums.Remove(album);
            await _context.SaveChangesAsync();
        }

        public async Task EditAlbumAsync(AlbumAdminDto album)
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

        public async Task<AlbumAdminDto> GetAlbumDtoAsync(int? id)
        {
            IEnumerable<ArtistSelectDto> artists = await GetArtistsAsync();
            IEnumerable<GenreSelectDto> genres = await GetGenresAsync();

            AlbumAdminDto albumDto;

            if (id == null)
            {
                 albumDto = new AlbumAdminDto
                 {
                     Artists = artists,
                     Genres = genres
                 };
            }
            else
            {
                Album album = await _context.Albums.FindAsync(id);

                if (album == null)
                {
                    return null;
                }

                IEnumerable<ArtistSelectDto> artistsDto = await _context.Artists
                    .Select(a => new ArtistSelectDto
                    {
                        Id = a.Id,
                        Name = a.Name
                    })
                    .ToListAsync();

                IEnumerable<GenreSelectDto> genresDto = await _context.Genres
                    .Select(g => new GenreSelectDto
                    {
                        Id = g.Id,
                        Name = g.Name
                    })
                    .ToListAsync();

                albumDto = new()
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
                    Artists = artistsDto,
                    Genres = genresDto
                };
            }
            return albumDto;
        }

        private async Task<IEnumerable<ArtistSelectDto>> GetArtistsAsync()
        {
            return await _context.Artists
                            .Select(a => new ArtistSelectDto
                            {
                                Id = a.Id,
                                Name = a.Name
                            })
                            .OrderBy(a => a.Name)
                            .ToListAsync();
        }

        private async Task<IEnumerable<GenreSelectDto>> GetGenresAsync()
        {
            return await _context.Genres
                            .Select(g => new GenreSelectDto
                            {
                                Id = g.Id,
                                Name = g.Name
                            })
                            .OrderBy(g => g.Name)
                            .ToListAsync();
        }

        public async Task<AlbumAdminDeleteDto> GetDeleteDtoAsync(int? id)
        {
            Album album = await _context.Albums.FirstOrDefaultAsync(a => a.Id == id);

            AlbumAdminDeleteDto albumToDelete = new AlbumAdminDeleteDto
            {
                Id = album.Id,
                Title = album.Title
            };

            return albumToDelete;
        }

        public async Task UpdateAsync(Album album)
        {
            _context.Albums.Update(album);
            await _context.SaveChangesAsync();
        }
    }
}
