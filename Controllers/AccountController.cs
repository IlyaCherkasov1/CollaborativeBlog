
using CollaborativeBlog.Models;
using CollaborativeBlog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            var externalProviders = await _signInManager.GetExternalAuthenticationSchemesAsync();
            return View(new LoginViewModel
            {
                ExternalProviders = externalProviders
            });
        }

        [Authorize(Policy = "Administrator")]
        public IActionResult Administrator()
        {
            return View();
        }

        [Authorize(Policy = "Manager")]
        public IActionResult Manager()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var redirectUrl = Url.Action(nameof(ExternalLoginCallBack), "Account", new { returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }

        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallBack(string returnUrl)
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction("Login");
            }

            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false, false);
            if (result.Succeeded)
            {
                return Redirect("/Home/Index");
            }

            return RedirectToAction("RegisterExternalConfirmed", new ExternalLoginViewModel
            {
                ReturnUrl = returnUrl,
                NameIdentifier = info.Principal.FindFirstValue(ClaimTypes.NameIdentifier),
                Email = info.Principal.FindFirstValue(ClaimTypes.Email),
                GivenName = info.Principal.FindFirstValue(ClaimTypes.GivenName)
            });

        }


        [AllowAnonymous]
        public async Task<IActionResult> RegisterExternalConfirmed(ExternalLoginViewModel model)
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return Redirect("/Home/Index");

            }

            var user = new User(model.NameIdentifier, model.Email);
            var result = await _userManager.CreateAsync(user);


            if (result.Succeeded)
            {
        
           

                    var identityResult = await _userManager.AddLoginAsync(user, info);
                    if (identityResult.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, false);
                        return Redirect("/Home/Index");

                    }
                
            }

            return View(model);
        }

        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Home/Index");
        }

    }
}
