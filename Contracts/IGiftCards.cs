public interface IGiftCard
{
    Task<IEnumerable<GiftCard>> GetGiftCard();
    Task<GiftCard> GetGiftCardId(int giftCardid);
    Task<GiftCard> AddGiftCard(GiftCard giftCard);
    Task<GiftCard> UpdateGiftCard(GiftCard giftCard);
    Task DeleteGiftCard(int giftCardid);
    Task<IQueryable<GiftCard>> GetGiftCardbyName(string Name);
    
}