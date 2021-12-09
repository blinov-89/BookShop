using System;

namespace BookShop.Products
{
    public interface IProduct
    {

        string Name { get; set; }

        string Author { get; set; }


        Decimal Price { get; set; }
        
    }
}