using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface iGenericService<T>
    {
        void insert(T t);
        void delete(T t);
        void update(T t);  
        List<T> GetList();

        T getbyid(int id);  

    }
}
