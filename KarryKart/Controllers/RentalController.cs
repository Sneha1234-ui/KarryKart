using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IRentalRepo _iRentalRepository;
        public RentalController(IRentalRepo iRentalRepository)
        {
            _iRentalRepository = iRentalRepository;
        }

        [HttpGet(" GetRental")]
        public async Task<IEnumerable<Rental>> GetRental()
        {
            var Rental = await _iRentalRepository.GetRental();
            return Rental;
        }
        [HttpGet("GetRentalbyId")]
        public async Task<ActionResult<Rental>> GetRentalbyId(int Id)
        {
            var rental = await _iRentalRepository.GetRentalbyId(Id);
            return rental;
        }
        [HttpGet("GetRentalByName")]
        public async Task<ActionResult<IQueryable<Rental>>> GetRentalbyName(string name)
        {
            var pro = await _iRentalRepository.GetRentalByName(name);
            return Ok(pro);
        }
        
        [HttpPost("AddRental")]
        public async Task<ActionResult<Rental>> AddRental(Rental rental)
        {
            Rental Response = new Rental();
            if (rental != null)
            {
                rental.Id = 0;
                Response = await _iRentalRepository.AddRental(rental);
            }

            return Response;
        }
        [HttpPut("UpdateRental/{id}")]
        public async Task<ActionResult<Rental>> UpdateRental(Rental rental)
        {


            var update = await _iRentalRepository.UpdateRental(rental);


            return update;
        }
        [HttpDelete("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteRental(int id)
        {


            await _iRentalRepository.DeleteRental(id);
            return NoContent();
        }
    }
}