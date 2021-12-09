using BookShop.Calculation;

namespace BookShop.PromoCodes
{
    public class FreeDeliveryPromoCode : IPromoCode
    {
        public void Apply(OrderInfo orderInfo)
        {
            orderInfo.Discount += orderInfo.DeliveryPrice;
        }
    }
}