using System;
using System.Collections.Generic;

namespace Problem3
{
    /*
     * Problem 3
     * Write a program that takes as input two lists of names and removes from the first list all names given in the second list
     */
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>() { "Gosho", "Pesho", "Tosho", "Maria" };
            var secondList = new List<string>() { "Pesho", "Tosho" };

            var solution1 = Solution1(firstList, secondList);
            PrintResult(solution1);

            var solution2 = Solution2(firstList, secondList);
            PrintResult(solution2);
        }

        private static List<string> Solution1(List<string> firstList, List<string> secondList)
        {
            var resultNames = new List<string>();

            foreach (var nameInFirstList in firstList)
            {
                if (!secondList.Contains(nameInFirstList))
                {
                    resultNames.Add(nameInFirstList);
                }
            }

            return resultNames;
        }

        private static List<string> Solution2(List<string> firstList, List<string> secondList)
        {
            return firstList.FindAll(x => !secondList.Contains(x));
        }

        private static void PrintResult(List<string> resultNames)
        {
            Console.WriteLine(string.Join(", ", resultNames));
        }
    }
}
