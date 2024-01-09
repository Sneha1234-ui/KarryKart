using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IShippingRepos
    {
        Task<IEnumerable<Shipping>> GetShipping();
        Task<Shipping> GetShippingById(int Id);
        Task<Shipping> Addshipping(Shipping shipping);
        Task<Shipping> UpdateShipping(Shipping shipping);
        Task<Shipping> DeleteShipping(int Id);
        Task<IQueryable<Shipping>> GetShippingByName(string name);
    }
}

