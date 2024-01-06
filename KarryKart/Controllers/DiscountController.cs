using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using System;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountRepos _iDiscountRepository;
        public DiscountController(IDiscountRepos iDiscountRepository)
        {
            _iDiscountRepository = iDiscountRepository;
        }
        [HttpGet(" GetDiscount")]
        public async Task<IEnumerable<Discounts>> GetDiscount()
        {
            var discount = await _iDiscountRepository.GetDiscounts();
            return discount;
        }
        [HttpGet("GetDiscountbyId")]
        public async Task<ActionResult<Discounts>> GetDiscountbyId(int id)
        {
            var discount = await _iDiscountRepository.GetDiscountById(id);
            return discount;
        }
        [HttpPost("AddDiscount")]
        public async Task<ActionResult<Discounts>> AddDiscount(Discounts discount)
        {
            Discounts Response = new Discounts();
            if (discount != null)
            {
                discount.Discount_ID = 0;
                Response = await _iDiscountRepository.AddDiscounts(discount);
            }

            return Response;
        }
        [HttpPut("UpdateDiscount/{id}")]
        public async Task<ActionResult<Discounts>> UpdateDiscount(Discounts discount)
        {


            var update = await _iDiscountRepository.UpdateDiscounts(discount);


            return update;
        }
        [HttpDelete("DeleteDiscount/{id}")]
        public async Task<IActionResult> DeleteDiscount(int Id)
        {


            await _iDiscountRepository.DeleteDiscounts(Id);
            return NoContent();
        }
    }
}