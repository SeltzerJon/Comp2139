using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Week3Lab.Models;

namespace Week3Lab.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            ViewBag.TwentyFive = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculator calc)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fifteen = calc.CalculateTip(0.15);
                ViewBag.Twenty = calc.CalculateTip(0.20);
                ViewBag.TwentyFive = calc.CalculateTip(0.25);
            }
            else
            {
                ViewBag.Fifteen = 0;
                ViewBag.Twenty = 0;
                ViewBag.TwentyFive = 0;
                return View();
            }
            return View();
        }

    }
}
