using System;
using System.Linq;
using BookShop.Calculation;
using BookShop.Products;

namespace BookShop.Promo
{
    public class TwoBooksPromo : IPromo
    {
        public TwoBooksPromo() { }

        public void Apply(OrderInfo orderInfo)
        {
            var pBooks = orderInfo.Items.Where(p => !p.IsPromoApplied)
                .Where(oi => oi.Product.GetType() == typeof(Book))
                .Where(oi => ((Book)oi.Product).TypeBook == FormatBook.Paper)
                .ToList();

            var targetAuthorDict = pBooks.GroupBy(oi => ((Book)oi.Product).Author).Select(group => new
            {
                Author = group.Key,
                Count = group.Count()
            });

            var targetAuthor = targetAuthorDict.FirstOrDefault(i => i.Count > 1)?.Author;

            if (targetAuthor is null)
                return;

            Book promoBook = new Book("Промо книга того же автора", targetAuthor, 0, FormatBook.Fb2);

            orderInfo.Items.Add(new OrderItem(promoBook, promoBook.Price, true));
        }
    }
}