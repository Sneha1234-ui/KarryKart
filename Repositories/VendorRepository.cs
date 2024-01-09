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
    public class VendorRepository : IVendorRepository
    {
        private readonly DataContext context;
        public VendorRepository(DataContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Vendors>> GetVendors()
        {
            return await context.Vendors.ToListAsync();
        }
        public async Task<Vendors> AddVendors(Vendors Vendors)
        {
            var result = await context.Vendors.AddAsync(Vendors);
            await context.SaveChangesAsync();
            return result.Entity;
        }





        public async Task<Vendors> GetVendorsbyId(int Id)
        {
            return await context.Vendors
                 .FirstOrDefaultAsync(V => V.VendorId == Id);
        }
       
        public async Task<IQueryable<Vendors>> GetVendorsByName(string name)

        {

            var query = from value in context.Vendors

                        where value.Name == name || value.Email == name

                        select value;

            return query;

        }

        public async Task<Vendors> UpdateVendors(Vendors Vendors)
        {
            var result = await context.Vendors
                 .FirstOrDefaultAsync(V => V.VendorId == Vendors.VendorId);

            if (result != null)
            {
                result.Name = Vendors.Name;
                result.Email = Vendors.Email;
                result.Company_name = Vendors.Company_name;
                result.Description = Vendors.Description;
                result.ModifiedBy = Vendors.ModifiedBy;
                result.Address = Vendors.Address;


                await context.SaveChangesAsync();
            }

            return result;
        }
        public async Task<Vendors> DeleteVendors(int vendorsId)
        {
            var result = await context.Vendors
               .FirstOrDefaultAsync(V => V.VendorId == vendorsId);
            if (result != null)
            {
                context.Vendors.Remove(result);
                await context.SaveChangesAsync();
            }
            return null;

        }
    }

}
