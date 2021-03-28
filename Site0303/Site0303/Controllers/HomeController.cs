using Microsoft.AspNetCore.Mvc;
using Site0303.Data.Interfaces;
using Site0303.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.Data.Controllers
{
    public class HomeController:Controller
    {
        private IAllProducts _allProducts;

        public HomeController(IAllProducts all)
        {
            _allProducts = all;
        }

        public ViewResult Index()
        {
            var homeProducts = new HomeViewModel
            {
                FavProducts = _allProducts.GetFavProducts
            };
              
            return View(homeProducts);
        }
     }
}
