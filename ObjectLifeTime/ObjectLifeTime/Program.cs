using System;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Audi";
            myCar.Model = "i8";
            myCar.Year = "2016";
            myCar.Color = "Black";

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);

            myOtherCar.Make = "BMW";
            myOtherCar.Year = "2015";
            myOtherCar.Model = "M8";
            myOtherCar.Color = "White";
            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);
            Console.ReadLine();
        }

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
    }
}
