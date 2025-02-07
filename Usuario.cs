using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [Required(ErrorMessage = "O nome � obrigat�rio")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O telefone � obrigat�rio")]
    [Phone(ErrorMessage = "Telefone inv�lido")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "O email � obrigat�rio")]
    [EmailAddress(ErrorMessage = "Email inv�lido")]
    public string Email { get; set; }

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
