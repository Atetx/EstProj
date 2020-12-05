using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoWeb.Models
{
    [Table("Estacionamento")]
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
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
