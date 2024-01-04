using Entities.Models;
namespace Contracts
{



    public interface Icategoryrepo
    {
        Task<IEnumerable<Category>> GetCategory();
        Task<Category> GetCategorybyId(int Id);
        Task<Category> AddCategory(Category category);
        Task<Parent_Category> UpdateCategory(Category category);
        Task<Parent_Category> DeleteCategory(int Id);


    }


}
