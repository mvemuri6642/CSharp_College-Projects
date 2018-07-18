//Dear Programmer,
//When i Wrote this Code, only God and i Knew How it Worked!
//but now only god knows it...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using AccessSpecifiers_ExceptionHandling2;

namespace AccessSpecifiers_ExceptionHandling
{
    //Public Access Specifier
    /*class Program
    {
        static void Main(string[] args)
        {
            Square ob1 = new Square();
            ob1.size = 10;
            ob1.DisplayArea();
            Console.ReadLine();
        }
    }

    class Square
    {
        public int size;
        public int Area()
        {
            return size * size;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area of Square is:{0}", Area());
        }
    }*/



    //Private Access Specifier
    /*class Program
    {
        static void Main(string[] args)
        {
            square ob1 = new square();
            ob1.DisplayArea();
            Console.ReadLine();
        }
    }

    class square
    {
        private int size = 5;
        private int Area()
        {
            return size * size;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area of Square is:{0}", Area());
        }
    }*/



    //Protected Access Specifier
    /*class Program
    {
        static void Main(string[] args)
        {
            Square ob1 = new Square();
            ob1.DisplayArea();
            Console.ReadLine();
        }
    }

    class Size
    {
        protected int s=6;
    }
    class Square : Size
    {
        public int Area()
        {
            return s * s;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area of Square is:{0}", Area());
        }
    }*/


    //internal Access Specifier
    /*class Program
    {
        static void Main(string[] args)
        {
            Square ob1 = new Square();
            ob1.s = 7;
            ob1.DisplayArea();
            Console.ReadLine();
        }
    }
    class Square
    {
        internal int s;
        internal int Area()
        {
            return s * s;
        }
        internal void DisplayArea()
        {
            Console.WriteLine("Area of Square is:{0}", Area());
        }
    }*/





    //Internal Protected Access Specifier
    /* class B : A
     {
         public void show()
         {
             Console.WriteLine(s);
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             B ob1 = new B();
             ob1.show();
             Console.ReadLine();
         }
     }*/



    //Pre-Defined Exception Handling
    /*class dividebyZero
    {
        int result = 0;
        public void Division(int n1,int n2)
        {
            try
            {
                result = n1 / n2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception Caught:{0}", e);
            }
            finally
            {
                Console.WriteLine("Result:{0}", result);
            }
        }
        static void Main(string[] args)
        {
            dividebyZero ob1 = new dividebyZero();
            ob1.Division(10,5);
            Console.ReadLine();
        }
    }*/



    //User Defined Exception Handling
    class Program
    {
        static void Main(string[] args)
        {
            int acceptorder;
            Console.WriteLine("Welcome to Shopping Site:\nHow many headphone you want to buy (Total 10 in Stock):");
            acceptorder = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (acceptorder == 10 || acceptorder < 10)
                {
                    Console.WriteLine("Congratulations! You have bought {0} headphones", acceptorder);
                    Console.ReadLine();
                }
                else
                {
                    throw (new OutofStockException("OutofStockException Generated: The number of item you want to buy is out of stock. Please enter total item number within stock"));
                }
            }
            catch (OutofStockException oex)
            {
                Console.WriteLine(oex.Message.ToString());
                Console.ReadLine();
            }

        }
    }

    //Creating Custome Exception - OutofStockException
    public class OutofStockException : Exception
    {
        public OutofStockException(string message)
            : base(message)
        {
        }
    }

}


//Internal Protected Access Specifier
/*namespace AccessSpecifiers_ExceptionHandling2
{
    class A
    {
        protected internal int s = 8;
    }
}*/
