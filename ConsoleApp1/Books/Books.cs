using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyService.Books
{
    class Books
    {
        private int BookAge = 0;
        private string BookAuthor = "";

        public static object BookPriceAndAge()
        {

            Console.Write("Enter your allowance: ");
            string age = Console.ReadLine();
            Console.Write("Enter year of the book: ");
            string price = Console.ReadLine();

            if (age != "" && price != "")
            {
                Console.WriteLine("Selected book age is {0}Y:" +
                    " and the price is {1}$", age, price);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid values for the age or price");
                Console.ReadKey();
            }

            return age + " " + price;
        }
    }
}
