using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O telefone é obrigatório")]
    [Phone(ErrorMessage = "Telefone inválido")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "O email é obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O estado é obrigatório")]
    public string UF { get; set; }

    [Required(ErrorMessage = "A cidade é obrigatória")]
    public string Cidade { get; set; }

    [Required(ErrorMessage = "O bairro é obrigatório")]
    public string Bairro { get; set; }

    [Required(ErrorMessage = "A rua é obrigatória")]
    public string Rua { get; set; }

    [Required(ErrorMessage = "O número é obrigatório")]
    public string Numero { get; set; }

    public string Complemento { get; set; }
}
