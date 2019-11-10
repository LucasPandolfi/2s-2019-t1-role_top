using Microsoft.AspNetCore.Mvc;

namespace RoletopMVC.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Galeria()
        {
            return View();
        }
    }
}