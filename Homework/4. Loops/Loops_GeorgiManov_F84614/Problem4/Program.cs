using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4
{
    /*
     * Problem 4
     * Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop
     */
    public class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k;

            do
            {
                ReadInput(out k, out n);
            } while (!ValidInput(k, n));

            Console.WriteLine("{0}! / {1}! = {2}", n, k, GetCalculations(k, n));
        }

        private static double GetCalculations(int k, int n)
        {
            double result = 1;
            for (int i = k + 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }

        private static void ReadInput(out int k, out int n)
        {
            Console.WriteLine("Program that calculates n! / k!");
            Console.WriteLine("Provide k & n, where (1 < k < n < 100)");
            k = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
        }

        private static bool ValidInput(int n, int k)
        {
            if (n < 1 || n > 100)
            {
                return false;
            }

            if (k < 1 || k > 100)
            {
                return false;
            }

            if (n > k)
            {
                return false;
            }

            return true;
        }
    }
}
