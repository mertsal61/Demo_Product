using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class jobmanager : iGenericService<ijobservice>
    {
        ijobdal _ijobdal;

        public jobmanager(ijobdal ijobdal)
        {
            _ijobdal = ijobdal;
        }

        public void delete(Job t)
        {
            _ijobdal.Delete(t);
        }

        public Job getbyid(int id)
        {
            return _ijobdal.getbyid(id);
        }

        public List<Job> GetList()
        {
            return _ijobdal.GetList();
        }

        public void insert(Job t)
        {
            _ijobdal.Insert(t);
        }

        public void update(Job t)
        {
            _ijobdal.Update(t);
        }
    }
}

