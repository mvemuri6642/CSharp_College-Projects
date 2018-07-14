using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My name is \"Manohar\"";

            //string myString = "Go to C:\\ Drive";       /*if we want to use back slash as it is we need to use another backward slash before the original one or we can use @ */
            //string myString = @"Go to C:\ Drive";

            //string myString = string.Format("{0}&{1}","First","Second"); //inserting first and second strings into these templets.

            //string myString = string.Format("{0:C}", 150.0); //used to represent $ Symbol.

            //string myString = string.Format("{0:N}",123); //used to represent the integer value in decimal value.

            //string myString = string.Format("Percent:{0:P}",.78); //used to represent percentage.you should give period before the integer.

            //string myString = string.Format("Phone Number:{0:(+##)##########}", 917659911722); //used to represent the value in Mobile Format.

            /*string myString = "Cross my heart, hope to die " +
                "To my lover, I'd never lie " +
                "He said \"be true,\" I swear I'll try " +
                "In the end, it's him and I "; */

            //myString = myString.Substring(4, 16); //Substring is used to display particular characters in the string

            //myString = myString.ToUpper(); //used to convert the original string into UPPER CASE.

            //myString = myString.ToLower();  //converts into Lowercase Letters.

            //myString = myString.Replace(" ", "_"); //used to replace the character in the string.

            //myString = myString.Remove(6, 14);    //used to remove the characters in the string.

            //myString = String.Format("Length Before{0} -- Length After{1}",myString.Length ,myString.Trim().Length); //used to trim the string.

            /*string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString(); //concatinating -- and current value of i as we loop through 100 times to myString.
            } */


            /*System.Text.StringBuilder myString = new System.Text.StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }*/                     
            
                                    /*At this tmime,instead of just doing the concatination we are going 
                                    to use Append Method which is more efficient way to append information
                                    to the StringBuilder object rather than,creating temporary versions 
                                    of string but the result will look identical to the privious one.
                                    use "System.Text.StringBuilder" if "StringBuilder" is not found. */



            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
