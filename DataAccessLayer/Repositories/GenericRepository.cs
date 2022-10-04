using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : iGenericDal<T> where T : class
    {
        
        public void Delete(T t)
        {
            using var c=new context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T getbyid(int id)
        {
            using var c = new context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
