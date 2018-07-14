using System;

namespace Test_3
{
    // 1. Simple Class and Objects Program to find Volume of Box
    /*class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            b1.width = 10;
            b1.height = 10;
            b1.depth = 10;
            b1.volume();
        }
    }
    public class Box
    {
        public double width, height, depth;
        public void volume()
        {
            Console.WriteLine("Volume of Box is : " + width * height * depth);
            Console.ReadLine();
        }
    }*/


    // 2. Class and Objects Program to find out the Volume of the Box using Parameterised Constructor Method

    /*class Progarm
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(10, 10, 10);
            double vol;
            vol = b1.Volume();
            Console.WriteLine("Volume of Box is : " + vol);
            Console.ReadLine();
        }
    }

    class Box
    {
        double length, bredth, height;
        public Box(double l,double b,double h)
        {
            length = l;
            bredth = b;
            height = h;
        }
        public double Volume()
        {
            return (length * bredth * height);
        }
    } */


    // 3. Class and objects Program to find volume of box to return value


    /*class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            b1.height = 10;
            b1.width = 10;
            b1.depth = 10;
            double vol = b1.Volume();
            Console.WriteLine("Volume of Box is : " + vol);
            Console.ReadLine();
        }
    }
    
    class Box
    {
        public double width, height, depth;
        public double Volume()
        {
            return (width * height * depth);
        }
    } */


    // 4. Class and Objects to find out Volume of Box using parameterised Method


    /*class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            b1.setdim(10, 10, 10);
            double vol = b1.Volume();
            Console.WriteLine("Volume is : " + vol);
            Console.ReadLine();
        }
    }
    class Box
    {
        public double width, height, depth;
        public void setdim(double w,double h, double d)
        {
            width = w;
            height = h;
            depth = d;
        }
        public double Volume()
        {
            return (width * height * depth);
        }
    } */

    //Method Overloading
    /* class Program
    {
        static void Main(string[] args)
        {
            over ob = new over();
            ob.test();
            ob.test(10);
            ob.test(10, 20);
            double result = ob.test(123.5);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    class over
    {
        public void test()
        {
            Console.WriteLine("No Parameters!");
            Console.ReadLine();
        }
        public void test(int a)
        {
            Console.WriteLine("a : " + a);
            Console.ReadLine();
        }
        public void test(int a,int b)
        {
            Console.WriteLine("a and b:" + a + "," + a);
            Console.ReadLine();
        }
        public double test(double a)
        {
            return test(a * a);
        }
    }*/


}
