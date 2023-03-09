using Microsoft.AspNetCore.Mvc;
using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRN211_ShoesStore.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Index()
        {
            List<CartItem> res = _cartService.GetCartItemDetails().ToList();
            return View(res);
        }

        [HttpPost]
        public IActionResult AddToCart(int UserId, int SpecificallyShoesId, int Quantity, decimal Price)
        {
            try
            {
                _cartService.addToCartItem(UserId, SpecificallyShoesId, Quantity, Price);
            }
            catch (Exception ex)
            {
                TempData["Errormsg"] = ex.Message;
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult IncreaseQuantity(int cartId, int SpecificallyShoesId, int Quantity, decimal Price)
        {
            try
            {
                _cartService.addToCartItem(cartId, SpecificallyShoesId, Quantity, Price);
            }
            catch (Exception ex)
            {
                TempData["Errormsg"] = ex.Message;
            }

            return RedirectToAction("Index");
        }
    }
}