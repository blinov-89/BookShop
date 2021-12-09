using System.Linq;
using BookShop.Calculation;
using BookShop.Products;

namespace BookShop.PromoCodes
{
    public class FreeBookPromoCode : IPromoCode
    {
        private readonly Book _book;

        public FreeBookPromoCode(Book book)
        {
            _book = book;
        }

        public void Apply(OrderInfo orderInfo)
        {
            var orderItem = orderInfo.Items.Where(p => !p.IsPromoApplied)
                .Where(oi => oi.Product.GetType() == typeof(Book))
                .FirstOrDefault(oi => oi.Product.Name == _book.Name && ((Book)oi.Product).TypeBook == _book.TypeBook);
            if (orderItem == null)
                return;

            orderItem.IsPromoApplied = true;
            orderItem.Discount = orderItem.FinalPrice;
        }
    }
}