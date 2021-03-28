using Site0303.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> GetAllProducts { get; }
        IEnumerable<Product> GetFavProducts { get; }

        Product GetProduct(int ProductId);
    }
}
