using System.Reflection.Metadata.Ecma335;

namespace SistemaConta.Presentation.Models.Authentication
{
    public class AuthenticationModel
    {
        public Guid? IdUsuario { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataHoraAcesso { get; set; }
        public int? Ativo { get; set; }

    }
}
