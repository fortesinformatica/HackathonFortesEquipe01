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
        private AlmoxarifadoEntidates _context;

        public BaseDao()
        {
            this._context = new AlmoxarifadoEntidates();
        }

        public void Salvar()
        {
            this._context.SaveChanges();
        }

        public virtual void Inserir(T entity)
        {
            this._context.Set<T>().Add(entity);
        }

        public virtual IQueryable<T> Consultar()
        {
            return this._context.Set<T>();
        }

        public virtual IQueryable<T> Consultar(Expression<Func<T,bool>> condicao)
        {
            return this._context.Set<T>().Where(condicao);
        }

        public virtual void Remover(T entity)
        {
            this._context.Set<T>().Remove(entity);
        }

        public virtual void Atualizar(T entity)
        {
            DbEntityEntry entityEntry = this._context.Entry(entity);
            if (entityEntry.State == EntityState.Detached)
            {
                this._context.Set<T>().Attach(entity);
                entityEntry.State = EntityState.Modified;
            }
        }
    }
}
