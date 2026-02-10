using System.Globalization;

namespace Topic_2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Brendan McCausland
            Console.Write("I was born in the year ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(2026 - 17);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.Write("The average of the numbers; 14, 15, and 16 is... ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((14 + 15 + 16) / 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.Write("The average of the numbers; 14, 15, 16, and 17 using floationg point values is... ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((14.0 + 15.0 + 16.0 + 17.0) / 4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.Write("Using the equation A=πr^2, the area of a circle with a radius of 3 is... ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((3.14 * 3.0) * (3.14 * 3.0));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.WriteLine("C# knows to add when there are two numerical values on each side of the "+" symbol. The computer can only add two integer's or floating point values together to get the proper answer to the question. If one side is a string of text, the computer will remove the space and merge both sides together.");

        }
    }
}
