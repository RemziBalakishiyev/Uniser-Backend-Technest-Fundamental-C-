using _11.Ders_Collections_.Classes;
using _11.Ders_Collections_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Collections_.Managers
{
    internal class BookManager : GenericManager<Book>, IBook
    {
     
        public BookManager():base(
            new List<Book>
            {
                new Book{Id=1,Name="1984",Price=18 },
                new Book{Id=2,Name="Martin Eden",Price=20 },
            })
        {
            

        }
      
        public void Update(int id, Book book)
        {
            foreach (var updatedBook in _list)
            {
                if (updatedBook.Id == id)
                {
                    updatedBook.Price = book.Price;
                    updatedBook.Name=book.Name;
                }
            }
        }
    }
}
