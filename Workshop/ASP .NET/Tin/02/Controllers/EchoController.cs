using Microsoft.AspNetCore.Mvc;

namespace Routing_Workshop.Controllers
{
    public class EchoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*
         * TODO 1a: 
         * Reach this action by typing 
         * the appropriate URL on your browser.
         *  
         * If successful, you should see the word
         * "ReachByConventionRoute" on your browser.
         *  
         *  https://localhost:7004/Echo/ReachByConventionRoute
         */

        /*
         * TODO 1b: 
         * Instead of the current "/Home/Index"
         * as the default page when launched, change
         * the default page to be this action-method.
         *  
         * If successful, you should see the word
         * "ReachByConventionRoute" on your browser
         * when you start the application.
         * 
         * 
         * app.MapControllerRoute(
            name: "default",
              pattern: "{controller=Echo}/{action=ReachByConventionRoute}/{id?}");

         */
        public IActionResult ReachByConventionRoute()
        {
            return Content("<html><body>ReachByConventionRoute</body></html>",
                "text/html");
        }

        /*
         * TODO 1c: 
         * Create a Attribute-based route,
         * with the pattern "/ReachByAttributeRoute",
         * for this action method. 
         * 
         * Then type the 
         * appropriate URL on your browser to access it.
         * If successfuly, you should see the word
         * "ReachByAttributeRoute" on your browser.
         *  
         * Note: This returns a "string" (use Chrome 
         * dev tools to verify it https://www.youtube.com/watch?v=nl8iKlo2NeM).
         */
        public string ReachByAttributeRoute()
        {
            return "ReachByAttributeRoute";
        }
    }
}
