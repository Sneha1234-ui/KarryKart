
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
    public class SEORepo : ISEO
    {
        private readonly DataContext appDbContext;

        public SEORepo(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<IEnumerable<SEO>> GetSEO()
        {
            return await appDbContext.SEO.ToListAsync();
        }
        public async Task<SEO> GetSEObyId(int Id)
        {
            return await appDbContext.SEO.FirstOrDefaultAsync(p => p.Id == Id);
        }
        public async Task<SEO> AddSEO(SEO seo)
        {
            var result = await appDbContext.SEO.AddAsync(seo);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<SEO> UpdateSEO(SEO seo)
        {
            var result = await appDbContext.SEO
                .FirstOrDefaultAsync(p => p.Id == seo.Id);

            if (result != null)
            {

                result.Id = seo.Id;
                result.searchenginefriendlypagename = seo.searchenginefriendlypagename;
                result.MetaTitle = seo.MetaTitle;
                result.MetaKeywords = seo.MetaKeywords;
                result.MetaDescription = seo.MetaDescription;
                result.CreatedAt = seo.CreatedAt;
                result.IsDeleted = seo.IsDeleted;


                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }
        public async Task<SEO> DeleteSEO(int Id)
        {
            var result = await appDbContext.SEO
                .FirstOrDefaultAsync(p => p.Id == Id);
            if (result != null)
            {
                appDbContext.SEO.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
            return result;

        }

        public Task<SEO> DeleteSEO(SEO seo)
        {
            throw new NotImplementedException();
        }

        public Task<SEO> GetSEOById(int seoId)
        {
            throw new NotImplementedException();
        }
    }
}

