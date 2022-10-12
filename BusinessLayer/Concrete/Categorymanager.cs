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
    public class Categorymanager : iGenericService<Category>
    {
        iCategoryDal _icategorydal;

        public Categorymanager(iCategoryDal icategorydal)
        {
            _icategorydal = icategorydal;
        }

        public Category getbyid(int id)
        {
            return _icategorydal.getbyid(id);
        }

        public List<Category> GetList()
        {
            return _icategorydal.GetList();
        }

        public void delete(Category t)
        {
            _icategorydal.Delete(t);
        }

        public void insert(Category t)
        {
            _icategorydal.Insert(t);
        }

        public void update(Category t)
        {
            _icategorydal.Update(t);
        }
    }
}
