using AutoMapper;
using SistemaConta.Data.Entities;
using SistemaConta.Data.Helpers;
using SistemaConta.Presentation.Models.Account;

namespace SistemaConta.Presentation.Mappings
{
    public class ModelToEntityMap:Profile
    {
        public ModelToEntityMap()
        {
            CreateMap<RegisterViewModel, Usuario>()
            .AfterMap((Models, entity) =>
             {
                 entity.IdUsuario=Guid.NewGuid();   
                 entity.Senha=MD5Cryptography.Hash(Models.Senha);
                 entity.DataCriacao=DateTime.Now;
                 entity.Ativo = 1;
             });
            
        }
    }
}
