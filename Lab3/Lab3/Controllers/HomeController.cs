using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}