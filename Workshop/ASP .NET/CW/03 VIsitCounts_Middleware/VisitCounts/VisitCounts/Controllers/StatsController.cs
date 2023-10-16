using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VisitCounts.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VisitCounts.Controllers
{
    public class StatsController : Controller
    {
        // GET: /<controller>/

        // dependency injecton; count has already been registered just add in it directly
        private readonly Count count;
        public StatsController(Count count)
        {
            this.count = count;
        }

        public IActionResult Index()
        {

            int countHome = count.CountHome;
            int countGallery = count.CountGallery;

            ViewBag.countHome = countHome;
            ViewBag.countGallery = countGallery;

            return View();
        }
    }
}

