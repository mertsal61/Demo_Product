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
    public class Categorymanager : iCategoryService
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

        public void Tdelete(Category t)
        {
            _icategorydal.Delete(t);
        }

        public void Tinsert(Category t)
        {
            _icategorydal.Insert(t);
        }

        public void Tupdate(Category t)
        {
            _icategorydal.Update(t);
        }
    }
}
