using Microsoft.EntityFrameworkCore;
using Site0303.Data.Interfaces;
using Site0303.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.Data
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDbContent appDbContent;
        public ProductRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Product> GetAllProducts => appDbContent.Product.Include(c => c.Category1);

        public IEnumerable<Product> GetFavProducts => appDbContent.Product.Where(p => p.IsFavorite == true);

        public Product GetProduct(int ProductId) => appDbContent.Product.FirstOrDefault(p => p.Id == ProductId);
    }
}
