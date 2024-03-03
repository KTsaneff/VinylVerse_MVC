using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using VynilVerseWebRazor_Temp.Validation;

namespace VynilVerseWebRazor_Temp.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Validate.GenreNameMaxLength)]
        [DisplayName("Genre Name")]
        public string Name { get; set; } = null!;

        [Range(Validate.GenreDisplayOrderMinValue, Validate.GenreDisplayOrderMaxValue, ErrorMessage = Validate.GenreDisplayOrderErrorMessage)]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
