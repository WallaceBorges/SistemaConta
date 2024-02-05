using System.ComponentModel.DataAnnotations;

namespace SistemaConta.Presentation.Models.Account
{
    public class RegisterViewModel
    {
        [MinLength(8, ErrorMessage = "Nome deve ter no minimo {1} Caracteres.")]
        [MaxLength(20, ErrorMessage = "Nome deve ter no maximo {1} Caracteres.")]
        [Required(ErrorMessage ="Por favor, Infome seu nome.")]
        public string? Nome { get; set; }

        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage ="Senha é fraca")]
        [MinLength(8, ErrorMessage = "Senha menos que {1} Caracteres.")]
        [MaxLength(20, ErrorMessage = "Senha maior que {1} Caracteres.")]
        [Required(ErrorMessage = "Por favor, Infome sua senha.")]
        public string? Senha { get; set; }

        [EmailAddress(ErrorMessage = "Isso não é um email.")]
        [Required(ErrorMessage = "Por favor, Infome seu Email.")]
        public string? Email { get; set; }

        [Compare("Senha",ErrorMessage ="Senhas não conferem.")]
        [Required(ErrorMessage = "Por favor, Confirme sua senha.")]
        public string? SenhaConfirmacao { get; set; } 
    }
}
