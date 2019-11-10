using Microsoft.AspNetCore.Mvc;

namespace RoletopMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}