using Entities.Models;
namespace Contracts
{
    public interface IManufacturers
    {
        Task<IEnumerable<Manufacturers>> GetManufacturer();
        Task<Manufacturers> GetManufacturerbyId(int id);
        Task<Manufacturers> AddManufacturer(Manufacturers manufaturer);
        Task<Manufacturers> UpdateManufacturer(Manufacturers manufaturer);
        Task <Manufacturers> DeleteManufacturer(int id);
    }






}
