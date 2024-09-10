using BaseLib.Model;
using System.Linq.Expressions;

namespace BaseLib.DataAccess.Contracts
{
    public interface IRepository<TEntity,TId>
        where TEntity:BaseEntity<TId>
    {
        Task<List<TEntity>> GetAllAsync(
            params string[] includeList);

        Task<List<TEntity>> FilterAsync(
            Expression<Func<TEntity, bool>> predicate,
            params string[] includeList);

        /// <summary>
        /// Kritere uyan tek kaydı döndürmek üzere tsarlanmış metoddur.
        /// </summary>
        /// <param name="predicate">Kriter</param>
        /// <param name="includeList">Elde edilen entity içerisine dahil edilecek olan ilişkili nesneler</param>
        /// <returns></returns>
        Task<TEntity> GetAsync(
            Expression<Func<TEntity, bool>> predicate,
            params string[] includeList);

        Task<TEntity> GetByIdAsync(TId id, params string[] includeList);

        Task InsertAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task DeleteAsync(TId id);
    }
}
