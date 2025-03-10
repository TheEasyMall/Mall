using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mall.MVC.Models;
using Mall.Services.Interfaces;

namespace Mall.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IAuthenticationService _authenticationService;

    public HomeController(ILogger<HomeController> logger, 
        IAuthenticationService authenticationService)
    {
        _logger = logger;
        _authenticationService = authenticationService;
    }

    public async Task<IActionResult> Index()
    {
        var userInfo = await _authenticationService.GetInforAccount();
        if (userInfo == null || !userInfo.IsSuccess || userInfo.Data == null)
        {
            return RedirectToAction("LogIn", "Authentications");
        }

        ViewData["UserEmail"] = userInfo.Data.Email;
        return View();
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
