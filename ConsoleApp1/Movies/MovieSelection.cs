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
        private string addingMovieName;

        List<object> movieList = new List<object>();


        public void SelectMovie()
        {
            List<object> movieList = new List<object>();
            Console.Write("Search\n Add movie name to your list:  ");
            addingMovieName = Console.ReadLine();

            if(addingMovieName != "")
            {
                movieList.Add(addingMovieName);
                foreach (var item in movieList)
                {
                    Console.WriteLine(item);
                }
                Console.Write("Want to add another movie ? Y/N: ");
                var yesNo = Console.ReadLine();
                if(yesNo == "Y")
                {
                    SelectMovie();
                }
                else
                {
                    Console.WriteLine("Thanks for adding your favorite movies");
                }
            Console.ReadKey();
            AskUserToCheckTheList();
            }
        }

        public void AskUserToCheckTheList()
        {
            Console.Write("Would you like to view your movie list? Y/N: ");
            var yesNo = Console.ReadLine();

            if (yesNo == "Y")
            {
                Console.WriteLine(movieList);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Thanks for adding your favorite movies");
            }
            Console.WriteLine("Here are your selected movies");
        }
    }
}
