using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMPP.Repository
{
    interface IRepository<T>
    {
        void addEntity(T entity);
        void deleteEntity(T entity);
        List<T> getAll();
        void findOne(T entity);
    }
}
