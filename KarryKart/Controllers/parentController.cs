using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class parentController : ControllerBase
    {
        private readonly IParentrepo _iParentRepository;
        public parentController(IParentrepo iparentRepository)
        {
            _iParentRepository = iparentRepository;
        }


        // GET: api/TrainingStaffs/5
        [HttpGet(" GetParentCategory")]
        public async Task<IEnumerable<Parent_Category>> GetParentCategory()
        {
            var parentcategory = await _iParentRepository.GetParentCategory();
            return parentcategory;
        }



        [HttpGet("GetParentCategorybyId")]
        public async Task<ActionResult<Parent_Category>> GetParentCategorybyId(int id)
        {
            var parents = await _iParentRepository.GetParentCategorybyId(id);
            return parents;
        }


        [HttpPost("AddParentCategory")]
        public async Task<ActionResult<Parent_Category>> AddParentCategory(Parent_Category parentcategory)
        {
            Parent_Category parentResponse = new Parent_Category();
            if (parentcategory != null)
            {
                parentcategory.Id = 0;
                parentResponse = await _iParentRepository.AddParentCategory(parentcategory);
            }

            return parentResponse;
        }
        [HttpPut("UpdateParentCategory/{id}")]
        public async Task<ActionResult<Parent_Category>> UpdateParentCategory(int id, Parent_Category parentcategory)
        {


            var updateStudent = await _iParentRepository.UpdateParentCategory(parentcategory);


            return updateStudent;
        }
        [HttpDelete("DeleteParentCategory/{id}")]
        public async Task<IActionResult> DeleteParentCategory(int id)
        {


            await _iParentRepository.DeleteParentCategory(id);
            return NoContent();
        }



    }
}
