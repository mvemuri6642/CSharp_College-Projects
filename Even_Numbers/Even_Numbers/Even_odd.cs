using System;

namespace Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Even or Odd
            /*int n;
            Console.WriteLine("Enter n value:");
            n = Convert.ToInt32(Console.ReadLine());
            string Message = (n%2==0) ? "Even" : "odd";
            Console.WriteLine(Message);
            Console.ReadLine();*/



            //Even Numbers
            /*int i, n, sum = 0;
            Console.WriteLine("Enter n Value:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= 10; i+=2)
            {

                sum = sum + i;
                Console.WriteLine("{0}\t{1}", i, sum);
            }
            Console.ReadLine();*/




            //odd numbers
            /*int i, n;
            Console.WriteLine("Enter n Value:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i += 2)
            {
                Console.WriteLine("{0}", i);
            }
            Console.ReadLine();*/



            int i, n, sum = 0;
            Console.WriteLine("Enter n Value:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i += 2)
            {
                sum = sum + i;
                Console.WriteLine("{0}\t{1}", i, sum);
            }
            Console.ReadLine();
        }
    }
}
