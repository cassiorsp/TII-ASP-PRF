using AulaAspMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AulaAspMVC.Controllers
{
    public class AlunosController : Controller
    {
        public IActionResult Cassio()
        {
            return View();
           
        }

        [HttpGet]
        public IActionResult Usuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Usuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                // Lógica para salvar o usuário
                return RedirectToAction("Index");
            }
            return View(usuario);
        }


    }
}
