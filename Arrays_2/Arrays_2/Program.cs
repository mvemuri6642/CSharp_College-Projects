using System;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*****Fun With Arrays*****");
            SimpleArrays();
            Console.ReadLine();
        }
        static void SimpleArrays()
        {
            //Array Declaration
            /*Console.WriteLine("Simple Array Creation");
            int[] myInt = new int[3];
            string[] myString = new string[30];
            myInt[0] = 2;
            myInt[1] = 3;
            myInt[2] = 4;
            myString[1] = "Manohar";
            foreach (int i in myInt)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();*/



            //Array Initialization
            /*Console.WriteLine("SImple Array");
            string[] myInt = new string[] { "Manohar", "Teja", "Manu" };
            Console.WriteLine("Array elements are:{0} {1} {2}", myInt);
            Console.ReadLine();  **/


            //Array Initialization without using "new" Keyword
            /*string[] newString = { "Manohar", "Teja", "Manu" };
            Console.WriteLine("Array elements are:{0}",newString.Length);*/




            // Array initialization with new keyword and size
            /*int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("Array has {0} elements", intArray.Length);
            Console.WriteLine();*/


            //Size declaration error
            /*int[] newInt = new int[2] { 1, 2, 3 };
            Console.WriteLine("Array has {0} elements",newInt.Length);*/





            // Implicitly Typed Local Arrays
            // Interger datatype
            /*var x = new[] { 1, 2, 3 };
            Console.WriteLine("x has {0}", x.ToString());   // ToString() is used to represent the datatype of the variable
            Console.ReadLine();*/



            // Double datatype
            /*var y = new[] { 2.5, 3.5, 5.5 };
            Console.WriteLine("y has {0}", y.ToString());
            Console.ReadLine(); */



            //String 
            /*var z = new[] { "Manohar", "Teja", "Manu" };
            Console.WriteLine("z has {0}", z.ToString());
            Console.ReadLine();*/



            //Mixed type datatype error
            /*var a = new[] { "manu", 1, "2.5" }; //compile time error
             */



            // ArrayOfObjects()
            object[] newObject = new Object[5];
            newObject[0] = false;
            newObject[1] = "sai";
            newObject[2] = 2;
            newObject[3] = new DateTime(2000, 11, 1);
            foreach (object obj in newObject)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();



        }
    }
}
