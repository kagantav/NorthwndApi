using BaseLib.DataAccess.Contracts;
using NorthwndWS.Model.Entities;

namespace NorthwndWS.DataAccess.Contracts.Repositories
{
    public interface IProductRepository:IRepository<Product,int>
    {
        Task<List<Product>> GetByPrice(decimal min, decimal max, params string[] includeList);
    }
}
