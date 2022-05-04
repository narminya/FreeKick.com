using Domain.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ViewModels.Account;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<AccountController> _logger;
        public AccountController(AppDbContext context, SignInManager<User> signInManager,
            UserManager<User> userManager, RoleManager<IdentityRole> roleManager,
             ILogger<AccountController> logger
            )
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;

        }
        public IActionResult Authorize()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var acc = new AccountViewModel()
            {
                LogIn = model
            };
            if (!ModelState.IsValid)
            {
                return View("Authorize",acc);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError(nameof(model.Email), "User is not found");
                return View();
            }
            else if (user.EmailConfirmed == false)
            {
                ModelState.AddModelError(nameof(model.Email), "Please confirm your email address");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.KeepMeSigned, true);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Invalid Credentials");
                return View();
            }


            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var acc = new AccountViewModel()
            {
                Registration = model
            };
            if (!ModelState.IsValid)
            {
                return View("Authorize", acc);
            }

            var dbUser = await _userManager.FindByNameAsync(model.Username);
            if (dbUser != null)
            {
                ModelState.AddModelError(model.Username, "This username is taken. Please enter another username");
                return View(acc);
            }

            User user = new User();
            user.Email = model.Email;
            user.UserName = model.Username;
            

            var identityUser = await _userManager.CreateAsync(user, model.Password);

            if (!identityUser.Succeeded)
            {


                foreach (var item in identityUser.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                    return View(acc);
                }
            }
            await _signInManager.SignInAsync(user, true);

            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account", new { Area = "" });
        }
    }
}
