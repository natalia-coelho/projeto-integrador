using Microsoft.AspNetCore.Mvc;

namespace ProjetoIntegrador.Controllers
{
    public class LoginController : Controller
    {
        //Lidará com o cadastro de Fornecedor e Usuário
        public IActionResult Index()
        {
            return View();
        }
    }
}
