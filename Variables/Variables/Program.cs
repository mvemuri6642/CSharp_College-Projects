using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 3;
            y = x + 5;
            Console.WriteLine(y);
            Console.ReadLine();
            */



            // Reading the Given Input Values:
            Console.WriteLine("What's Your Name:");
            Console.Write("Enter Your First Name:");
            string myFirstName;
            myFirstName = Console.ReadLine();

            /*Console.Write("Enter Your Last Name:");
            string myLastName;
            myLastName = Console.ReadLine();*/
            Console.WriteLine("Enter Your Last Name");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello,\n" + myFirstName + " " + myLastName);
            Console.ReadLine();

        }
    }
}
