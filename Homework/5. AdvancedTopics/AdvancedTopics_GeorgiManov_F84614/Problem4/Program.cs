using System;

namespace Problem4
{
    /*
     * Problem 4
     * Write a program to find the longest word in a text
     */
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Some of these problems may require additional research. 
Not everithing needed for solving these problems was part of the lections.
At this point you must be able to find information by your self.
Use MSDN, StackOverflow or any other source you wish.

Problem 1

Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.

Problem 2

Write a program that reads a number n and a sequence of n integers, sorts them and prints them.

Problem 3

Write a program that takes as input two lists of names and removes from the first list all names given in the
second list

Problem 4

Write a program to find the longest word in a text

Problem 5

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal
number, the sum and the average of all numbers(displayed with 2 digits after the decimal point).The input starts by
the number n(alone in a line) followed by n lines, each holding an integer number.DO NOT USE LOOPS FOR CALCULATIONS!!!";

            var words = text.Split(new[] { ' ', '.', ',', '!', '?', '-', '(', ')', '\n' });
            var wordWithMaxLenght = string.Empty;
            foreach (var currentWord in words)
            {
                if (currentWord.Length > wordWithMaxLenght.Length)
                {
                    wordWithMaxLenght = currentWord;
                }
            }

            Console.WriteLine(wordWithMaxLenght);
        }
    }
}
