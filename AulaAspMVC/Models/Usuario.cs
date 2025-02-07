using System.ComponentModel.DataAnnotations;
namespace AulaAspMVC.Models
{
    public class Usuario
    {

        public int Id { get; private set; }
        [Required(ErrorMessage = "O nome � obrigat�rio")]
        [StringLength(50, ErrorMessage = "O nome de usu�rio n�o pode exceder 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O telefone � obrigat�rio")]
        [Phone(ErrorMessage = "Telefone inv�lido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O email � obrigat�rio")]
        [EmailAddress(ErrorMessage = "Email inv�lido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O cep � obrigat�rio")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "O estado � obrigat�rio")]
        public string UF { get; set; }

        [Required(ErrorMessage = "A cidade � obrigat�ria")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O bairro � obrigat�rio")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "A rua � obrigat�ria")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "O n�mero � obrigat�rio")]
        public string Numero { get; set; }

        public string Complemento { get; set; }
    }
}