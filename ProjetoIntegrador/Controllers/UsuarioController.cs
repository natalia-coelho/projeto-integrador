using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Models;
using ProjetoIntegrador.Repository;

namespace ProjetoIntegrador.Controllers;

public class UsuarioController : Controller
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioController(IUsuarioRepository usuarioRepository)
    {
        this._usuarioRepository = usuarioRepository;
    }

    public IActionResult Index()
    {
        List<Usuario> usuarioList = _usuarioRepository.List();

        return View(usuarioList);
    }

    public IActionResult AddUsuario()
    {
        return View();
    }

    [Route("Usuario/Create")]
    [HttpPost("")]
    public IActionResult CreateUsuario(String nome, String email, String telefone)
    {
        CreateUsuarioRequest usuarioRequest = new(nome, email, telefone);
        this._usuarioRepository.Create(usuarioRequest);
        return RedirectToAction("Index");
    }
    public IActionResult EditUsuario()
    {
        return Ok();
    }
    public IActionResult DeleteUsuario(Guid id)
    {
        this._usuarioRepository.Delete(id);
        return RedirectToAction("Index");
    }
}
