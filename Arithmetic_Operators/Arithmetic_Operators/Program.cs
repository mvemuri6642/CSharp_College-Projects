using System;

namespace Arithmetic_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 10, Addition, Multiplication, Subtraction, Division;
            Addition = a + b;
            Subtraction = a - b;
            Multiplication = a * b;
            Division = a / b;
            Console.WriteLine("Addition:{0},\nSubtraction:{1},\nMultiplication:{2},\nDivision:{3}",
                Addition, Subtraction, Multiplication, Division);
            Console.ReadLine();
        }
    }
}
