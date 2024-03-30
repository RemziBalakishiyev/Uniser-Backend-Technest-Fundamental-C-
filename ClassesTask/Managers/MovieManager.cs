using ClassesTask.Classes;
using ClassesTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask.Managers
{
    internal class MovieManager : IMovie
    {
        public Movie _movie;
        public MovieManager(Movie movie)
        {
            _movie = movie;
        }
        public void Subtitles()
        {
            Console.WriteLine($"Name : {_movie.Name} yazi əlavə olundur");
        }

        public void Watching()
        {
            Console.WriteLine($"Id - {_movie.Id} -- {_movie.}  ,  adlı filmi izlənməyə başlandı");
        }
    }
}
