using Microsoft.AspNetCore.Mvc;

namespace RoletopMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}