using Microsoft.AspNetCore.Mvc;
using Site0303.Data.Interfaces;
using Site0303.Data.Models;
using Site0303.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IAllCategories1 _allCategories1;

        public ProductsController(IAllProducts iallproducts, IAllCategories1 allCategories1)
        {
            _allProducts = iallproducts;
            _allCategories1 = allCategories1;
        }

        [Route("Products/List")]
        [Route("Products/List/{category}")]

        public ViewResult List(string category, string searchString)
        {
            IEnumerable<Product> products = null;
            if (string.IsNullOrEmpty(category) && String.IsNullOrEmpty(searchString))
            {
                products = _allProducts.GetAllProducts.OrderBy(i => i.Id);
                ViewBag.Title = "Весь ассортимент";
            }
            else if (!string.IsNullOrEmpty(category))
            {
                if (string.Equals("firearms", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.GetAllProducts.Where(p => p.Category1.category1Name.Equals("firearms")).OrderBy(i => i.Id);
                    category = "firearms";
                }
                else if (string.Equals("steel-arms", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.GetAllProducts.Where(p => p.Category1.category1Name.Equals("steel-arms")).OrderBy(i => i.Id);
                    category = "steel-arms";
                }
                ViewBag.Title = category;
            }
            else
            {
                products = from m in _allProducts.GetAllProducts select m;
                products = products.Where(p => p.Name.Contains(searchString,StringComparison.OrdinalIgnoreCase));
            }
            var listObj = new ProductsListViewModel
            {
                AllProducts = products,
                Category = category
            };
            return View(listObj);
        }
    }
}
