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
            Movies.MovieSelection selectSomeMovie = new Movies.MovieSelection();
            DatabaseR.Connection newConnection = new DatabaseR.Connection();
            selectSomeMovie.SelectMovie();
           
        }
    }
}

