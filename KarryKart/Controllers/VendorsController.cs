using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorsController : ControllerBase
    {
        private readonly IVendorRepository _vendorRepository;
        public VendorsController(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }
        [HttpGet("GetVendors")]
        public async Task<IEnumerable<Vendors>> GetVendors()
        {
            var vendors = await _vendorRepository.GetVendors();
            return vendors;
        }
        [HttpPost("Add Vendors")]
        public async Task<ActionResult<Vendors>> AddVendors(Vendors vendors)
        {
            Vendors vendors1 = new Vendors();
            if (vendors != null)
            {
                vendors.VendorId = 0;
                vendors = await _vendorRepository.AddVendors(vendors);
            }

            return vendors;
        }
        [HttpGet("GetVendorsById")]
        public async Task<ActionResult<Vendors>> GetVendorsByID(int id)
        {
            var vendors = await _vendorRepository.GetVendorsbyId(id);
            return vendors;
        }
        [HttpGet("GetVendorsByName")]
        public async Task<ActionResult<IQueryable<Vendors>>> GetVendorsbyName(string name)
        {
            var pro = await _vendorRepository.GetVendorsByName(name);
            return Ok(pro);
        }
        [HttpGet("UpdateVendors/{Id}")]
        public async Task<ActionResult<Vendors>> UpdateVendors(Vendors vendors)
        {
            var Updatedproducts = await _vendorRepository.UpdateVendors(vendors);
            return Updatedproducts;

        }
        [HttpDelete("Delete/{id}")]

        public async Task<ActionResult<Vendors>> DeleteVendors(int ID)
        {
            await _vendorRepository.DeleteVendors(ID);
            return NoContent();

        }

    }
}