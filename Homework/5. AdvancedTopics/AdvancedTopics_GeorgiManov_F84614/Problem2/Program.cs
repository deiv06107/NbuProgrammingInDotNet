using System;
using System.Linq;

namespace Problem2
{
    /*
     * Problem 2
     * Write a program that reads a number n and a sequence of n integers, sorts them and prints them.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }

            var result = string.Join(" ", numbers.OrderBy(x => x));
            Console.WriteLine(result);
        }
    }
}
