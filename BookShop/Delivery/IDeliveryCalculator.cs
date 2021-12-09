using System.Collections.Generic;
using BookShop.Products;

namespace BookShop.Delivery
{
    public interface IDeliveryCalculator
    {
        decimal Calculate(List<IProduct> books, DeliveryType deliveryType);
    }
}