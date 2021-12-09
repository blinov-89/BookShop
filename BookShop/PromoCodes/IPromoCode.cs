using BookShop.Calculation;

namespace BookShop.PromoCodes
{
    public interface IPromoCode
    {
        void Apply(OrderInfo orderInfo);
    }
}