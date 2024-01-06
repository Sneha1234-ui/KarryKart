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
    public class CategoryRepository : Icategoryrepo
    {
        private readonly DataContext appDbContext;

        public CategoryRepository(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }



        public async Task<IEnumerable<Category>> GetCategory()
        {
            return await appDbContext.category.ToListAsync();
        }

        public async Task<Category> GetCategorybyId(int Id)
        {
            return await appDbContext.category
                .FirstOrDefaultAsync(p => p.CategoryId == Id);
        }

        public async Task<Category> AddCategory(Category category)
        {
            var result = await appDbContext.category.AddAsync(category);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            var result = await appDbContext.category
                .FirstOrDefaultAsync(p => p.CategoryId == category.CategoryId);

            if (result != null)
            {

                result.CategoryName = category.CategoryName;
                result.CategoryDescription = category.CategoryDescription;


                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async Task<Category> DeleteCategory(int Id)
        {
            var result = await appDbContext.category
                .FirstOrDefaultAsync(p => p.CategoryId == Id);
            if (result != null)
            {
                appDbContext.category.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
            return result;

        }

        
    }
}
