using EstacionamentoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoWeb.DAL
{
    public class EstacionamentoDAO
    {
        private readonly Context _context;
        public EstacionamentoDAO(Context context) => _context = context;
        public List<Estacionamento> Listar() => _context.Estacionamentos.ToList();
        public Estacionamento BuscarPorId(int id) => _context.Estacionamentos.Find(id);
        public bool Cadastrar(Estacionamento estacionamento)
        {
            _context.Estacionamentos.Add(estacionamento);
            _context.SaveChanges();
            return true;
        }
        public Estacionamento BuscarPorNome(string nome) => _context.Estacionamentos.FirstOrDefault(x => x.Nome == nome);
        public void Remover(int id)
        {
            _context.Estacionamentos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public void Alterar(Estacionamento estacionamento)
        {
            _context.Estacionamentos.Update(estacionamento);
            _context.SaveChanges();
        }
    }
}
