using Backend.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class GenericRepository<T>: IDisposable where T : class
    {
        private GenericContext context;

        public GenericRepository()
        {
            context = new GenericContext();
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            //context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        /*
        public FindById(T entity)
        {

        }

        public ListAll(T entity)
        {

        }
        */
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
