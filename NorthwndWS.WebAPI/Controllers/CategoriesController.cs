using Microsoft.AspNetCore.Mvc;
using NorthwndWS.Business.Contracts;
using NorthwndWS.Model.Dtos.CategoryDtos;

namespace NorthwndWS.WebAPI.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;
        public CategoriesController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        // ...../api/categories/1 --* GET
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _categoryManager.GetById(id);
            return Ok(response);
        }

        // ...../api/categories  -- GET
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryManager.GetAllCategories();

            return Ok(response);
        }

        // ...../api/categories  -- POST
        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CategoryPostDto dto)
        {
            var response = await _categoryManager.AddCategory(dto);

            return Ok(response);
        }

        // ...../api/categories  -- PUT
        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] CategoryPutDto dto)
        {
            var response = await _categoryManager.UpdateCategory(dto);

            return Ok(response);
        }

        // ...../api/categories/1 -- DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            var response = await _categoryManager.DeleteCategory(id);

            return Ok(response);
        }
    }
}
