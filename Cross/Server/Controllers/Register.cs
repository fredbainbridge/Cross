using Cross.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Cross.Shared;

namespace Cross.Server.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserRegistrationModel userModel)
        {
            return View();
        }
    }
}
