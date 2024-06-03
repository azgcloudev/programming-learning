using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaces
{
    internal interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
    }
}
