using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5
{
    /*
     * Problem 5
     * Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal 
     * number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by 
     * the number n (alone in a line) followed by n lines, each holding an integer number. DO NOT USE LOOPS FOR CALCULATIONS!!!
     */
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = new List<int>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                int cuurentNumber = int.Parse(Console.ReadLine());
                listOfNumbers.Add(cuurentNumber);
            }

            PrintResult("Minimal", listOfNumbers.Min());
            PrintResult("Maximal", listOfNumbers.Max());
            PrintResult("Sum", listOfNumbers.Sum());
            PrintResult("Average", listOfNumbers.Average());
        }

        private static void PrintResult(string message, double number)
        {
            Console.WriteLine("{0}: {1:F2}", message, number);
        }
    }
}
