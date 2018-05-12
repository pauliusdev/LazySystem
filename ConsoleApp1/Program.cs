using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyService
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies.MovieLib movies = new Movies.MovieLib();

            Movies.MovieLib test = new Movies.MovieLib();
            //Movies.MovieSettings movies1 = new Movies.MovieLib();
            Console.Write("Enter Name of the movie: ");
            var userInput = Console.ReadLine();
            movies.AddMovie(userInput);
            Console.ReadKey();
        }
    }
}

