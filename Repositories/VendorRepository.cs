using Entities.Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

public class VendorRepository
{
    private readonly DataContext context;
    public VendorRepository(DataContext context)
    {
        this.context = context;
    }
    public async Task<Vendors> AddVendors(Vendors Vendors)
    {
        var result = await context.Vendors.AddAsync(Vendors);
        await context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Vendors> DeleteVendors(int vendorsId)
    {
        var result = await context.Vendors
           .FirstOrDefaultAsync(V => V.VendorId == vendorsId);
        if (result != null)
        {
            context.Vendors.Remove(result);
            await context.SaveChangesAsync();
        }
        return null;

    }

    public async Task<IEnumerable<Vendors>> GetVendors()
    {
        return await context.Vendors.ToListAsync();
    }

    public async Task<Vendors> GetVendors(int Id)
    {
        return await context.Vendors
             .FirstOrDefaultAsync(V => V.VendorId == Id);
    }

    public async Task<Vendors> UpdateVendors(Vendors Vendors)
    {
        var result = await context.Vendors
             .FirstOrDefaultAsync(V =>  V.VendorId == Vendors.VendorId);

        if (result != null)
        {
            result.Name = Vendors.Name;
            result.Email = Vendors.Email;
            result.Company_name = Vendors.Company_name;
            result.Description = Vendors.Description;
            

            await context.SaveChangesAsync();

            return result;
        }

        return null;
    }

}
