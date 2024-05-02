namespace VynilVerse.DataAccess.Repository.Contracts
{
    public interface IUnitOfWork
    {
        IGenreRepository Genre { get; }

        IAlbumRepository Album { get; }

        IArtistRepository Artist { get; }

        Task Save();
    }
}
