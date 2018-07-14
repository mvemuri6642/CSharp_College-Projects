using System;

namespace College_Prog3
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, n, r;

            Console.WriteLine("Enter the Table number:");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n value to print maximum numbers:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {

                Console.WriteLine("{0}X{1}={2}", r, i, r * i);
            }
            Console.ReadLine();
        }
    }
}
