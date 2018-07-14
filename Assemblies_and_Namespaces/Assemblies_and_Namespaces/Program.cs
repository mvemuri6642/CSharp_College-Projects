using System;
using System.IO;
using System.Net;

namespace Assemblies_and_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write to a Text File
            /*string text = "Hello";
            File.WriteAllText(@"D:\repos\Assemblies_and_Namespaces\Hello.txt",text);*/

            //Downloading Source code
            /*WebClient client = new WebClient();
            string reply = client.DownloadString("http://google.com");
            Console.WriteLine(reply);
            File.WriteAllText(@"D:\repos\Assemblies_and_Namespaces\Google.txt", reply);
            Console.ReadLine();*/
        }
    }
}
