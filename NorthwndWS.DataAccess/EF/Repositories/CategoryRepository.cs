using BaseLib.DataAccess.Implementations.EF;
using NorthwndWS.DataAccess.Contracts.Repositories;
using NorthwndWS.DataAccess.EF.Contexts;
using NorthwndWS.Model.Entities;

namespace NorthwndWS.DataAccess.EF.Repositories
{
    public class CategoryRepository : BaseRepository<Category, int, NorthwndContext>, ICategoryRepository
    {
        public async Task<int?> GetProductCount(int categoryId)
        {
            var category = await GetByIdAsync(categoryId, "Products");

            if (category.Products != null && category.Products.Count >= 0)
                return category.Products.Count;

            return null;

            //return category.Products.Count ?? 0;

        }
    }
}
