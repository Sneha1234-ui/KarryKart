using Contracts;
using Entities.Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TaxRepos : ITaxRepos
    {
        private readonly DataContext appDbContext;

        public TaxRepos(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }



        public async Task<IEnumerable<Tax>> GetTax()
        {
            return await appDbContext.Tax.ToListAsync();
        }

        public async Task<Tax> GetTaxbyId(int Id)
        {
            return await appDbContext.Tax
                .FirstOrDefaultAsync(p => p.TaxId == Id);
        }

        public async Task<Tax> AddTax(Tax tax)
        {
            var result = await appDbContext.Tax.AddAsync(tax);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Tax> UpdateTax(Tax tax)
        {
            var result = await appDbContext.Tax
                .FirstOrDefaultAsync(p => p.TaxId == tax.TaxId);

            if (result != null)
            {

                result.TaxCode = tax.TaxCode;
                result.SGSTPercentage = tax.SGSTPercentage;
                result.CGSTPercentage = tax.CGSTPercentage;


                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async Task<Tax> DeleteTax(int Id)
        {
            var result = await appDbContext.Tax
                .FirstOrDefaultAsync(p => p.TaxId == Id);
            if (result != null)
            {
                appDbContext.Tax.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
            return result;

        }


    }
}

