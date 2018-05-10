using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyService.User
{
    class UserInteraction
    {
        public string name;
        public string serviceSelection;
        public string s_tab = "\t\t";

        public void UserDetails()
        {
            Console.Write("Enter your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hi {0}, Select one of the services we have\n" +
                "S1 - Save&Search movies\n" +
                "S2 - Search for Books\n" +
                "S3 - Manage Bills",name);
            Console.Write("Type S1,S2,S3 to start the service: ");
            serviceSelection = Console.ReadLine();

            if(serviceSelection == "S1" || serviceSelection == "S2" || serviceSelection == "S3")
            { 
                Console.WriteLine("{0} nice! {1} is ready", name, serviceSelection);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid Service Selected try again");
                Console.ReadKey();
            }
        }

        public void SystemStart()
        {
            Console.WriteLine("Welcome its System that does my chores\n");
            UserDetails();
        }
    }
}
