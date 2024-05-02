namespace VynilVerse.Models.DTOs
{
    public class AlbumAdminAllDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string ArtistName { get; set; } = null!;
        public string CoverImageUrl { get; set; } = null!;
    }
}
