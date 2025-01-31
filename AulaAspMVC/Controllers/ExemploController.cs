using Microsoft.AspNetCore.Mvc;

namespace AulaAspMVC.Controllers
{
    public class ExemploController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult QuemSomos()
        {
            return View();
        }
    }
}
