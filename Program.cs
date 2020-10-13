using System;

namespace Weeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cockeru bro...";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WindowHeight = 40;
            Console.WriteLine("I love Cockeru!");

            Console.ReadLine();
            
            Console.WriteLine("My name is Hiro. I love myself some delicious cockeru.");
            Console.WriteLine("What is your favorite Color");

            Console.ReadLine();

            Console.WriteLine("Cool. Mine is Light Blue!");

            Console.ReadKey();
        }
    }
}