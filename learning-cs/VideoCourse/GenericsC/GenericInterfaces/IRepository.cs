using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaces
{
    internal interface IRepository<T> where T : IEntity // implments that and Id propertity must exists
    {
        void Add(T entity);
        void Remove(T entity);
    }
}
