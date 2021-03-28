using Site0303.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> FavProducts { get; set; }
    }
}
