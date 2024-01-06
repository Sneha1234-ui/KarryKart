using Entities.Models;
namespace Contracts
{



    public interface Icategoryrepo
    {
        Task<IEnumerable<Category>> GetCategory();
        Task<Category> GetCategorybyId(int Id);
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(Category category);
        Task<Category> DeleteCategory(int Id);


    }


}
