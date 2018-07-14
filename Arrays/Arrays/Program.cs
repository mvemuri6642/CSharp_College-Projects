using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 5;
            numbers[3] = 15;
            numbers[4] = 19;
            //numbers[5] = 29; //Exception : System.IndexOutOfRangeException
            //Console.WriteLine(numbers[3]); //Accessing the Array
            Console.WriteLine(numbers.Length); //Length of an Array
            Console.ReadLine(); */


            //int numbers = new int[5] { 1, 15, 18 }; //Create and initialize an array
            //int numbers = new int[] { 5, 15, 16 }; //omiting an Array Size
            //string[] names = new string[] { "Sai", "Seshu", "Siva" };
            /*for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }*/

            /*foreach (string name in names)  //creating a temporary String variable called name
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();*/



            //reversing an Array
            string name ="RAHONAM IAS IRUMEV";
            char[] charArray = name.ToCharArray(); /*ToCharArray() method is used to get character array from a string object
                                                      and Seperates each character in a string*/
            Array.Reverse(charArray); //reversing an Array

            foreach (char namechar in charArray)
            {
                Console.Write(namechar);
            }
            Console.ReadLine();
        }
    }
}
