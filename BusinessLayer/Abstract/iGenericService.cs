using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface iGenericService<T>
    {
        void Tinsert(T t);
        void Tdelete(T t);
        void Tupdate(T t);  
        List<T> GetList();

        T getbyid(int id);  

    }
}
