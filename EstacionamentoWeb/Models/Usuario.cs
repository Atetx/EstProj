using EstacionamentoWeb.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstacionamentoWeb.Models
{
    [Table("Usuario")] //Anotação (decorei) : é uma confgiuração que coloca em cima de um atributo, classe ou método.
    public class Usuario : BaseModel
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(11, ErrorMessage = "CPF deve conter 11 digitos!")]
        [MaxLength(11, ErrorMessage = "CPF deve conter 11 digitos!")]
        public string Cpf { get; set; }

        public string Imagem { get; set; }

    }
}
