using BookShop.Products;

namespace BookShop.Calculation
{
    public class OrderItem
    {
        public IProduct Product { get; set; }
        public decimal Discount { get; set; }
        public bool IsPromoApplied { get; set; }

        public decimal InitialPrice => Product.Price;
        
        public decimal FinalPrice => InitialPrice - Discount;

        public OrderItem(IProduct product, decimal discsount = 0, bool isPromoApplied = false)
        {
            Product = product;
            Discount = discsount;
            IsPromoApplied = isPromoApplied;
        }
    }
}