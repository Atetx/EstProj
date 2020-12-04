using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EstacionamentoWeb.Models;
using EstacionamentoWeb.DAL;

namespace EstacionamentoWeb.Controllers
{
    public class EstacionarController : Controller
    {
        private readonly Context _context;
        private readonly UsuarioDAO _usuarioDAO;
        private readonly VeiculoDAO _veiculoDAO;
        private readonly EstacionamentoDAO _estacionamentoDAO;
        private readonly EstacionarDAO _estacionarDAO;

        public EstacionarController(Context context, UsuarioDAO usuarioDAO, VeiculoDAO veiculoDAO, EstacionamentoDAO estacionamentoDAO, EstacionarDAO estacionarDAO)
        {
            _context = context;
            _usuarioDAO = usuarioDAO;
            _veiculoDAO = veiculoDAO;
            _estacionamentoDAO = estacionamentoDAO;
            _estacionarDAO = estacionarDAO;
        }

        // GET: Estacionar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estacionados.ToListAsync());
        }
        // GET: Estacionar/Create
        public IActionResult Create()
        {
            var name = User.Identity.Name;
            Usuario usuario = _usuarioDAO.BuscarPorEmail(name);
            int usuarioId = usuario.Id;
            ViewBag.Veiculos = new SelectList(_veiculoDAO.ListarPorUsuario(usuarioId), "Id", "Modelo");
            ViewBag.Estacionamentos = new SelectList(_estacionamentoDAO.ListarPorUsuario(usuarioId), "Id", "Nome");
            return View();
        }

        // POST: Estacionar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CriadoEm,Estacionamento,Veiculo")] Estacionar estacionar)
        {
            var email = User.Identity.Name;
            Usuario usuario = _usuarioDAO.BuscarPorEmail(email);
            if (_estacionarDAO.Cadastrar(estacionar, usuario))
            {
                return RedirectToAction("Index", "Estacionar");
            }
            return View(estacionar);
        }
    }
}
