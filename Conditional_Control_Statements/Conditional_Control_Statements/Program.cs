using System;

namespace Conditional_Control_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple if Program
            /*int a = 15;
            if (a >= 10)
            {
                Console.WriteLine("a Value is Greater than 10");
            }
            Console.ReadLine();*/






            //if else Program
            /*int a, b;
            Console.WriteLine("Enter a Value:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b Value:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("a Value is Big");
            }
            else
            {
                Console.WriteLine("c Value is big");
            }
            Console.ReadLine();*/






            //else if ladder
            /*int a, b, c;
            Console.WriteLine("Enter a Value:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b Value:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c Value:");
            c = Convert.ToInt32(Console.ReadLine());
            if(a>b && a > c)
            {
                Console.WriteLine("a Value is Big");
            }
            else if (b > c)
            {
                Console.WriteLine("b Value is Big");
            }
            else
            {
                Console.WriteLine("c Value is Big");
            }
            Console.ReadLine();*/







            //nested if Program
            /*int a, b, c;
            Console.WriteLine("Enter a Value:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b Value:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c Value:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a Value is Big");
                }
                else
                {
                    Console.WriteLine("b Value is Big");
                }
            }
            else if (b > c)
            {
                Console.WriteLine("b Value is Big");
            }
            else
            {
                Console.WriteLine("c Value is Big");
            }
            Console.ReadLine();*/





            //Switch Program
            int a,b,c, d;
            Console.WriteLine("Enter a Value:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b Value:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c Value:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Choice:");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1:
                    Console.WriteLine("Addition");
                    c = a + b;
                    Console.WriteLine("{0}", c);

            }
            Console.ReadLine();
        }
    }
}
