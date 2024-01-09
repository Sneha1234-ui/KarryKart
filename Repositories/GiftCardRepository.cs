using Entities.Data;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contracts;

namespace Repositories
{
    public class GiftCardRepo : IGiftCard
    {
        private readonly DataContext _dataContext;
        public GiftCardRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<GiftCard>> GetGiftCard()
        {
            return await _dataContext.GiftCards.ToListAsync();
        }
        public async Task<GiftCard> GetGiftCardId(int Id)
        {
            return await _dataContext.GiftCards.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<IQueryable<GiftCard>> GetGiftCardbyName(string name)
        {

            var query = from value in _dataContext.GiftCards
                        where value.CreatedBy == name || value.ModifiedBy == name
                        select value;

            return query;
        }
        public async Task<GiftCard> AddGiftCard(GiftCard giftcard)
        {
            var result = await _dataContext.GiftCards.AddAsync(giftcard);
            await _dataContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<GiftCard> UpdateGiftCard(GiftCard giftcard)
        {
            var result = await _dataContext.GiftCards
                .FirstOrDefaultAsync(e => e.Id == giftcard.Id);

            if (result != null)
            {
                result.Giftcard = giftcard.Giftcard;
                result.giftcardtype = giftcard.giftcardtype;
                result.Overriddengiftcardamount = giftcard.Overriddengiftcardamount;
                result.CreatedAt = giftcard.CreatedAt;
                result.CreatedBy = giftcard.CreatedBy;
                result.ModifiedAt = giftcard.ModifiedAt;
                result.ModifiedBy = giftcard.ModifiedBy;
                result.IsDeleted = giftcard.IsDeleted;


                await _dataContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task DeleteGiftCard(int Id)
        {
            var result = await _dataContext.GiftCards
                .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _dataContext.GiftCards.Remove(result);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}