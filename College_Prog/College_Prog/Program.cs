using System;

namespace College_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            //To Print Hello World
            /*Console.Write("Hello World!");
            Console.Read();*/



            



            //To Print n Value
            /*int i = 20;
            Console.WriteLine("{0},{1},{2},{3}", i, i = i + 10, i = i + 1, i = i++);
            Console.ReadLine();*/



            //Object Type Boxing
            /*object o;
            o = 10;
            Console.WriteLine("O={0}", o);
            Console.ReadLine();*/



            //Object Type Unboxing
            /*object o;
            o = 15;
            int i = (int)o;
            Console.WriteLine("i={0}", i);
            Console.ReadLine();*/



            //Dynamic Type
            /*dynamic a = 1;
            Console.WriteLine("a={0}", a);
            Console.ReadLine();*/



            //GetType
            /*int i = 20;
            double a = 14.5;
            Console.WriteLine("i={0},Type={1}\na={2},Type={3}", i, i.GetType(),a,a.GetType());
            Console.ReadLine();*/



            //String Type
            /*string s = "Hello";
            Console.WriteLine("s:{0}", s);
            Console.ReadLine();*/



            //implicit
            /*int x = 100;
              double y = x;
              Console.WriteLine("y={0}", y);
              Console.ReadLine()*/


            //Explicit
            /*int x;
              double y = 14.5;
              x = (int)y;
              Console.WriteLine("i={0}", x);
              Console.ReadLine();*/



            //Arrays
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = i + 1;
                Console.WriteLine("a[{0}]={1}", i, a[i]);
                Console.ReadLine();
            }


        }
    }
}
