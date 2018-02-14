using System;
using System.Collections.Generic;

namespace ConsoleApp2_Advanced
{
    class Program
    {
        /// <summary>
        /// Write a second console application demonstrating advanced usage of SuperFizzBuzz that performs the following:
        ///     Print the numbers from -12 through 145.
        ///     For multiples of 3, print “Fizz”
        ///     For Multiples of 7, print “Buzz”
        ///     For Multiples of 38, print “Bazz”
        ///     Print the appropriate combination of tokens for any number that matches more than one of those rules
        /// </summary>
        static void Main(string[] args)
        {
            // Note: Requirements 2 and 3 should not require command line parsing to complete. 
            var tokens = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(7, "Buzz"),
                new Tuple<int, string>(38, "Bazz")
            };

            var superFizzBuzz = new SuperFizzBuzz.SuperFizzBuzz();
            var advanced = superFizzBuzz.GetSuperFizzBuzz(-12, 145, tokens);
            foreach (var token in advanced)
            {
                Console.WriteLine(token);
            }
            Console.WriteLine("\r\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
