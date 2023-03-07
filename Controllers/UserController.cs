
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
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        

        [HttpPost]
        public IActionResult Register(string name, string username, string pwd, string phone, string email)
        {
            return View(_userService.Register(name, username, pwd, phone, email));
        }

        [HttpGet]
        public IActionResult ShowShoes()
        {
            return View(_userService.ShowShoes());
        }
    }
}
