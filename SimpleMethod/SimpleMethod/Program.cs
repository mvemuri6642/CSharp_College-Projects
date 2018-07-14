using System;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name:");
            string firstNameArray = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name:");
            string lastNameArray = Console.ReadLine();
            /*char[] firstName = firstNameArray.ToCharArray();
            Array.Reverse(firstName);
            char[] lastName = lastNameArray.ToCharArray();
            Array.Reverse(lastName);
            string result = " ";
            foreach (char item in firstName)
            {
                result += item;
            }
            result = " ";
            foreach (char item in lastName)
            {
                result += item;
            }
            Console.WriteLine("Result:" +result+" "+result);
            Console.ReadLine();*/

            void Display(string reversedFirstName,
                string reversedLastName)
            {

                Console.Write("Results: ");
                Console.WriteLine(String.Format("{0} {1}", reversedfirstNameArray,
                    reversedlastNameArray));
                Console.ReadLine();
            }

            string HelloWorld(string message)
            {
                char[] messageArray = message.ToCharArray();
                Array.Reverse(messageArray);
                return String.Concat(messageArray);
            }
            Console.Write(" ");

            void Display(string reversedFirstName, reversedLastName)
            {
                Console.Write("Results:");
                Console.WriteLine(String.Format("{0} {1}", reversedfirstNameArray, reversedlastNameArray));
                Console.ReadLine();
            }
        }
    }
}
