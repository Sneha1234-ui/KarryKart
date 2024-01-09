using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class DiscountRepos:IDiscountRepos
    {
        private readonly DataContext appDbContext;

        public DiscountRepos(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Discounts>> GetDiscounts()
        {
            return await appDbContext.Discount.ToListAsync();

        }

        public async Task<Discounts> GetDiscountById(int DiscountId)
        {
            return await appDbContext.Discount
                .FirstOrDefaultAsync(p => p.Discount_ID == DiscountId);
        }

        public async Task<IQueryable<Discounts>> GetDiscountsByName(string name)
        {

            var query = from value in appDbContext.Discount
                        where value.Discount_Name == name || value.Created_By == name
                        select value;

            return query;
        }


        public async Task<Discounts> AddDiscounts(Discounts discount)
        {
            var result = await appDbContext.Discount.AddAsync(discount);
            await appDbContext.SaveChangesAsync();
            return result.Entity;

        }

        public async Task<Discounts> UpdateDiscounts(Discounts discount)
        {
            var result = await appDbContext.Discount
                .FirstOrDefaultAsync(p => p.Discount_ID == discount.Discount_ID);

            if (result != null)
            {

                result.Discount_Name = discount.Discount_Name;
                result.Discount_Type = discount.Discount_Type;
                result.Discount_Percent = discount.Discount_Percent;
                result.Created_At = discount.Created_At;
                result.Modified_At = discount.Modified_At;
                result.Created_By = discount.Created_By;
                result.Modified_By = discount.Modified_By;


                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;

        }

        public async Task<Discounts> DeleteDiscounts(int DiscountId)
        {
            var result = await appDbContext.Discount
               .FirstOrDefaultAsync(p => p.Discount_ID == DiscountId);
            if (result != null)
            {
                appDbContext.Discount.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
            return result;


        }
    }
}
   

