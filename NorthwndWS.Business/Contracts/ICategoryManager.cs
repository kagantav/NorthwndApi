using BaseLib.Utilities.ApiResponses;
using NorthwndWS.Model.Dtos.CategoryDtos;

namespace NorthwndWS.Business.Contracts
{
    public interface ICategoryManager
    {
        Task<ApiResponse<CategoryGetDto>> GetById(int id, params string[] includeList);
        Task<ApiResponse<List<CategoryGetDto>>> GetAllCategories(params string[] includeList);
        Task<ApiResponse<NoData>> AddCategory(CategoryPostDto dto);
        Task<ApiResponse<NoData>> UpdateCategory(CategoryPutDto dto);
        Task<ApiResponse<NoData>> DeleteCategory(int id);
        // VS.
    }
}
