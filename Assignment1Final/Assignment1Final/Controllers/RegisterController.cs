using Assignment1Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1Final.Controllers
{
    public class RegisterController : Controller
    {
        // GET Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                // Need database
                return RedirectToAction("Success");
            }

            return View(model);
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
