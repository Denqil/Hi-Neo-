using System;

namespace wirk1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа с консолью";

            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;


            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("Wake up, Neo...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("The Matrix has you...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Follow the white rabbit.");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Knock, knock, Neo.");
            Console.ReadKey();
            Console.Clear();

            Console.ReadLine();
        }
    }
}
