using _11.Ders_Collections_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Collections_.Classes
{
    internal class Book:ITable
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
