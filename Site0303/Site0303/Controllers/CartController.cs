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
    public class CartController: Controller
    {
        private List<Product> _productsInCart;
        private int _price;
        public CartController()
        {
            _productsInCart = Cart.products;
            _price = Cart.price;
        }

        public ViewResult Index()
        {
            var obj = new CartViewModel
            {
                ProductsInCart = _productsInCart,
                Price = _price
            };
            return View(obj);
        }
        public RedirectToActionResult RemoveFromCart(int id,string returnUrl)
        {
            Cart.RemoveFromCart(_productsInCart.First(x=> x.Id == id));
            return RedirectToAction("Index");
        }
    }
}
