using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2
            // Create an int Array and populate numbers 1-10
            int[] myInts = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var evens = new List<int>();

            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 0; i < myInts.Length; i++)
            {
                if ((myInts[i] % 2) == 0 )
                {
                    evens.Add(myInts[i]);
                }
                else
                {
                    odds.Add(myInts[i]);
                }
            }


            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            
            Console.WriteLine("Evens:");
            foreach (var number in evens)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Odds:");
            foreach (var numberA in odds)
            {
                Console.Write($"{numberA} ");
            }
            Console.WriteLine();
        }
    }
}
