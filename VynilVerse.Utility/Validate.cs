namespace VynilVerse.Utility
{
    public static class Validate
    {
        //Genre Validation Constatnts
        public const int GenreNameMaxLength = 20;
        public const int GenreDisplayOrderMinValue = 1;
        public const int GenreDisplayOrderMaxValue = 200;

        public const string GenreDisplayOrderErrorMessage = @"Display Order should be in range 1-200";

        //Album Validation Constants
        public const int AlbumTitleMaxLength = 50;
        public const int ReleaseYearMinValue = 1950;
        public const int ReleaseYearMaxValue = 2100;
        public const int AlbumDescritionMaxLength = 1000;
        public const string AlbumMinPrice = "0.01";
        public const string AlbumMaxPrice = "1000000";
        public const int AlbumMinQuantity = 0;
        public const int AlbumMaxQuantity = 1000;
        public const double AlbumRatingMinValue = 0;
        public const double AlbumRatingMaxValue = 10;


        //Artist Validation Constants
        public const int ArtistNameMaxLength = 50;
        public const int CountryNameMaxLength = 50;

        //Regex
        //public const string ImageUrlRegex = @"^(https?://)?([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$";
    }
}
