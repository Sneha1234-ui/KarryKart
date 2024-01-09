using Entities.Models;
namespace Contracts
{
   

    
        public interface IParentrepo
        {
            Task<IEnumerable<Parent_Category>> GetParentCategory();
            Task<Parent_Category> GetParentCategorybyId(int Id);
            Task<Parent_Category> AddParentCategory(Parent_Category parentcategory);
            Task<Parent_Category> UpdateParentCategory(Parent_Category parentcategory);
            Task<Parent_Category> DeleteParentCategory(int Id);
            Task<IQueryable<Parent_Category>> GetParentCategoryByName(string name);


    }
    

}
