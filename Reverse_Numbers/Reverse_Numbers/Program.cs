using System;

namespace Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter i Value:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            while (i >= 1)
            {
                Console.WriteLine("{0}", i);
                i--;
            }
            Console.ReadLine();
        }
    }
}
