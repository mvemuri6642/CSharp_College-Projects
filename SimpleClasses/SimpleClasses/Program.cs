using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Model = "Audi";
            myCar.Year = 2000;
            Console.WriteLine("Model: {0} \nYear : {1} ", myCar.Model, myCar.Year);
            Console.WriteLine("Car Market Value is {0:C}", myCar.DetermineCarMarketValue());
            Console.ReadLine();

        }
    }

    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public decimal DetermineCarMarketValue()
        {
            decimal carValue = 100.0M;
            if ( carValue > 2015)
            {
                carValue = 1000000;
            }
            else
            {
                carValue = 50000;
            }
            return carValue;
        }
    }  
}
