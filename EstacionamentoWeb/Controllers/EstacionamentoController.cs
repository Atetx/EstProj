﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EstacionamentoWeb.Models;
using EstacionamentoWeb.DAL;
using Microsoft.AspNetCore.Hosting;

namespace EstacionamentoWeb.Controllers
{
    public class EstacionamentoController : Controller
    {
        private readonly Context _context;
        private readonly EstacionamentoDAO _estacionamentoDAO;
        private readonly UsuarioDAO _usuarioDAO;
        private readonly IWebHostEnvironment _hosting;

        public EstacionamentoController(Context context, IWebHostEnvironment hosting, EstacionamentoDAO estacionamentoDAO, UsuarioDAO usuarioDAO)
        {
            _estacionamentoDAO = estacionamentoDAO;
            _hosting = hosting;
            _context = context;
            _usuarioDAO = usuarioDAO;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Cadastro de Estacionamento";
            return View(_estacionamentoDAO.Listar());
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Estacionamento estacionamento)
        {
            if (ModelState.IsValid)
            {
                var email = User.Identity.Name;
                Usuario usuario = _usuarioDAO.BuscarPorEmail(email);
                if (_estacionamentoDAO.Cadastrar(estacionamento, usuario))
                {
                    return RedirectToAction("Index", "Estacionamento");
                }
                ModelState.AddModelError("", "Estacionamento já cadastrado");
            }
            return View(estacionamento);
        }

        public IActionResult Alterar(Estacionamento estacionamento)
        {
            _estacionamentoDAO.Alterar(estacionamento);
            return RedirectToAction("Index", "Estacionamento");
        }
        public IActionResult Remover(int id)
        {
            _estacionamentoDAO.Remover(id);
            return RedirectToAction("Index", "Estacionamento");
        }
    }
}
