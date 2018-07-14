using System;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.WriteLine("Choose a Number:");
            Console.WriteLine("1.Printing Numbers:");
            Console.WriteLine("2.Guessing Game:");
            Console.WriteLine("3.Exit");
            string result = Console.ReadLine();
            if(result == "1")
            {
                PrintingNumbers();
                return true;
            }
            else if(result == "2")
            {
                GuessingGame();
                return true;
            }
            else if(result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void PrintingNumbers()
        {
            Console.Clear();
            Console.WriteLine("Enter a Number:");
            int result = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < result+1)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();
        }

        public static void GuessingGame()
        {
            Console.Clear();
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a Number between 1 and 10:");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong!");

            } while (incorrect);
            Console.WriteLine("Correct it took you:{0} guesses", guesses);
            Console.ReadLine();
        }
    }
}
