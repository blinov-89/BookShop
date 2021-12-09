using System.Collections.Generic;
using BookShop.Products;

namespace BookShop.Promo
{
    public class PromoProvider : IPromoProvider
    {
        public List<IPromo> GetActivePromos()
        {
            return new List<IPromo>
            {
                new TwoBooksPromo()
            };
        }
    }
}