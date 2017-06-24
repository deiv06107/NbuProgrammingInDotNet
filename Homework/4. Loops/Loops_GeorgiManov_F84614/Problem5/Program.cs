using System;

namespace Problem5
{
    /*
Problem 5

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the 
examples below. Use two nested loops. 

Examples:

n	matrix
2	1 2
    2 3

n	matrix
3	1 2 3
    2 3 4
    3 4 5

n	matrix
4	1 2 3 4
    2 3 4 5
    3 4 5 6
    4 5 6 7

     */
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(row + col + 1 + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
