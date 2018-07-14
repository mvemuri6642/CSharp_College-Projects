using System;

namespace Marks_else_if_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            int sub1,sub2,sub3,sub4,sub5,Marks,Total=500,TotalScored;
            Console.WriteLine("Enter Subject 1 Marks:");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject 2 Marks:");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject 3 Marks:");
            sub3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject 4 Marks:");
            sub4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject 5 Marks:");
            sub5 = Convert.ToInt32(Console.ReadLine());
            TotalScored = sub1 + sub2 + sub3 + sub4 + sub5;
            Marks = (100*TotalScored) / Total;
            Console.WriteLine("TotalScored :{0}/{1}", TotalScored,Total);
            if (Marks >= 35)
            {
                Console.WriteLine("Average :{0}%\nResult :Pass", Marks);
            }
            else if(Marks < 35)
            {
                Console.WriteLine("Average :{0}%\nResult :Fail", Marks);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadLine();
        }
    }
}
