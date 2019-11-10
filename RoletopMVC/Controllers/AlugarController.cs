using Microsoft.AspNetCore.Mvc;

namespace RoletopMVC.Controllers
{
    public class AlugarController : Controller
    {
         public IActionResult Alugar()
        {
            return View();
        }
    }
}