using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KarryKart.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly Icategoryrepo _iCategoryRepository;
        public CategoryController(Icategoryrepo iCategoryRepository)
        {
            _iCategoryRepository = iCategoryRepository;
        }
        [HttpGet(" GetCategory")]
        public async Task<IEnumerable<Category>> GetCategory()
        {
            var category = await _iCategoryRepository.GetCategory();
            return category;
        }
        [HttpGet("GetCategorybyId")]
        public async Task<ActionResult<Category>> GetCategorybyId(int id)
        {
            var category = await _iCategoryRepository.GetCategorybyId(id);
            return category;
        }

        [HttpGet("GetCategorybByName")]
        public async Task<ActionResult<IQueryable<Category>>> GetParentByName(string name)
        {
            var pro = await _iCategoryRepository.GetCategoryByName(name);
            return Ok(pro);
        }

        [HttpPost("AddCategory")]
        public async Task<ActionResult<Category>> AddCategory(Category category)
        {
            Category Response = new Category();
            if (category != null)
            {
                category.CategoryId = 0;
                Response = await _iCategoryRepository.AddCategory(category);
            }

            return Response;
        }
        [HttpPut("UpdateCategory/{id}")]
        public async Task<ActionResult<Category>> UpdateCategory(int id, Category category)
        {


            var update = await _iCategoryRepository.UpdateCategory(category);


            return update;
        }
        [HttpDelete("DeleteCategory/{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {


            await _iCategoryRepository.DeleteCategory(id);
            return NoContent();
        }
    }
}