using Backend.Entities;
using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class GenericController<T> : ApiController where T : class
    {
        protected GenericService<T> service;

        public GenericController()
        {
            service = new GenericService<T>();
        }

        public virtual void Add(T entity)
        {
            service.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            service.Delete(entity);
        }

        //[Route("list-all")] pesquisar dispois
        public virtual void Update(T entity)
        {
            service.Update(entity);
        }

        [HttpGet]
        public virtual void ListAll()
        {
            service.ListAll();
        }

        public virtual void FindById(int id)
        {
            service.FindById(id);
        }
    }
}