using Mon_Petit_Sucre.Contexts;
using Mon_Petit_Sucre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Petit_Sucre.Entities
{
    public class GenericEntity<TEntity> : IDisposable where TEntity : GenericModel
    {
        private GenericContext context;

        public GenericEntity(GenericContext context)
        {
            this.context = context;
        }

        public void Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public TEntity FindById(long id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ListAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
