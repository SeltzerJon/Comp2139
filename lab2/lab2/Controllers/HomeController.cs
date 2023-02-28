using lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}