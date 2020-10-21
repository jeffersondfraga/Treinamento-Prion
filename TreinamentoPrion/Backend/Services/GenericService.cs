using Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class GenericService<T> : IDisposable where T : class
    {
        private GenericRepository<T> genericRepository;

        public GenericService()
        {
            genericRepository = new GenericRepository<T>();
        }

        public virtual void Add(T entity)
        {
            genericRepository.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            genericRepository.Delete(entity);
        }

        public virtual void Update(T entity)
        {
            genericRepository.Update(entity);
        }

        public virtual void ListAll(T entity)
        {
            genericRepository.ListAll();
        }

        public virtual void FindById(int Id)
        {
            genericRepository.FindById(Id);
        }


        public void Dispose()
        {

        }
    }
}
