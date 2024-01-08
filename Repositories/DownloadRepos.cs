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
    public class DownloadRepos : IDownload
    {
        private readonly DataContext appDbContext;

        public DownloadRepos(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<IEnumerable<DownloadableProduct>> GetDownloadableProducts()
        {
            return await appDbContext.DownloadProduct.ToListAsync();
        }

        public async Task<DownloadableProduct> GetDownloadableProductById(int Id)
        {
            return await appDbContext.DownloadProduct
                .FirstOrDefaultAsync(p => p.Id == Id);
        }
        public async Task<DownloadableProduct> AddDownloadableProduct(DownloadableProduct downloadableProduct)
        {
            var result = await appDbContext.DownloadProduct.AddAsync(downloadableProduct);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<DownloadableProduct> UpdateDownloadableProduct(DownloadableProduct downloadableProduct)
        {
            var result = await appDbContext.DownloadProduct
                .FirstOrDefaultAsync(p => p.Id == downloadableProduct.Id);

            if (result != null)
            {
                result.DownloadURL = downloadableProduct.DownloadURL;
                result.NoofDays = downloadableProduct.NoofDays;
                result.UsedownloadURL = downloadableProduct.UsedownloadURL;
                result.CreatedAt = downloadableProduct.CreatedAt;
                result.CreatedBy = downloadableProduct.CreatedBy;
                result.ModifiedAt = downloadableProduct.ModifiedAt;
                result.ModifiedBy = downloadableProduct.ModifiedBy;



                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async Task<DownloadableProduct> DeleteDownloadableProduct(int Id)
        {
            var result = await appDbContext.DownloadProduct
                .FirstOrDefaultAsync(p => p.Id == Id);
            if (result != null)
            {
                appDbContext.DownloadProduct.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
            return result;

        }
    }
}
