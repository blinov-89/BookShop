using System;
using System.Collections.Generic;
using System.Linq;
using BookShop.Products;

namespace BookShop.Delivery
{
    public class DeliveryCalculator : IDeliveryCalculator
    {
        public decimal Calculate(List<IProduct> books, DeliveryType deliveryType)
        {
            switch (deliveryType)
            {
                case DeliveryType.Delivery:
                    var hasBook = books.OfType<Book>().Any();
                    if (!hasBook)
                        throw new NoBookException();
                    if(books.Count == 1)
                    {
                        var book = (Book)books.First();
                        if (book.TypeBook == FormatBook.Fb2) return 0;
                    }
                    var sum = books.Sum(p => p.Price);
                    if (sum < 1000)
                        return 200;
                    return 0;
                case DeliveryType.Pickup:
                    return 0;
                default:
                    throw new ArgumentOutOfRangeException(nameof(deliveryType), deliveryType, null);
            }
        }
    }
}