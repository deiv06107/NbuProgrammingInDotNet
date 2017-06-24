using System;

namespace Problem1
{
    /*
     * Problem 1
     * Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two dates in format dd.MM.yyyy");
            DateTime first = DateTime.Parse(Console.ReadLine());
            DateTime second = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("The number of days between them: {0}", Math.Abs((first - second).Days));
        }
    }
}
