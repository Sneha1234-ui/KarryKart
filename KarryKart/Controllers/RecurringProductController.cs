﻿using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecurringProductController : ControllerBase
    {
        private readonly IRecurringProduct _RecurringProduct;
        public RecurringProductController(IRecurringProduct Recurringproduct)
        {
            _RecurringProduct = Recurringproduct;
        }
        [HttpGet("GetRecurringProduct")]
        public async Task<IEnumerable<Recurring_Product>> GetRecurringProduct()
        {
            var category = await _RecurringProduct.GetRecurringProduct();
            return category;
        }
        [HttpGet("GetRecurringProductByID")]
        public async Task<ActionResult<Recurring_Product>> GetRecurringProductId(int id)
        {
            var manufracturer = await _RecurringProduct.GetRecurringProductById(id);
            return manufracturer;
        }
        [HttpGet("GetRecurringByName")]
        public async Task<ActionResult<IQueryable<Recurring_Product>>> GetRecurringbyName(string name)
        {
            var pro = await _RecurringProduct.GetRecurringProductByName(name);
            return Ok(pro);
        }
       
        [HttpPost("CreateRecurringProduct")]
        public async Task<ActionResult<Recurring_Product>> CreateRecurringProduct(Recurring_Product Recurringproduct)
        {
            Recurring_Product obj = new Recurring_Product();
            if (Recurringproduct != null)
            {
                obj = await _RecurringProduct.AddRecurringProduct(Recurringproduct);
            }
            return obj;
        }
        [HttpPut("UpdateRecurringproduct")]
        public async Task<ActionResult<Recurring_Product>> UpdateRecurringproduct(Recurring_Product Recurringproduct)
        {
            var update = await _RecurringProduct.UpdateRecurringProduct(Recurringproduct);
            return update;
        }

        [HttpDelete("DeleteRecurringproduct")]
        public async Task<IActionResult> DeleteRecurringproduct(int id)
        {
            await _RecurringProduct.DeleteRecurringProduct(id);
            return NoContent();
        }
    }
}