using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VynilVerse.Utility;

namespace VynilVerse.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Validate.AlbumTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        public int ArtistId { get; set; }

        [ForeignKey(nameof(ArtistId))]
        public Artist Artist { get; set; } = null!;

        [Required]
        public int GenreId { get; set; }

        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;

        [Range(Validate.ReleaseYearMinValue, Validate.ReleaseYearMaxValue)]
        public int YearOfRelease { get; set; }

        [MaxLength(Validate.AlbumDescritionMaxLength)]
        public string? Description { get; set; }

        [Required]
        [Range(typeof(decimal), Validate.AlbumMinPrice, Validate.AlbumMaxPrice)]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Price for 50+")]
        [Range(typeof(decimal), Validate.AlbumMinPrice, Validate.AlbumMaxPrice)]
        public decimal Price50 { get; set; }

        [Required]
        [Display(Name = "Price for 100+")]
        [Range(typeof(decimal), Validate.AlbumMinPrice, Validate.AlbumMaxPrice)]
        public decimal Price100 { get; set; }

        [Required]
        [Range(Validate.AlbumMinQuantity, Validate.AlbumMaxQuantity)]
        public int Quantity { get; set; }

        [Required]
        public string CoverImageUrl { get; set; } = null!;

        [Range(Validate.AlbumRatingMinValue, Validate.AlbumRatingMaxValue)]
        public double? Rating { get; set; }

        public List<string> TrackList { get; set; } = new List<string>();
    }
}
