using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site0303.Data.Interfaces;
using Site0303.Data.Models;
using Site0303.ViewModels;

namespace Site0303.Controllers
{
    public class ExactItemController:Controller
    {
        private readonly IAllProducts _allProducts;
        public ExactItemController(IAllProducts all)
        {
            _allProducts = all;
        }

        [Route("Products/ExactItem/{id}")]
        public ViewResult ExactItem(int id)
        {
            var ExactItem = new ExactItemViewModel
            {
                ExactProduct = _allProducts.GetProduct(id)
            };
            return View(ExactItem);
        }

        [HttpPost]
        public void AddToCart(int id)
        {
            Cart.AddToCart(_allProducts.GetProduct(id));
        }
    }
}
