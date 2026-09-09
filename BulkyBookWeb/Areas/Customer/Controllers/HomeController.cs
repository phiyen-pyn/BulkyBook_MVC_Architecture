using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace BulkyBookWeb.Controllers;

public class HomeController : Controller
{
    [Area("Customer")]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}