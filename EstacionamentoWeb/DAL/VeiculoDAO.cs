using System.Collections.Generic;
using System.Linq;
using EstacionamentoWeb.Models;

namespace EstacionamentoWeb.DAL
{
    public class VeiculoDAO
    {
        private readonly Context _context;
        public VeiculoDAO(Context context) => _context = context;
        public List<Veiculo> Listar() => _context.Veiculos.ToList();
        public Veiculo BuscarPorId(int id) => _context.Veiculos.Find(id);
        public bool Cadastrar(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
            return true;
        }
        public Veiculo BuscarPorPlaca(string placa) => _context.Veiculos.FirstOrDefault(x => x.Placa == placa);
        public void Remover(int id)
        {
            _context.Veiculos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public void Alterar(Veiculo veiculo)
        {
            _context.Veiculos.Update(veiculo);
            _context.SaveChanges();
        }
    }
}
