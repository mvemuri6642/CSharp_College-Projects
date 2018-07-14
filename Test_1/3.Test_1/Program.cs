using System;
using FirstNameSpace;
using SecondNameSpace;
using SecondNameSpace.ThirdNameSpace;
namespace FirstNameSpace
{
    class Program1
    {
        public void Student()
        {
            Console.WriteLine("What's Your Name?");
            Console.Write("Enter Your First Name:");
            string myFirstName = Console.ReadLine();

            Console.Write("Enter Your Last Name:");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, "+ myFirstName + " " + myLastName);
        }
    }
}
namespace SecondNameSpace
{
    class Program2
    {
        public void Marks()
        {
            Console.WriteLine("Marks:697");
        }
    }
    namespace ThirdNameSpace
    {
        class Program3
        {
            public void Age()
            {
                Console.WriteLine("Age:17");
            
            }
        }
    }
}
class mainclass
{
    static void Main(string[] args)
    {
        Program1 ob1 = new Program1();
        Program2 ob2 = new Program2();
        Program3 ob3 = new Program3();
        ob1.Student();
        ob2.Marks();
        ob3.Age();
        Console.ReadKey();
    }
}