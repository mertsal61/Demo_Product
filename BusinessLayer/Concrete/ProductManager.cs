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
    public class ProductManager : iGenericService<iProductService>
    {
        iProductDal _iproductdal;

        public ProductManager(iProductDal iproductdal)
        {
            _iproductdal = iproductdal;
        }

        public Product getbyid(int id)
        {
            return _iproductdal.getbyid(id);
        }

        public List<Product> GetList()
        {
            return _iproductdal.GetList();
        }

        public void delete(Product t)
        {
            _iproductdal.Delete(t);
        }

        public void insert(Product t)
        {
            _iproductdal.Insert(t);
        }

        public void update(Product t)
        {
            _iproductdal.Update(t);
        }
    }
}
