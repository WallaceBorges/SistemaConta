using System.ComponentModel.DataAnnotations;

namespace SistemaConta.Presentation.Models.Account
{
    public class LoginViewModel
    {
        [EmailAddress(ErrorMessage ="Isso não é um email.")]
        [Required(ErrorMessage ="Informe seu email!!1")]
        public string? Email { get; set; }

        [MinLength(8,ErrorMessage ="Senha menos que {1} Caracteres.")]
        [MaxLength(20,ErrorMessage ="Senha maior que {1} Caracteres.")]
        [Required(ErrorMessage ="Digite sua senha.")]
        public string? Senha { get; set; }

    }
}
