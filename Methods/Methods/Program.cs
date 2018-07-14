using System;

//Method Accesssing
/*namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetUser("Hello,World!");
            Console.ReadLine();
        }


        public static void GreetUser(string name)
        {
            char[] greetUser = name.ToCharArray();
            Array.Reverse(greetUser);
            Console.WriteLine(greetUser);
        }
    }
}*/


     //return a value:
namespace Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            int result = Add(8, 9);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
}

