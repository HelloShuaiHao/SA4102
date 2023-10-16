using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    public class ReportController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string msg)
        {
            ViewData["message"] = msg;
            return View();
        }
        
        public IActionResult Message()
        {
            var msgViewModel = new HelloWorld.Models.MessageViewModel();

            msgViewModel.Message = "Hello View";
            msgViewModel.From = "Controller Message Action";

            return View(msgViewModel);
        }

    }
}

