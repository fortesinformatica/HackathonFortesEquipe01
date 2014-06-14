using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FortesEstoque.DAO
{
    public class BaseDao<T> where T : class
    {
        public AlmoxarifadoEntidates Context;

        public BaseDao()
        {
            this.Context = new AlmoxarifadoEntidates();
        }

        public void Salvar()
        {
            this.Context.SaveChanges();
        }

        public virtual void Inserir(T entity)
        {
            this.Context.Set<T>().Add(entity);
        }

        public virtual List<T> Consultar()
        {
            return this.Context.Set<T>().ToList();
        }

        public virtual List<T> Consultar(Expression<Func<T,bool>> condicao)
        {
            return this.Context.Set<T>().Where(condicao).ToList();
        }

        public virtual void Remover(T entity)
        {
            this.Context.Set<T>().Remove(entity);
        }

        public virtual void Atualizar(T entity)
        {
            DbEntityEntry entityEntry = this.Context.Entry(entity);
            if (entityEntry.State == EntityState.Detached)
            {
                this.Context.Set<T>().Attach(entity);
                entityEntry.State = EntityState.Modified;
            }
        }
    }
}
