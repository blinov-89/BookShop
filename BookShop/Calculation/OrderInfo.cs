using System.Collections.Generic;
using System.Linq;

namespace BookShop.Calculation
{
    public class OrderInfo
    {
        public List<OrderItem> Items { get; set; }
        public decimal DeliveryPrice { get; set; }
        public decimal Discount { get; set; }

        public decimal FinalProductPrice => Items.Sum(i => i.FinalPrice);
        public decimal TotalPrice => FinalProductPrice + DeliveryPrice - Discount;

        public OrderInfo(List<OrderItem> items, decimal deliveryPrice, decimal discount = 0)
        {
            Items = items;
            DeliveryPrice = deliveryPrice;
            Discount = discount;
        }
    }
}