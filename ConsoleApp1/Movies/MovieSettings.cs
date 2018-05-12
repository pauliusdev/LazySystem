using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyService.Movies
{
    class MovieSettings
    {
        public string NewMovies { get; set; }
        public string OldMovies { get; set; }
        public string VeryOldMovies { get; set;}

        
        public MovieSettings(string newMovies, string oldMovies, string veryOldMovies)
        {
            this.OldMovies = oldMovies;
            this.NewMovies = newMovies;
            this.VeryOldMovies = veryOldMovies;
        }

        DateTime old = new DateTime(2018, 2, 11);
        DateTime newDate = new DateTime(2018, 2, 11);
    }
}
