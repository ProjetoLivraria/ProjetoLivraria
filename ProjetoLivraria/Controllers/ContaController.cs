using Microsoft.AspNetCore.Mvc;
using ProjetoLivraria.Models;

namespace ProjetoLivraria.Controllers
{
    public class ContaController : Controller
    {
        //exibe a tela de Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        //recebe os dados do formulário de Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // precisa consultar o usuário no banco
            // e verificar a senha utilizando o hash.

            ModelState.AddModelError(
                string.Empty,
                "A autenticação ainda não foi integrada ao banco de dados."
            );

            return View(model);
        }

        //exibe a tela de Cadastro
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        //recebe os dados do formulário de Cadastro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastro(CadastroViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // precisa verificar se o e-mail já existe,
            // gerar o hash da senha e salvar o usuário no banco.

            ModelState.AddModelError(
                string.Empty,
                "O cadastro ainda não foi integrado ao banco de dados."
            );

            return View(model);
        }
    }
}
