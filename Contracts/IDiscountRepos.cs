using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IDiscountRepos
    {
        Task<IEnumerable<Discounts>> GetDiscounts(); // search
        Task<Discounts> GetDiscountById(int DiscountId); // search by id
        Task<Discounts> AddDiscounts(Discounts discount); // add new
        Task<Discounts> UpdateDiscounts(Discounts discount); // edit
        Task<Discounts> DeleteDiscounts(int DiscountId); // delete
    }
}
