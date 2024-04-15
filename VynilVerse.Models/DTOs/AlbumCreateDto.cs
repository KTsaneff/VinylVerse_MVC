using System.ComponentModel.DataAnnotations;
using VynilVerse.Utility;

namespace VynilVerse.Models.DTOs
{
    public class AlbumCreateDto
    {
        [Required]
        [MaxLength(Validate.AlbumTitleMaxLength)]
        public  string Title { get; set; } = null!;

        [Range(1, int.MaxValue)]
        public int ArtistId { get; set; }

        public virtual IEnumerable<ArtistSelectDto> Artists { get; set; } = null!;

        [Range(1, int.MaxValue)]
        public int GenreId { get; set; }

        public virtual IEnumerable<GenreSelectDto> Genres { get; set; } = null!;

        [Range(Validate.ReleaseYearMinValue, Validate.ReleaseYearMaxValue)]
        public int YearOfRelease { get; set; }

        [MaxLength(Validate.AlbumDescritionMaxLength)]
        public string? Description { get; set; }

        [Required]
        [Range(typeof(decimal), Validate.AlbumMinPrice, Validate.AlbumMaxPrice)]
        public decimal Price { get; set; }

        [Required]
        [Range(Validate.AlbumMinQuantity, Validate.AlbumMaxQuantity)]
        public int Quantity { get; set; }

        [Required]
        [RegularExpression(Validate.ImageUrlRegex)]
        public string CoverImageUrl { get; set; } = null!;

        [Range(Validate.AlbumRatingMinValue, Validate.AlbumRatingMaxValue)]
        public double? Rating { get; set; }

        public List<string> Tracks { get; set; } = new List<string>();

    }
}
