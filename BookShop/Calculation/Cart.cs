using System.Collections.Generic;
using System.Linq;
using BookShop.Delivery;
using BookShop.Products;
using BookShop.Promo;
using BookShop.PromoCodes;

namespace BookShop.Calculation
{
    public class Cart
    {
        private readonly IDeliveryCalculator _deliveryCalculator;
        private readonly IPromoProvider _promoProvider;

        public Cart(IDeliveryCalculator deliveryCalculator, IPromoProvider promoProvider)
        {
            _deliveryCalculator = deliveryCalculator;
            _promoProvider = promoProvider;
        }

        public OrderInfo GetOrderInfo(List<IProduct> products, DeliveryType deliveryType, IPromoCode promoCode)
        {
            var orderInfo = new OrderInfo(products.Select(p => new OrderItem (p)).ToList(),
                                          _deliveryCalculator.Calculate(products, deliveryType));        

            promoCode?.Apply(orderInfo);
            _promoProvider.GetActivePromos().ForEach(p => p.Apply(orderInfo));

            return orderInfo;
        }
    }
}