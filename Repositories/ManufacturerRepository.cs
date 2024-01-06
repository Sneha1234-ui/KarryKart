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



        public async Task<IEnumerable<Manufacturers>> GetManufacturer()
        {
            return await appDbContext.manufacturer.ToListAsync();
        }

        public async Task<Manufacturers> GetManufacturerbyId(int Id)
        {
            return await appDbContext.manufacturer
                .FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<Manufacturers> AddManufacturer(Manufacturers manufacturers)
        {
            var result = await appDbContext.manufacturer.AddAsync(manufacturers);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Manufacturers> UpdateManufacturer(Manufacturers manufacturers)
        {
            var result = await appDbContext.manufacturer
                .FirstOrDefaultAsync(p => p.Id == manufacturers.Id);

            if (result != null)
            {

                result.ManufacturerName = manufacturers.ManufacturerName;
                result.ManufacturerDescription = manufacturers.ManufacturerDescription;


                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async Task<Manufacturers> DeleteManufacturer(int Id)
        {
            var result = await appDbContext.manufacturer
                .FirstOrDefaultAsync(p => p.Id == Id);
            if (result != null)
            {
                appDbContext.manufacturer.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
            return result;

        }
    }
}
