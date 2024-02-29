namespace VinylVerseWeb.Data.Validation
{
    public static class Validate
    {
        //Genre Validation Constatnts
        public const int GenreNameMaxLength = 20;
        public const int GenreDisplayOrderMinValue = 1;
        public const int GenreDisplayOrderMaxValue = 200;

        public const string GenreDisplayOrderErrorMessage = @"Display Order should be in range 1-200";
    }
}
