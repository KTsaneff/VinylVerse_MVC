using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VynilVerse.Utility;

namespace VynilVerse.Models
{
    public class Genre
    {
        public Genre()
        {
            Albums = new List<Album>(); 
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Validate.GenreNameMaxLength)]
        [DisplayName("Genre Name")]
        public string Name { get; set; } = null!;

        [Range(Validate.GenreDisplayOrderMinValue, Validate.GenreDisplayOrderMaxValue, ErrorMessage = Validate.GenreDisplayOrderErrorMessage)]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
