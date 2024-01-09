using Entities.Models;

public interface IVendorRepository
{
    Task<IEnumerable<Vendors>> GetVendors();
    Task<Vendors> GetVendorsbyId(int Id);
    Task<Vendors> AddVendors(Vendors Vendors);
    Task<Vendors> UpdateVendors(Vendors Vendors);
    Task<Vendors> DeleteVendors(int vendorsId);
    Task<IQueryable<Vendors>> GetVendorsByName(string name);
}