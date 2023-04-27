using System.ComponentModel.DataAnnotations;

namespace EnqueteWeb.Models
{
    public class RespostaUsuario
    {
        [Required(ErrorMessage = "O nome deve ser preenchido!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O E-mail deve ser preenchido!")]
        [EmailAddress(ErrorMessage = "O E-mail deve conter um formato válido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo deve ser preenchido!")]
        public bool? Sim { get; set; }
    }
}