﻿using Microsoft.AspNetCore.Mvc;

namespace Lab3._1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}