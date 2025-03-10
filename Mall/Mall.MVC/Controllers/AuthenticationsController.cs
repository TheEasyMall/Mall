using Mall.DTOs.Auth.Requests;
using Mall.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Mall.MVC.Controllers
{
    public class AuthenticationsController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationsController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public IActionResult LogIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LogInRequest logIn)
        {
            var result = await _authenticationService.LogInUser(logIn);
            if (!result.IsSuccess)
            {
                ViewBag.ErrorMessage = result.Message;
                return View(logIn);
            }

            Response.Cookies.Append("AccessToken", result.Data.Token, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict
            });

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpRequest signUp)
        {
            var result = await _authenticationService.SignUpUser(signUp);
            if (!result.IsSuccess)
            {
                ViewBag.ErrorMessage = result.Message;
                return View(signUp);
            }
            return RedirectToAction("LogIn");
        }

        public IActionResult LogOut()
        {
            Response.Cookies.Delete("AccessToken");
            return RedirectToAction("LogIn");
        }
    }
}
