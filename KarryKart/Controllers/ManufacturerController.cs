using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturers _iManufacturerRepository;
        public ManufacturerController(IManufacturers imanuRepository)
        {
            _iManufacturerRepository = imanuRepository;
        }



        [HttpGet(" GetManufacturer")]
        public async Task<IEnumerable<Manufacturer>> GetManufacturer()
        {
            var manu = await _iManufacturerRepository.GetManufacturer();
            return manu;
        }



        [HttpGet("GetManufacturerbyId")]
        public async Task<ActionResult<Manufacturer>> GetManufacturerbyId(int id)
        {
            var manu = await _iManufacturerRepository.GetManufacturerbyId(id);
            return manu;
        }
        [HttpGet("GetManufacturerByName")]
        public async Task<ActionResult<IQueryable<Manufacturer>>> GetManufacturerbyName(string name)
        {
            var pro = await _iManufacturerRepository.GetManufacturerbyName(name);
            return Ok(pro);
        }


        [HttpPost("AddManufacturer")]
        public async Task<ActionResult<Manufacturer>> AddManufacturer(Manufacturer manufacturers)
        {
            Manufacturer Response = new Manufacturer();
            if (manufacturers != null)
            {
                manufacturers.ManufacturerId = 0;
                Response = await _iManufacturerRepository.AddManufacturer(manufacturers);
            }

            return Response;
        }
        [HttpPut("UpdateManufacturer/{id}")]
        public async Task<ActionResult<Manufacturer>> UpdateManufacturer(int id, Manufacturer manu)
        {


            var update = await _iManufacturerRepository.UpdateManufacturer(manu);


            return update;
        }
        [HttpDelete("DeleteManufacturer/{id}")]
        public async Task<IActionResult> DeleteManufacturer(int id)
        {


            await _iManufacturerRepository.DeleteManufacturer(id);
            return NoContent();
        }



    }
}
