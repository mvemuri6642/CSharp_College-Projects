using System;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Year:");
            n = Convert.ToInt32(Console.ReadLine());
            string Message = (n % 4 == 0) ? "Leap Year" : "Not Leap Year";
            Console.WriteLine(Message);
            Console.ReadLine();

        }
    }
}
