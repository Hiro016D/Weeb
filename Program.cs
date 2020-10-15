using System;

namespace Weeb
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;

            Console.Write("Input a number: ");
            num01 = Convert.ToInt32( Console.ReadLine() );

            Console.Write("Input a second number");
            num02 = Convert.ToInt32( Console.ReadLine() );
            
            int result = num01 * num02;
            Console.Write("The result is " + result);

            //wait's before closing terminal
            Console.ReadKey();
        }
    }
}