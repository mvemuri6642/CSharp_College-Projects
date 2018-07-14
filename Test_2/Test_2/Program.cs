using System;
using System.Security.Cryptography;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.Clear();
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Car myCar = new Car();
            Console.WriteLine("1.Submit Details:\n2.Show Details:\n3.Exit:");
            Console.WriteLine("Enter Choice:");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                Console.Clear();
                Console.WriteLine("Welcome:");
                Console.WriteLine("Enter The year:");
                myCar.Make = Console.ReadLine();
                Console.WriteLine("Successfully Entered {0}", myCar.Make);
                Console.ReadLine();
                return true;
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("DataBase Consists of {0}", myCar.Make);
                Console.ReadLine();
                return true;
            }
            else if( choice == "3")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Wrong Choice!");
                return true;
            }
        }
       

    }

    class Car
    {
        public string Make { get; set; }
    }
}