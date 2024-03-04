namespace VynilVerse.DataAccess.Repository.Contracts
{
    public interface IUnitOfWork
    {
        IGenreRepository Genre { get; }
        void Save();
    }
}
