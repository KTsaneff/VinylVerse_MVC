using System.ComponentModel.DataAnnotations;
using VynilVerse.Utility;

namespace VynilVerse.Models
{
    public class Artist
    {
        public Artist()
        {
            Albums = new List<Album>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Validate.ArtistNameMaxLength)]
        public string Name { get; set; } = null!;

        [MaxLength(Validate.CountryNameMaxLength)]
        public string? Country { get; set; }

        [Required]
        [RegularExpression(Validate.ImageUrlRegex)]
        public string ArtistImageUrl { get; set; } = null!;

        public virtual ICollection<Album> Albums { get; set; }


    }
}
