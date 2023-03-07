using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRN211_ShoesStore.Models;
using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Repository;
using PRN211_ShoesStore.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PRN211_ShoesStore.Controllers
{
    public class HomeController : Controller
    {
        private UserRepository userRepository;

        private UserService _userService;

        private RoleRepository roleRepository;

        private readonly ILogger<HomeController> _logger;

        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor, UserRepository _userRepository, RoleRepository _roleRepository, UserService userService)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            userRepository = _userRepository;
            roleRepository = _roleRepository;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View("Views/Home/Index.cshtml");
        }

        public IActionResult Login()
        {
            return View("Views/Home/Login.cshtml");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "FirstName should not contain numbers.")] string firstName, [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "LastName should not contain numbers.")] string lastName, string username, string pwd, string confirmPwd, [RegularExpression(@"^\d{10}$", ErrorMessage = "Please enter a valid 10-digits number.")]string phone, string email)
        {
            Object obj = _userService.Register(firstName + " " + lastName, username, pwd, confirmPwd, phone, email);
            if (obj is string)
            {
                ModelState.AddModelError("error", obj.ToString());
                return RedirectToAction("Error");
            }
            User user = (User)obj;
            return View(user);
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
           var data = userRepository.GetAll().Include(x => x.role).Where(p => p.username.Equals(username) && p.password.Equals(password)).ToList();   
            if (data.Count() > 0)
            {
                User user = data.FirstOrDefault();
                if (user.role.roleName.Equals("User"))
                {
                    HttpContext.Session.SetString("password", user.password);
                    HttpContext.Session.SetString("name", user.name);
                    HttpContext.Session.SetString("email", user.email);
                    HttpContext.Session.SetString("userId", user.id.ToString());
                    HttpContext.Session.SetString("userRole", user.role.roleName);
                    HttpContext.Session.SetString("phone", user.phone);
                    return RedirectToAction("Index", "User");
                }
                if (user.role.roleName.Equals("Admin"))
                {
                    HttpContext.Session.SetString("username", user.username);
                    HttpContext.Session.SetString("name", user.name);
                    HttpContext.Session.SetString("email", user.email);
                    HttpContext.Session.SetString("userId", user.id.ToString());
                    HttpContext.Session.SetString("userRole", user.role.roleName);
                    return RedirectToAction("ShowShoes", "User");
                }

                if (user.status == true)
                {
                    ViewBag.error = "Your account is expired";
                    return RedirectToAction("Index");
                }
            }
            ViewBag.error = "Username or Password is invalid";
            return RedirectToAction("Index", "HomeController");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
