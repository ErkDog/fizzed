using System;
using System.Collections.Generic;

namespace ConsoleApp1_TheBasics
{
    class Program
    {
        /// <summary>
        /// Write a console application, using your SuperFizzBuzz class, to solve the classic FizzBuzz problem as described above in “The Basics”.
        ///     Regular fizzbuzz output is typically described as “Write a program that prints the numbers from 1 to 100. But for multiples of 3, 
        ///     print “Fizz” instead of the number. For multiples of 5, print “Buzz”. For Multiples of 3 and 5, print “FizzBuzz”.
        /// </summary>
        static void Main(string[] args)
        {
            // Note: Requirements 2 and 3 should not require command line parsing to complete. 
            var tokens = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz")
            };

            var superFizzBuzz = new SuperFizzBuzz.SuperFizzBuzz();
            var theBasics = superFizzBuzz.GetSuperFizzBuzz(1, 100, tokens);
            foreach (var token in theBasics)
            {
                Console.WriteLine(token);
            }
            Console.WriteLine("\r\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
