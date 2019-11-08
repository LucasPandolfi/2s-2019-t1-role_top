using Microsoft.AspNetCore.Mvc;

namespace RoletopMVC.Controllers
{
    public class EventosController : Controller
    {
        public IActionResult Eventos()
        {
            return View();
        }
    }
}