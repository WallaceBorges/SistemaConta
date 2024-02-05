using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConta.Data.Entities
{
    public class Conta
    {
        private Guid? _idConta;
        private string? _nome;
        private string? _descricao;
        private DateTime? _data;
        private decimal? _valor;
        private Guid? _idUsuario;//vai virar chave estrangeira
        private Guid? _idCategoria;//vai virar chave estrangeira

        private Usuario? _usuario;// vai virar cardinalidade
        private Categoria? _categoria;//vai virar cardinalidade

        public Guid? IdConta { get => _idConta; set => _idConta = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Descricao { get => _descricao; set => _descricao = value; }
        public DateTime? Data { get => _data; set => _data = value; }
        public decimal? Valor { get => _valor; set => _valor = value; }
        public Guid? IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public Guid? IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public Usuario? Usuario { get => _usuario; set => _usuario = value; }
        public Categoria? Categoria { get => _categoria; set => _categoria = value; }
    }
}
