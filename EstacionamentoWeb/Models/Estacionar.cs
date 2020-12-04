using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoWeb.Models
{
    public class Estacionar : BaseModel
    {
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public Usuario Usuario { get; set; }
        [ForeignKey("VeiculoId")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public Veiculo Veiculo { get; set; }
        [ForeignKey("EstacionamentoId")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public Estacionamento Estacionamento { get; set; }
        public int VeiculoId { get; set; }
        public int EstacionamentoId { get; set; }
    }
}
