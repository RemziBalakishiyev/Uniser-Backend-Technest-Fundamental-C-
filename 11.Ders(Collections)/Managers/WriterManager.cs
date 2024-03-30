using _11.Ders_Collections_.Classes;
using _11.Ders_Collections_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Collections_.Managers
{
    internal class WriterManager:GenericManager<Writer>,IWriter
    {
        private readonly List<Writer> _writers;
        public WriterManager():base(new List<Writer>
            {
                new Writer{Id=1,FirstName = "George", LastName = "Orwel" },
                new Writer{Id=2,FirstName="Feodor",LastName="Dostoyevski" },
            })
        {
           
        }
       
        public void Update(int id, Writer writer)
        {
            foreach (var updatedWriter in _writers)
            {
                if (updatedWriter.Id == id)
                {
                    updatedWriter.FirstName = writer.FirstName;
                    updatedWriter.LastName = writer.LastName;
                }
            }
        }
    }
}
