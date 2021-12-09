using System;
using System.Collections.Generic;
using BookShop.Calculation;
using BookShop.Delivery;
using BookShop.Products;
using BookShop.Promo;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var deliveryCalculator = new DeliveryCalculator();
            var promoProvider = new PromoProvider();
            var cart = new Cart(deliveryCalculator, promoProvider);

            var orderInfo = cart.GetOrderInfo(
                new List<IProduct>
                {
                    new Book("Name1", "Author_2", 400,FormatBook.Paper),
                    new Book( "Name2","Author_2", 700, FormatBook.Paper),
                    new Book ("Name3","Author3", 100, FormatBook.Paper),
                    new Book("Name4","Author_1", 200, FormatBook.Fb2),

                }, DeliveryType.Delivery, null);

            Console.WriteLine(orderInfo.TotalPrice);
            orderInfo.Items.ForEach(item => Console.WriteLine(item.Product.Name + ", " + item.Product.Author));
        }
    }
}