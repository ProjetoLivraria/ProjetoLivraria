using Microsoft.AspNetCore.Mvc;

namespace ProjetoLivraria.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
