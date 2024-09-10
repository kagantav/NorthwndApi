using BaseLib.DataAccess.Contracts;
using NorthwndWS.Model.Entities;

namespace NorthwndWS.DataAccess.Contracts.Repositories
{
    public interface ICategoryRepository: IRepository<Category, int>
    {
        Task<int?> GetProductCount(int categoryId);
    }
}
