﻿using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftCardController : ControllerBase
    {
        private readonly IGiftCard _context;
        public GiftCardController(IGiftCard context)
        {
            _context = context;
        }
        [HttpGet("GetGiftCard")]
        public async Task<IEnumerable<GiftCard>> GetGiftCard()
        {
            var pro = await _context.GetGiftCard();
            return pro;
        }

        [HttpGet("GetGiftCardId")]
        public async Task<ActionResult<GiftCard>> GetGiftCardById(int giftCardid)
        {
            var pro = await _context.GetGiftCardId(giftCardid);
            return pro;
        }

        [HttpGet("GetGiftCardByName")]
        public async Task<ActionResult<IQueryable<GiftCard>>> GetGiftCardbyName(string name)
        {
            var pro = await _context.GetGiftCardbyName(name);
            return Ok(pro);
        }
        [HttpPost("CreateGiftCard")]
        public async Task<ActionResult<GiftCard>> CreateGiftCard(GiftCard giftCard)
        {
            var pro = await _context.AddGiftCard(giftCard);
            return pro;
        }
        [HttpPut("UpdateGiftCard")]
        public async Task<ActionResult<GiftCard>> UpdateGiftCard(GiftCard giftCard)
        {
            var pro = await _context.UpdateGiftCard(giftCard);
            return pro;
        }
        [HttpDelete("DeleteGiftCard")]
        public async Task<IActionResult> DeleteGiftCard(int id)
        {
            await _context.DeleteGiftCard(id);
            return NoContent();
        }
    }
}

