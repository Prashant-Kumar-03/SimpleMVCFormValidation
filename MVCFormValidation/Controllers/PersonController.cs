using Microsoft.AspNetCore.Mvc;
using MVCFormValidation.Models;

namespace MVCFormValidation.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Input()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Person person)
        {
            if (!ModelState.IsValid)
            {
                // If the model state is invalid, return the view with the current model
                return View("Input", person);
            }
            return View(person);
        }
    }

}
