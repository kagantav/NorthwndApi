using BaseLib.DataAccess.Implementations.EF;
using NorthwndWS.DataAccess.Contracts.Repositories;
using NorthwndWS.DataAccess.EF.Contexts;
using NorthwndWS.Model.Entities;

namespace NorthwndWS.DataAccess.EF.Repositories
{
    public class ProductRepository : BaseRepository<Product, int, NorthwndContext>, IProductRepository
    {
        public async Task<List<Product>> GetByPrice(decimal min, decimal max, params string[] includeList)
        {
            return await FilterAsync(x => x.UnitPrice > min && x.UnitPrice < max, includeList);
        }
    }
}
