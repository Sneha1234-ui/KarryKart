﻿using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace karryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SEOController : ControllerBase
    {
        private readonly ISEO _SEO;
        public SEOController(ISEO seo)
        {
            _SEO = seo;
        }
        [HttpGet("GetSEO")]
        public async Task<IEnumerable<SEO>> GetSEO()
        {
            var player = await _SEO.GetSEO();
            return player;
        }

        [HttpGet("GetSEOById")]
        public async Task<ActionResult<SEO>> GetSEOById(int id)
        {
            var player = await _SEO.GetSEOById(id);
            return player;
        }
        [HttpGet("GetSEOByName")]
        public async Task<ActionResult<IQueryable<SEO>>> GetSEObyName(string name)
        {
            var pro = await _SEO.GetSEOByName(name);
            return Ok(pro);
        }
        [HttpPost("AddSEO")]
        public async Task<ActionResult<SEO>> AddSEO(SEO seo)
        {
            SEO obj = new SEO();
            if (seo != null)
            {
                obj = await _SEO.AddSEO(seo);
            }
            return obj;
        }
        [HttpPut("UpdateSEO")]
        public async Task<ActionResult<SEO>> UpdateSEO(SEO seo)
        {
            var update = await _SEO.UpdateSEO(seo);
            return update;
        }

    }
}