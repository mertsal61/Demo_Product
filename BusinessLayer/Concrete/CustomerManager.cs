using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : iCustomerService
    {
        iCustomerDal _icustomerdal;
        public Customer getbyid(int id)
        {
           return _icustomerdal.getbyid(id);
        }

        public List<Customer> GetList()
        {
            return _icustomerdal.GetList();
        }

        public void Tdelete(Customer t)
        {
            _icustomerdal.Delete(t);
        }

        public void Tinsert(Customer t)
        {
            _icustomerdal.Insert(t);
        }

        public void Tupdate(Customer t)
        {
            _icustomerdal.Update(t);
        }
    }
}
