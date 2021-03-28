using Site0303.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.ViewModels
{
    public class CartViewModel
    {
        public IEnumerable<Product> ProductsInCart { get; set; }
        public int Price { get; set; }
    }
}
