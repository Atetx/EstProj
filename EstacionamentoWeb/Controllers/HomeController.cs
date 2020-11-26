using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EstacionamentoWeb.DAL;
using EstacionamentoWeb.Models;

namespace EstacionamentoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsuarioDAO _usuarioDAO;
        private readonly VeiculoDAO _veiculoDAO;
        public HomeController(UsuarioDAO usuarioDAO, VeiculoDAO veiculoDAO)
        {
            _usuarioDAO = usuarioDAO;
            _veiculoDAO = veiculoDAO;
        }
        public IActionResult Index(int id)
        {
            List<Usuario> usuarios = id == 0 ? _usuarioDAO.Listar() : _usuarioDAO.ListarPorNome(id);
            return View(usuarios);
        }

        public IActionResult Login(string email, string senha)
        {
            Usuario catchUsuario = _usuarioDAO.BuscarPorEmail(email);
            if (catchUsuario.Email == email && catchUsuario.Senha == senha)
            {
                RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Usuário ou senha incorretos!");
            return View();
        }
    }
}
