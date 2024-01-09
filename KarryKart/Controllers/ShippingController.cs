using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        private readonly IShippingRepos _iShippingRepository;
        public ShippingController(IShippingRepos iShippingRepository)
        {
            _iShippingRepository = iShippingRepository;
        }
        [HttpGet(" GetShipping")]
        public async Task<IEnumerable<Shipping>> GetShipping()
        {
            var shippings = await _iShippingRepository.GetShipping();
            return shippings;
        }
        [HttpGet("GetShippingbyId")]
        public async Task<ActionResult<Shipping>> GetShippingbyId(int id)
        {
            var Shipping = await _iShippingRepository.GetShippingById(id);
            return Shipping;
        }
        [HttpGet("GetShippingByName")]
        public async Task<ActionResult<IQueryable<Shipping>>> GetShippingbyName(string name)
        {
            var pro = await _iShippingRepository.GetShippingByName(name);
            return Ok(pro);
        }

        [HttpPost("AddShipping")]
        public async Task<ActionResult<Shipping>> AddShipping(Shipping shipping)
        {
            Shipping Response = new Shipping();
            if (shipping != null)
            {
                shipping.Id = 0;
                Response = await _iShippingRepository.Addshipping(shipping);
            }

            return Response;
        }
        [HttpPut("UpdateShipping/{id}")]
        public async Task<ActionResult<Shipping>> UpdateCategory(Shipping shipping)
        {


            var update = await _iShippingRepository.UpdateShipping(shipping);


            return update;
        }
        [HttpDelete("DeleteShipping/{id}")]
        public async Task<IActionResult> DeleteShipping(int id)
        {


            await _iShippingRepository.DeleteShipping(id);
            return NoContent();
        }
    }
}
