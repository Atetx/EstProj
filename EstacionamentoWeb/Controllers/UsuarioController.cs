using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using EstacionamentoWeb.DAL;
using EstacionamentoWeb.Models;

namespace EstacionamentoWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioDAO _usuarioDAO;
        private readonly VeiculoDAO _veiculoDAO;
        private readonly IWebHostEnvironment _hosting;
        public UsuarioController(UsuarioDAO usuarioDAO, IWebHostEnvironment hosting, VeiculoDAO veiculoDAO)
        {
            _usuarioDAO = usuarioDAO;
            _veiculoDAO = veiculoDAO;
            _hosting = hosting;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Gerenciamento de Usuarios";
            return View(_usuarioDAO.Listar());
        }
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string arquivo = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                    string caminho = Path.Combine(_hosting.WebRootPath, "images", arquivo);
                    file.CopyTo(new FileStream(caminho, FileMode.CreateNew));
                    usuario.Imagem = arquivo;
                }
                else
                {
                    usuario.Imagem = "semimagem.png";
                }
                if (_usuarioDAO.Cadastrar(usuario))
                {
                    return RedirectToAction("Index", "Usuario");
                }
                ModelState.AddModelError("", "Já existe um usuario com o mesmo nome!!!");
            }
            return View(usuario);
        }
        public IActionResult Remover(int id)
        {
            _usuarioDAO.Remover(id);
            return RedirectToAction("Index", "Usuario");
        }
        public IActionResult Alterar(int id)
        {
            return View(_usuarioDAO.BuscarPorId(id));
        }
        [HttpPost]
        public IActionResult Alterar(Usuario usuario)
        {
            _usuarioDAO.Alterar(usuario);
            return RedirectToAction("Index", "Usuario");
        }
    }
}