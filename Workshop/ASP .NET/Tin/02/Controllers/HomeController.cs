using Microsoft.AspNetCore.Mvc;
using Routing_Workshop.Models;
using System.Diagnostics;

namespace Routing_Workshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*
         * TODO 2a: 
         * Construct a URL on your browser to access this 
         * action-method. The URL should contain a query-string that
         * carries values for the two parameters 'a' and 'b'.
         *  
         * If successfully, you should see the sum of 'a' and 'b' displayed
         * on your browser.
         * 
         * https://localhost:7004/Home/Sum?a=1&b=1
         * 
         */
        public int Sum(int a, int b)
        {
            return a + b;
        }


        /*
         * TODO 2b: 
         * A Convention-based Route for this action-method 
         * has been created but you are not getting the expected result.
         *  
         * For example, typing "https://localhost:44354/Home/Greetings/Tom/Ranger"
         * on the browser's address bar should display "Hello, Ranger Tom!" on the 
         * browser. However, your browser is displaying "Hello, Tom!" instead.
         *  
         * Please fix the problem.
         * 
         * go to "Programs.cs"
         * pattern: "{controller=Home}/{action=Index}/{name?}/{designation?}");
         * 
         * the name of the variable must be the same
         */


        /* Question to ask:
         * 
         * At the beginning, how dose mvc bind name in such occasion
         * pattern: "{controller=Home}/{action=Index}/{id?}");
         * https://localhost:44354/Home/Greetings/Tom/Ranger
         * 
         * 
         */
        public string Greetings(string name, string designation)
        {
            return string.Format("Hello, {0} {1}!", designation, name);
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
}