using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperFizzBuzz
{
    public class SuperFizzBuzz
    {
        /// <summary>
        /// Can produce fizzbuzz output for a user-supplied range of numbers – e.g., from 2 to 35, or from 1 to 1,000,000,000, or from -1 to -35, etc.
        /// </summary>
        public List<string> GetSuperFizzBuzz(int startIndex, int finishIndex, List<Tuple<int,string>> tokens)
        {
            if (startIndex > finishIndex || tokens == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            var generatedListOfIntegers = Enumerable.Range(startIndex, (finishIndex - startIndex) +1).ToList();
            var fizzBuzzTokens = GetSuperFizzBuzz(generatedListOfIntegers, tokens);

            return fizzBuzzTokens;
        }

        /// <summary>
        /// Can produce output for a user supplied set of integers, even if they’re not sequential.
        /// </summary>
        public List<string> GetSuperFizzBuzz(List<int> userSuppliedListOfIntegers, List<Tuple<int,string>> tokens)
        {
            if (userSuppliedListOfIntegers == null || userSuppliedListOfIntegers.Count == 0 || tokens == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            var fizzBuzzTokens = new List<string>();
            foreach (var integer in userSuppliedListOfIntegers)
            {
                fizzBuzzTokens.Add(GetTokenResult(integer, tokens));
            }

            return fizzBuzzTokens;
        }

        private static string GetTokenResult(int integer, IEnumerable<Tuple<int, string>> tokens)
        {
            var fizzBuzzToken = "";

            foreach (var token in tokens)
            {
                if (integer % token.Item1 == 0)
                {
                    fizzBuzzToken += token.Item2;
                }
            }

            if (fizzBuzzToken == "")
            {
                fizzBuzzToken = integer.ToString();
            }

            return fizzBuzzToken;
        }
    }
}
