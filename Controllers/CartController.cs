using Microsoft.AspNetCore.Http;
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
            List<CartItemDetails> res = _cartService.GetCartItemDetails().ToList();
            return View(res);
        }

        [HttpGet]
        public IActionResult AddToCart(int specificallyShoesId, decimal price)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            try
            {
                

                _cartService.addToCartItem((int)userId, specificallyShoesId, price);
            }
            catch (Exception ex)
            {
                TempData["Errormsg"] = ex.Message;
            }

            return RedirectToAction("Index", userId);
        }

        [HttpPost]
        public IActionResult Update(int cartItemId, int cartId, int quantity, int shoesId)
        {
            if (quantity == 0)
            {
                return RedirectToAction("Delete");
            }
             _cartService.UpdateCartItem(cartItemId,cartId, quantity, shoesId);
            TempData["Errormsg"] = "Quantity update can not be large than shoes quantity.";
            return RedirectToAction("Index");
        }

        
    }
}