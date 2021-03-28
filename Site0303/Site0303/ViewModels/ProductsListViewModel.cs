using Site0303.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> AllProducts { get; set; }

        public string Category { get; set; }
    }
}
