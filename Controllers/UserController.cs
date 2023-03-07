
using Microsoft.AspNetCore.Mvc;
using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Repository;
using PRN211_ShoesStore.Service;

namespace PRN211_ShoesStore.Controllers
{
    public class UserController : Controller
    {
        private UserService _userService = new UserService();

        private RoleRepository roleRepository= new RoleRepository();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search(string name)
        {
            return RedirectToAction("ShowShoes  ", _userService.Search(name));
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShowShoes()
        {
            return View(_userService.ShowShoes());
        }
    }
}
