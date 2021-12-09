using System.Collections.Generic;

namespace BookShop.Promo
{
    public interface IPromoProvider
    {
        List<IPromo> GetActivePromos();
    }
}