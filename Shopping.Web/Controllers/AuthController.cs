using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Web.Data;
using Shopping.Web.Models;
using Shopping.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<SUser> _userManager;
        private readonly SignInManager<SUser> _signManager;
        private readonly ShoppingContext _context;

        public AuthController(ShoppingContext context, SignInManager<SUser> signManager, UserManager<SUser> userManager)
        {
            _context = context;
            _signManager = signManager;
            _userManager = userManager;
        }
        [Route("login")]

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            SUser appUser = await _userManager.FindByEmailAsync(loginVM.Email);
            if (appUser == null)
            {
                ModelState.AddModelError("", "Email is wrong");
                return View(loginVM);
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await
                _signManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.RememberMe, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Password is wrong");
                return View(loginVM);
            }
            return RedirectToAction("Index","Home");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }
            SUser newUser = new SUser()
            {
                UserName=registerVM.Email,
                Email = registerVM.Email,
                Firstname=registerVM.FirstName,
                Lastname=registerVM.LastName
            };
            IdentityResult result = await _userManager.CreateAsync(newUser,registerVM.Password);
            if (result.Succeeded)
            {
                IdentityResult res = await _userManager.AddToRoleAsync(newUser, "User");
                return RedirectToAction(nameof(Login));

            } 
            return View();
        }
    }
}
