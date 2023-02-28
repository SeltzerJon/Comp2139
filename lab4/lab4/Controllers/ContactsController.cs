using lab4.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab4.Controllers
{
    public class ContactsController : Controller
    {
        // other action methods as needed

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            contact.Save(); // save the new contact to the database
            return RedirectToAction("Index", "Contacts"); // redirect back to the contacts list view
        }
    }
}
