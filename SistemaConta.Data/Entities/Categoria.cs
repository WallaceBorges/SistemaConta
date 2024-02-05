using SistemaConta.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConta.Data.Entities
{
    public class Categoria
    {
        private Guid? _idCategoria;
        private string? _nome;
        private TipoCategoria? _tipo;
        private Guid? _idUsuario;

        private Usuario? _usuario;
        private List<Conta>? _contas;

        public Guid? IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public TipoCategoria? Tipo { get => _tipo; set => _tipo = value; }
        public Guid? IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public Usuario? Usuario { get => _usuario; set => _usuario = value; }
        public List<Conta>? Contas { get => _contas; set => _contas = value; }
    }
}
