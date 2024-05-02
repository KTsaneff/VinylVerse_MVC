using System.Linq.Expressions;

namespace VynilVerse.DataAccess.Repository.Contracts
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter=null, string? includeProperties=null);

        Task<T> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);

        Task Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}
