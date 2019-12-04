using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using second.Models;

namespace second.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Nadia";
            int[] numb = new int[]{1,2,3,4,5,6};
            ViewBag.numbers = numb;
            return View();
        }

        [HttpGet("click")]
        public IActionResult click(){
            return View("Index");
        }
        [HttpGet("array")]
        public IActionResult arrayofnumbers(){
            int[] numb = new int[]{1,2,3,4,5,6};
            return View("arrayofnumbers",numb);
        }

        [HttpGet("user")]
        public IActionResult user(){
            User nadia = new User();
            nadia.age=25;
            nadia.name="Nadia";
            return View(nadia);
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
