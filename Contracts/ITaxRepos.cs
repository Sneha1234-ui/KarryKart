using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ITaxRepos
    {
        Task<IEnumerable<Tax>> GetTax();
        Task <Tax> GetTaxbyId(int Id);
        Task<Tax> AddTax(Tax tax);
        Task<Tax> UpdateTax(Tax tax);
        Task<Tax> DeleteTax(int Id);

    }
}
