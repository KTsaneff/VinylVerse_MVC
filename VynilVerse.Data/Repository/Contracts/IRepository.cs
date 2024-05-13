using System.Linq.Expressions;

namespace VynilVerse.DataAccess.Repository.Contracts
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter=null, string? includeProperties=null);

        Task<T> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);

        Task AddEntityAsync(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}
