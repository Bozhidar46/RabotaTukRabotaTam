using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RabotaTukRabotaTam.Data.Models;
using RabotaTukRabotaTam.Models;

namespace Rabota_tuk__rabota_tam.Controllers
{
    [Authorize]
    
    public class UserController : Controller
    {
        private readonly UserManager<User> userManager;

        private readonly SignInManager<User> signInManager;

        public UserController(UserManager<User> _userManager,SignInManager<User> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
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
                Email = model.Email,
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
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var user = await userManager.FindByEmailAsync(viewModel.Email);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, viewModel.Password, false, false);
                if (result.Succeeded)
                {
                   
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid login");
            return View(viewModel);
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        /*
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
          */
    }
}

