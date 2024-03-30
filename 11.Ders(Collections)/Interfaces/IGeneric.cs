using _11.Ders_Collections_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Collections_.Interfaces
{
    internal interface IGeneric<T> where T:  ITable, new()
    {
        void Add(T data);
        void Delete(int id);
        IEnumerable<T> GetAll();

        T GetById(int id);
    }
}
