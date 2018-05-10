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
            User.UserInteraction askUser = new User.UserInteraction();
            Movies.MovieSelection selectSomeMovie = new Movies.MovieSelection();
            selectSomeMovie.SelectMovie();
        }
    }
}

