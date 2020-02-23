using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Struct
{
    // Example for the difference between a struct and a class
    // change the type of User from struct to class
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Georgi", "Ivanov", "Georgiev");

            string fullName = user1.ToString();
            Console.WriteLine("User1 name: {0}", fullName);

            User user2 = user1;
            user2.FirstName = "Ivan";
            fullName = user1.ToString();
            // user1 fullname is not changed when User is a struct and is changed when it is a class
            Console.WriteLine("User1 Name after change in user2: {0}", fullName);

            string initials = user1.Initials();
            Console.WriteLine("Initials: {0}", initials);
        }
    }
}
