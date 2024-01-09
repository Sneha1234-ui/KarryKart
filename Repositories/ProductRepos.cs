using Contracts;
using Entities.Data;
using Entities.Models;
using Entities.Models.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepos : IProductrepo
    {
        private readonly DataContext appDbContext;

        public ProductRepos(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Product>> GetProduct()
        {
            return await appDbContext.Product.ToListAsync();
        }
        public async Task<Product> GetProductbyId(int Id)
        {
            return await appDbContext.Product
                .FirstOrDefaultAsync(p => p.ProductId == Id);
        }
        public async Task<IQueryable<Product>> GetProductByName(string name)
        {

            var query = from value in appDbContext.Product
                        where value.Name == name || value.ProductTags == name
                        select value;

            return query;
        }
        public Task<IQueryable<Product>> SearchbyProductType(ProductTypeEnum status)
        {
            var result = appDbContext.Product.
                Where(v => v.ProductType == status);

            return Task.FromResult(result.AsQueryable());
        }
        

        public async Task<Product> AddProduct(Product Product)
        {
            var result = await appDbContext.Product.AddAsync(Product);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Product> UpdateProduct(Product Product)
        {
            var result = await appDbContext.Product
                .FirstOrDefaultAsync(p => p.ProductId == Product.ProductId);

            if (result != null)
            {

                result.Name = Product.Name;
                result.FullDescription = Product.FullDescription;
                result.price = Product.price;
                result.AdminComment = Product.AdminComment;
                result.AvailableEndDate = Product.AvailableEndDate;


                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async Task<Product> DeleteProduct(int Id)
        {
            var result = await appDbContext.Product
                .FirstOrDefaultAsync(p => p.ProductId == Id);
            if (result != null)
            {
                appDbContext.Product.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
            return result;

        }
    }
}