using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MathQtn_JS_Workshop.Controllers
{
    public class DataController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetData()
        {
            Random rnd = new Random();
            int a = rnd.Next(21);
            int b = rnd.Next(21);
            int c = a + b;



            return Json(new { a = a, b=b, c=c});
        }
    }
}

