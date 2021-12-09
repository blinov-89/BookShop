using System;
using BookShop.Calculation;

namespace BookShop.PromoCodes
{
    public class SumDiscountPromoCode : IPromoCode
    {
        private decimal _sum;

        public SumDiscountPromoCode(decimal sum)
        {
            _sum = sum;
        }

        public void Apply(OrderInfo orderInfo)
        {
            orderInfo.Discount += Math.Min(_sum, orderInfo.TotalPrice);
        }
    }
}