using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class Efcustomerdal : GenericRepository<Customer>, iCustomerDal
    {
        public List<Customer> GetListwithjob()
        {
            using (var c=new context())
            {
                return c.customers.Include(x=>x.Job).ToList();
            }
        }
    }
}
