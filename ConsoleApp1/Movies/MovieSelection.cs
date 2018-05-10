using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyService.Movies
{
    class MovieSelection
    {
        public static object SelectMovie()
        {
            List<object> movieList = new List<object>();
            //movieList.Add(Connection.ConnectingDb());

            Console.Write("Search\n Enter Movie Name: ");

            
            
            string movieName = Console.ReadLine();
            if(movieName != "")
            {
                foreach (var movie in movieList)
                {
                    Console.WriteLine(movie);
                }
            }
            return movieName;
        }
    }
}
