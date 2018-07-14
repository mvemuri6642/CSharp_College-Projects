using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Console.WriteLine("Choose a Number:");
                 Console.Write(" 1 , 2 or 3:\n");
                 string userValue = Console.ReadLine();
                 string message = "";   //Scope and Lifetime of Variables. Declaring variable message outside of if statements

                 if (userValue == "1")
                 {
                     message = "You Won a Mobile";
                 }
                 else if (userValue == "2")
                 {
                     message = "You Won a Bike";
                 }
                 else if(userValue == "3")
                 {
                     message = "You Won a Car";
                 }
                 else
                 {
                     message = "Sorry I didn't Understand.";
                     //message = message + "You Loose."; //String Concatination
                     message += "You Loose."; //Asigning a Value and String Concatination
                 }
                 Console.WriteLine(message);
                 Console.ReadLine(); */


            
            Console.WriteLine("Choose a Number:");
            Console.Write(" 1 , 2 or 3:\n");
            string userValue = Console.ReadLine();
            string message = (userValue == "2") ? "Won a Boat" : "Lost it";
            /*Console.Write("You");
            Console.Write(message);
            Console.Write("."); */


            //Console.WriteLine("You {0}.", message); //the above message will be displayed at here - {0}


            Console.WriteLine("You have entered {0}.Therefore You {1}",userValue,message); //here we're printing both values
        
            Console.ReadLine();
        }
    }
}
