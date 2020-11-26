using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoWeb.Models
{
    public class Estacionamento : BaseModel
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Vagas { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public double Preco { get; set; }
    }
}
