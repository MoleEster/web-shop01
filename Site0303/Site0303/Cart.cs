using Site0303.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303
{
    public static class Cart
    {
        public static List<Product> products = new List<Product>();

        public static int price;
        public static void AddToCart(Product product)
        {
            products.Add(product);
            price += product.Price;
        }

        public static void RemoveFromCart(Product product)
        {
            products.Remove(product);
            price -= product.Price;
        }
    }
}
