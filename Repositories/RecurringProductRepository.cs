using Contracts;
using Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace Repositories
{
    public class RecurringProductRepo : IRecurringProduct
    {
        private readonly DataContext appDbContext;

        public RecurringProductRepo(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Recurring_Product>> GetRecurringProduct()
        {
            return await appDbContext.RecurringProduct.ToListAsync();
        }
        public async Task<Recurring_Product> GetRecurringProductById(int Id)
        {
            return await appDbContext.RecurringProduct
                .FirstOrDefaultAsync(r => r.Id == Id);
        }
        public async Task<IQueryable<Recurring_Product>> GetRecurringProductByName(string name)
        {

            var query = from value in appDbContext.RecurringProduct
                        where value.CreatedBy == name || value.ModifiedBy == name
                        select value;

            return query;
        }

        public async Task<Recurring_Product> AddRecurringProduct(Recurring_Product recprod)
        {
            var result = await appDbContext.RecurringProduct.AddAsync(recprod);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Recurring_Product> UpdateRecurringProduct(Recurring_Product recprod)
        {
            var result = await appDbContext.RecurringProduct
                .FirstOrDefaultAsync(r => r.Id == recprod.Id);

            if (result != null)
            {
                result.Period = recprod.Period;
                result.Cycle_Length = recprod.Cycle_Length;
                result.Total_Cycle = recprod.Total_Cycle;
                result.CreatedAt = recprod.CreatedAt;
                result.CreatedBy = recprod.CreatedBy;
                result.ModifiedBy = recprod.ModifiedBy;
                result.ModifiedAt = recprod.ModifiedAt;
                result.IsDeleted = recprod.IsDeleted;

                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }
        public async Task DeleteRecurringProduct(int Id)
        {
            var result = await appDbContext.RecurringProduct
                 .FirstOrDefaultAsync(r => r.Id == Id);
            if (result != null)
            {
                appDbContext.RecurringProduct.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
        }
    }
}