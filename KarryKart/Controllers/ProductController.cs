using Contracts;
using Entities.Models;
using Entities.Models.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductrepo _iProductRepository;
        public ProductController(IProductrepo iProductRepository)
        {
            _iProductRepository = iProductRepository;
        }

        [HttpGet(" GetProduct")]
        public async Task<IEnumerable<Product>> GetCategory()
        {
            var Product = await _iProductRepository.GetProduct();
            return Product;
        }
        [HttpGet("GetProductbyId")]
        public async Task<ActionResult<Product>> GetProductbyId(int Id)
        {
            var product = await _iProductRepository.GetProductbyId(Id);
            return product;
        }
        [HttpGet("GetProductByName")]
        public async Task<ActionResult<IQueryable<Product>>> GetProductbyName(string name)
        {
            var pro = await _iProductRepository.GetProductByName(name);
            return Ok(pro);
        }
        [HttpGet("GetProductByEnum")]
        public async Task<ActionResult<IQueryable<Inventory>>> GetInventoryByEnum(ProductTypeEnum status)
        {
            var result = await _iProductRepository.SearchbyProductType(status);
            return Ok(result);
        }
        [HttpPost("AddProduct")]
        public async Task<ActionResult<Product>> AddProduct(Product Product)
        {
            Product Response = new Product();
            if (Product != null)
            {
                Product.ProductId = 0;
                Response = await _iProductRepository.AddProduct(Product);
            }

            return Response;
        }
        [HttpPut("UpdateProduct/{id}")]
        public async Task<ActionResult<Product>> UpdateProduct(Product Product)
        {


            var update = await _iProductRepository.UpdateProduct(Product);


            return update;
        }
        [HttpDelete("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {


            await _iProductRepository.DeleteProduct(id);
            return NoContent();
        }
    }
}