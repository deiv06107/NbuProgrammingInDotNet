using System;

namespace Problem2
{
    /*
     *Problem 2
     * Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible
     * by 3 and 7, on a single line, separated by a space. 
     */
    public class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var currentNumber = i + 1;
                var dividedByThree = currentNumber % 3 == 0;
                var dividedBySeven = currentNumber % 7 == 0;
                if (!dividedByThree && !dividedBySeven)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
    }
}
