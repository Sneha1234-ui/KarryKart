using Contracts;
using Entities.Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repositories
{
    public class ParentCategoryRepository : IParentrepo
    {
        private readonly DataContext appDbContext;

        public ParentCategoryRepository(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

       

        public async Task<IEnumerable<Parent_Category>> GetParentCategory()
        {
            return await appDbContext.ParentCategory.ToListAsync();
        }

        public async Task<Parent_Category> GetParentCategorybyId(int Id)
        {
            return await appDbContext.ParentCategory
                .FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<Parent_Category> AddParentCategory(Parent_Category parentcategory)
        {
            var result = await appDbContext.ParentCategory.AddAsync(parentcategory);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Parent_Category> UpdateParentCategory(Parent_Category parentcategory)
        {
            var result = await appDbContext.ParentCategory
                .FirstOrDefaultAsync(p => p.Id == parentcategory.Id);

            if (result != null)
            {
               
                result.Parent_Category_Name = parentcategory.Parent_Category_Name;
                result.Description = parentcategory.Description;
                

                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async Task<Parent_Category> DeleteParentCategory(int Id)
        {
            var result = await appDbContext.ParentCategory
                .FirstOrDefaultAsync(p => p.Id == Id);
            if (result != null)
            {
                appDbContext.ParentCategory.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
            return result;

        }
    }
}
