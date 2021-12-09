using System;

namespace BookShop.Products
{
    public class Book : IProduct
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public FormatBook TypeBook { get; set; }        

        public Book(string name, string author, decimal price, FormatBook format)
        {
            Name = name;
            Author = author;
            Price = price;
            TypeBook = format;
        }
    }
}