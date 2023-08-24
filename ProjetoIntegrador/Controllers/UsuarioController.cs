using Microsoft.AspNetCore.Mvc;

namespace ProjetoIntegrador.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
