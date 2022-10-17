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
    public class CustomerManager : iGenericService<Customer>
    {
        iCustomerDal _customerdal;

        public CustomerManager(iCustomerDal customerdal)
        {
            _customerdal = customerdal;
        }

        public Customer getbyid(int id)
        {
           return _customerdal.getbyid(id);
        }

        public List<Customer> GetList()
        {
            return _customerdal.GetList();
        }

        public void delete(Customer t)
        {
            _customerdal.Delete(t);
        }

        public void insert(Customer t)
        {
            _customerdal.Insert(t);
        }

        public void update(Customer t)
        {
            _customerdal.Update(t);
        }

        public List<Customer> GetCustomerListwithjob()
        {
            return _customerdal.GetListwithjob();
        }
    }
}
