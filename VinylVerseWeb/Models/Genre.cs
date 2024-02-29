using System.ComponentModel.DataAnnotations;

namespace VinylVerseWeb.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public int DisplayOrder { get; set; }
    }
}
