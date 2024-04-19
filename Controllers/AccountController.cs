using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rabota_tuk__rabota_tam.Data.Models;
using RabotaTukRabotaTam.Models;

namespace Rabota_tuk__rabota_tam.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<User> _userManager, SignInManager<User> _signInManager, RoleManager<IdentityRole> _roleManager)
        {
            this.userManager = _userManager;
            this.signInManager = _signInManager;
            this.roleManager = _roleManager;
        }

        public async Task<IActionResult> CreatePost()
        {
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.Manager));
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.Supervisor));
            await roleManager.CreateAsync(new IdentityRole(RoleConstrants.Administrator));

            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Login", "User");

            }
            var model = new RegisterViewModel();
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                Email = model.EmailAddress,
                UserName = model.UserName

            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "User");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }
            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction();
                }
            }
            ModelState.AddModelError("", "Invalid Login");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction();
        }

        [Authorize]
        public async ActionResult Roles()
        {
            var currentUser = await userManager.GetUserAsync(this.User);
            var roles = await userManager.GetRolesAsync(currentUser);
        }

        [Authorize]
        public async ActionResult Data()
        {
            var currentUser = await userManager.GetUserAsync(this.User);
            var currentUserUsername = await userManager.GetUserNameAsync(currentUser);
            var currentUserId = await userManager.GetUserIdAsync(currentUser);
        }

        public async Task<IActionResult> AddUserToRole()
        {
            var roleName = "Administrator";
            var roleExists = await roleManager.RoleExistsAsync(roleName);

            if (roleExists)
            {
                var user = await userManager.GetUserAync(User);
                var result = await userManager.AddToRoleAsync(user, roleName);

                if (result.Succeeded)
                {
                    
                }
            }


        }

    }
}

