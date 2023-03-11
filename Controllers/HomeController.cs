using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PRN211_ShoesStore.Models;
using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Repository;
using PRN211_ShoesStore.Service;
using PRN211_ShoesStore.Utils;
using System;
using System.Diagnostics;
using System.Linq;
namespace PRN211_ShoesStore.Controllers
{
    public class HomeController : Controller
    {
        private UserRepository userRepository;

        private UserService _userService;

        private RoleRepository roleRepository;

        private readonly IShoesService _shoesService;

		private readonly ICategoryService _categoryService;

		private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
            UserRepository _userRepository, 
            RoleRepository _roleRepository, 
            UserService userService, 
            IShoesService shoesService,
			ICategoryService categoryService)
        {
            _logger = logger;
            userRepository = _userRepository;
            roleRepository = _roleRepository;
            _userService = userService;
            _shoesService = shoesService;
            _categoryService = categoryService;
            
		}

        public IActionResult Index()
        {
			//TempData["Categories"] = JsonConvert.SerializeObject(_categoryService.GetCategories());
			//TempData["Colors"] = JsonConvert.SerializeObject(_colorService.GetAllColor());
             
            
			var userId = HttpContext.Session.GetInt32("UserId");
			if (userId != null)
			{
				// Do something with the userId value
				var shoesList = _shoesService.GetShoes().ToList();
				return View(shoesList);
			}

            return View("Views/Home/Register.cshtml");
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
        public IActionResult Register(string firstName,string lastName, string username, string pwd, string confirmPwd,string phone, string email, string address)
        {
            
            bool flag = true;
			bool pwdEqual = String.Equals(pwd, confirmPwd, StringComparison.OrdinalIgnoreCase);
			if (pwdEqual == false)
			{
                TempData["ErrorPasswordIsNotMatch"] = "password and confirm password is not match.";
                flag = false;
			}

            if (ValidateForm.StartWithANumber(username) == true)
            {
                TempData["ErrorUsernamemailFormat"] = "Username can not start with a number.";
                flag = false;
            }

            if (ValidateForm.ContaintOnlyChar(firstName) == false)
            {
				TempData["ErrorFistName"] = "Firstname can not contain number.";
				flag = false;
			}

			if (ValidateForm.ContaintOnlyChar(lastName) == false)
			{
				TempData["ErrorlastName"] = "LastName can not contain number.";
				flag = false;
			}

			if (ValidateForm.IsValidEmail(email) == false)
			{
				TempData["ErrorEmailFormat"] = "Email is wrong format buikhoinguyen2001@gmail.com.";
                flag = false;
			}

			if (ValidateForm.StartWithANumber(email) == true)
			{
				TempData["ErrorEmailFormat"] = "Email can not start with a number.";
				flag = false;
			}

			if (ValidateForm.IsValidPhone(phone) == false)
			{
				TempData["ErrorPhoneFormat"] = "Phone must be a string number with 10 digits.";
				flag = false;
			}

            if (_userService.checkUsernameIsExisted(username) != null)
            {
				TempData["ErrorUsername"] = "Username is existed.";
				flag = false;
			}

			bool res = MailUtils.SendMail("nguyenbkse151446@fpt.edu.vn", email, "Mail Xac Nhan Email Da dang ky thanh cong", "Hello Mr/Mrs " + firstName);
			if (res == false)
			{
				TempData["ErrorEmailFormat"] = "Email is not existed";
                flag = false;
			}

			if (flag)
            {
				User user = _userService.Register(firstName + " " + lastName, username, pwd, phone, email, address);
                
                return View("Views/Home/Login.cshtml");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
		{
            var user = _userService.login(username, password);
            if (user.id > 0)
            {
                if (user.role.roleName.Equals("User"))
                {
                    HttpContext.Session.SetInt32("UserId", user.id);
                    return RedirectToAction("Index", "Home");
                }else if (user.role.roleName.Equals("Admin"))
                {
                    HttpContext.Session.SetInt32("UserId", user.id);
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    TempData["ErrorLogin"] = "Your role is not permited.";
                }
            }
            TempData["ErrorLogin"] = "Username or password is invalid.";
            return RedirectToAction("Login", "Home");
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
