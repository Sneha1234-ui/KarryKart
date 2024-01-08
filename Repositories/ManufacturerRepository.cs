using Contracts;
using Entities.Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repositories
{
    public class ManufacturerRepository : IManufacturers
    {
        private readonly DataContext appDbContext;

        public ManufacturerRepository(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }



        public async Task<IEnumerable<Manufacturer>> GetManufacturer()
        {
            return await appDbContext.manufacturers.ToListAsync();
        }

        public async Task<Manufacturer> GetManufacturerbyId(int Id)
        {
            return await appDbContext.manufacturers
                .FirstOrDefaultAsync(p => p.ManufacturerId == Id);
        }

        public async Task<Manufacturer> AddManufacturer(Manufacturer manufacturers)
        {
            var result = await appDbContext.manufacturers.AddAsync(manufacturers);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Manufacturer> UpdateManufacturer(Manufacturer manufacturers)
        {
            var result = await appDbContext.manufacturers
                .FirstOrDefaultAsync(p => p.ManufacturerId == manufacturers.ManufacturerId);

            if (result != null)
            {

                result.ManufacturerName = manufacturers.ManufacturerName;
                result.ManufacturerDescription = manufacturers.ManufacturerDescription;
                result.CreatedAt = manufacturers.CreatedAt;
                result.ModifiedAt = manufacturers.ModifiedAt;
                result.CreatedBy = manufacturers.CreatedBy;
                result.ModifiedBy = manufacturers.ModifiedBy;


                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async Task<Manufacturer> DeleteManufacturer(int Id)
        {
            var result = await appDbContext.manufacturers
                .FirstOrDefaultAsync(p => p.ManufacturerId == Id);
            if (result != null)
            {
                appDbContext.manufacturers.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
            return result;

        }
    }
}
