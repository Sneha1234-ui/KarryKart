using Entities.Models;
namespace Contracts
{
    public interface IManufacturers
    {
        Task<IEnumerable<Manufacturer>> GetManufacturer();
        Task<Manufacturer> GetManufacturerbyId(int id);
        Task<Manufacturer> AddManufacturer(Manufacturer manufaturer);
        Task<Manufacturer> UpdateManufacturer(Manufacturer manufaturer);
        Task<Manufacturer> DeleteManufacturer(int id);
    }






}
