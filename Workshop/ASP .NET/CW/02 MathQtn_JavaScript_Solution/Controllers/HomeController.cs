using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MathQtn_JavaScript.Models;

namespace MathQtn_JavaScript.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetQtn() 
    {
        Random rnd = new Random();
        int rhs_val = rnd.Next(1, 10);
        int ans_val = rnd.Next(10, 20);

        return Json(new { 
            rhs = rhs_val,
            ans = ans_val
        });
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

