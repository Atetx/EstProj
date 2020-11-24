using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoWeb.Models
{
    [Table("Veiculo")]
    public class Veiculo : BaseModel
    {
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Modelo { get; set; }

        public string Marca { get; set; }

        public string Placa { get; set; }
        public Usuario Usuario { get; set; }

    }
}
