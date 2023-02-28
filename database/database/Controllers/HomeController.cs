using database.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace database.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}