using System;

namespace Problem1
{
    /*
     * Problem 1
     * Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space
     */
    public class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write(i + 1 + " ");
            }
        }
    }
}
