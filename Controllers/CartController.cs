using Microsoft.AspNetCore.Mvc;
using PRN211_ShoesStore.Models.DTO;
using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Service;
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
        
        public IActionResult AddToCart(int UserId , int SpecificallyShoesId, string SpecificallyShoesnName, int Quantity, decimal Price)
        {
            return View();
        }
    }
}
