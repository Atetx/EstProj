using System.Collections.Generic;
using System.Linq;
using EstacionamentoWeb.Models;

namespace EstacionamentoWeb.DAL
{
    public class VeiculoDAO
    {
        private readonly Context _context;
        public VeiculoDAO(Context context) => _context = context;
        //public List<Veiculo> Listar() => _context.Veiculos.ToList();
        public Veiculo BuscarPorId(int id) => _context.Veiculos.Find(id);
    }
}
