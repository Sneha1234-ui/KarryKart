using Entities.Models;
using Entities.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IProductrepo
    {
        Task<IEnumerable<Product>> GetProduct();
        Task<Product> GetProductbyId(int Id);
        Task<Product> AddProduct(Product Product);
        Task<Product> UpdateProduct(Product Product);
        Task<Product> DeleteProduct(int Id);
        Task<IQueryable<Product>> GetProductByName(string name);
        Task<IQueryable<Product>> SearchbyProductType(ProductTypeEnum status);

    }

}
