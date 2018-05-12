using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyService.Movies
{
    class MovieLib
    {
        public void AddMovie(string movie)
        {
            if(movie != "")
            {
                movieList.Add(movie);
                foreach (var item in movieList)
                {
                    Console.WriteLine(item);
                }
            }
        }
        List<string> movieList = new List<string>();
    }
}
