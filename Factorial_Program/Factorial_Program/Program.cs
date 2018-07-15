using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.WriteLine("Choose a Number:");
            Console.WriteLine("1.Palindrome:");
            Console.WriteLine("2.Factorial:");
            Console.WriteLine("3.Hello");
            Console.WriteLine("4.Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Palindrome();
                return true;
            }
            else if (result == "2")
            {
                Factorial();
                return true;
            }
            else if (result == "3")
            {
                Hello();
                return true;
            }
            else if (result == "4")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void Palindrome()
        {
            int n, temp, rev, s = 0;
            Console.WriteLine("Enter n Value:");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                rev = n % 10;
                s = s * 10 + rev;
                n = n / 10;
            }
            if (temp == s)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("not Palindrome");
            }
            Console.ReadLine();
        }
        public static void Factorial()
        {
            int i, number, fact;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial Number:{0}" ,fact);
            Console.ReadLine();
        }
        public static void Hello()
        {
            Console.WriteLine("Hello");
            Console.ReadLine();
        }

    }
}
