﻿using Microsoft.EntityFrameworkCore;
using SistemaConta.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConta.Data.Repositories
{/// <summary>
///   Classe abstrata que vai servir para definir os métodos dos repositorios  
/// </summary>
    public abstract class BaseRepository<TEntity,TKey> where TEntity : class
    {
        public virtual void Adicionar(TEntity entity) {
            using (var dataContext=new DataContext())
            {
                dataContext.Add(entity);
                dataContext.SaveChanges();
            }
        }
        public virtual void Atualizar(TEntity entity) {
            using(var dataContext=new DataContext())
            {
                dataContext.Entry(entity).State=EntityState.Modified;
                dataContext.SaveChanges();
            }
        }
        public virtual void Excluir(TEntity entity) {
            using (var dataContext= new DataContext())
            {
                dataContext.Remove(entity);
                dataContext.SaveChanges();  
            }
        }
        public virtual List<TEntity> ObterTodos(Func<TEntity,bool> where) {
            using(var dataContext=new DataContext())
            {
                return dataContext.Set<TEntity>()
                    .Where(where)
                    .ToList();
            }
        }
        public virtual TEntity? Obter(Func<TEntity,bool> where)
        {
            using( var dataContext=new DataContext())
            {
                return dataContext.Set<TEntity>()
                    .FirstOrDefault(where);
            }
        }
        public virtual TEntity? ObterPorID(TKey id) {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<TEntity>()
                    .Find(id);
            }
        }

    }
}
