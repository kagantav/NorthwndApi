using AutoMapper;
using BaseLib.Utilities.ApiResponses;
using NorthwndWS.Business.Contracts;
using NorthwndWS.DataAccess.Contracts.Repositories;
using NorthwndWS.Model.Dtos.CategoryDtos;
using NorthwndWS.Model.Entities;

namespace NorthwndWS.Business.Implementations
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryRepository categoryRepository,IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<ApiResponse<NoData>> AddCategory(CategoryPostDto dto)
        {
            // validasyon
            // eğer validasyondan geçmediyse : 

            // return ApiResponse<NoData>.Fail(400,new List<string>(){"İsim boş bırakılamaz","ggggdgd","gdfgdf"})

            // validasyondan geçti
            // ama exception yakalandı
            // return ApiResponse<NoData>.Fail(500,new List<string>(){"ghhfg","ggggdgd","gdfgdf"})

            var entity = _mapper.Map<Category>(dto);

            await _categoryRepository.InsertAsync(entity);

            return ApiResponse<NoData>.Success(200);
        }

        public async Task<ApiResponse<NoData>> DeleteCategory(int id)
        {
            // validasyon
            await _categoryRepository.DeleteAsync(id);

            return ApiResponse<NoData>.Success(200);
        }

        public async Task<ApiResponse<List<CategoryGetDto>>> GetAllCategories(params string[] includeList)
        {
            // İş Süreçleri
            List<Category> categories = await _categoryRepository.GetAllAsync(includeList);

            List<CategoryGetDto> list = _mapper.Map<List<CategoryGetDto>>(categories);

            return ApiResponse<List<CategoryGetDto>>.Success(200, list);
        }

        public async Task<ApiResponse<CategoryGetDto>> GetById(int id, params string[] includeList)
        {
            // Logla
            // Cache
            // İş Süreçleri

            Category category = await _categoryRepository.GetByIdAsync(id, includeList);

            CategoryGetDto dto = _mapper.Map<CategoryGetDto>(category);

            return ApiResponse<CategoryGetDto>.Success(200, dto);

        }

        public async Task<ApiResponse<NoData>> UpdateCategory(CategoryPutDto dto)
        {
            // validasyon
            var entity = _mapper.Map<Category>(dto);
            await _categoryRepository.UpdateAsync(entity);

            return ApiResponse<NoData>.Success(200);
        }
    }
}
