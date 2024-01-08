using Contracts;
using Entities.Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ShippingRepos : IShippingRepos
    {
        private readonly DataContext appDbContext;

        public ShippingRepos(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Shipping>> GetShipping()
        {
            return await appDbContext.Shipping.ToListAsync();
        }
        public async Task<Shipping> GetShippingById(int Id)
        {
            return await appDbContext.Shipping
                .FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<Shipping> Addshipping(Shipping shipping)
        {
            var result = await appDbContext.Shipping.AddAsync(shipping);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Shipping> UpdateShipping(Shipping shipping)
        {
            var result = await appDbContext.Shipping
                .FirstOrDefaultAsync(p => p.Id == shipping.Id);

            if (result != null)
            {
                result.AdditionalShippingCharges = shipping.AdditionalShippingCharges;
                result.Width = shipping.Width;
                result.Height = shipping.Height;
                result.Weight = shipping.Weight;
                result.CreatedAt = shipping.CreatedAt;
                result.FreeShipping = shipping.FreeShipping;
                result.CreatedBy = shipping.CreatedBy;
                result.ModifiedBy = shipping.ModifiedBy;
                result.ModifiedAt = shipping.ModifiedAt;
                result.IsDeleted = shipping.IsDeleted;





                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }
        public async Task<Shipping> DeleteShipping(int Id)
        {
            var result = await appDbContext.Shipping
                .FirstOrDefaultAsync(p => p.Id == Id);
            if (result != null)
            {
                appDbContext.Shipping.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
            return result;

        }
    }
}