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

            Console.Write("The average of the numbers; 14, 15, and 16 using floationg point values is... ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((14.0 + 15.0 + 16.0 + 17.0) / 4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            //Solve the circle question (5)

            Console.WriteLine("");

        }
    }
}
