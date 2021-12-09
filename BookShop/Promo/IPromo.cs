using BookShop.Calculation;

namespace BookShop.Promo
{
    public interface IPromo
    {
        void Apply(OrderInfo orderInfo);
    }
}