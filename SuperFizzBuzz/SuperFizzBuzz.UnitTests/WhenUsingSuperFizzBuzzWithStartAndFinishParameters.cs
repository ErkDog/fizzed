using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SuperFizzBuzz.UnitTests
{
    /// <summary>
    /// Can produce fizzbuzz output for a user-supplied range of numbers – e.g., from 2 to 35, or from 1 to 1,000,000,000, or from -1 to -35, etc.
    /// </summary>
    [TestFixture]
    public class WhenUsingSuperFizzBuzzWithStartAndFinishParameters
    {
        [Test]
        [Category("UnitTest")]
        public void ShouldReturn1_2_Fizz_4_Buzz()
        {
            // Note: Requirements 2 and 3 should not require command line parsing to complete. 
            var tokens = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz")
            };

            var superFizzBuzz = new SuperFizzBuzz();
            var expected = new List<string> {"1", "2", "Fizz", "4", "Buzz"};
            var actual = superFizzBuzz.GetSuperFizzBuzz(1,5, tokens);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [Category("UnitTest")]
        public void ShouldReturn1_2_Fizz_4_Buzz_Fizz_7_8_Fizz_Buzz_11_Fizz_13_14_FizzBuzz()
        {
            // Note: Requirements 2 and 3 should not require command line parsing to complete. 
            var tokens = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz")
            };

            var superFizzBuzz = new SuperFizzBuzz();
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz" };
            var actual = superFizzBuzz.GetSuperFizzBuzz(1, 15, tokens);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [Category("UnitTest")]
        public void ShouldReturn1MillionIterationsWithLastValueOf_Buzz()
        {
            // Note: Requirements 2 and 3 should not require command line parsing to complete. 
            var tokens = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz")
            };

            var superFizzBuzz = new SuperFizzBuzz();
            var actual = superFizzBuzz.GetSuperFizzBuzz(1, 1000000, tokens);
            Assert.That(actual.Last(), Is.EqualTo("Buzz"));
        }

        [Test]
        [Category("UnitTest")]
        public void ShouldReturnNegativeNumbersOf_FizzBuzz_14_13_Fizz_11_Buzz_Fizz_8_7_Fizz_Buzz_4_Fizz_2_1()
        {
            // Note: Requirements 2 and 3 should not require command line parsing to complete. 
            var tokens = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz")
            };

            var superFizzBuzz = new SuperFizzBuzz();
            var expected = new List<string> { "FizzBuzz", "-14", "-13", "Fizz", "-11", "Buzz","Fizz", "-8", "-7", "Fizz", "Buzz", "-4", "Fizz", "-2", "-1" };
            var actual = superFizzBuzz.GetSuperFizzBuzz(-15, -1, tokens);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [Category("UnitTest")]
        public void ShouldThrowExceptionWithStartIndexGreaterThanFinishIndex()
        {
            // Note: Requirements 2 and 3 should not require command line parsing to complete. 
            var tokens = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz")
            };

            var superFizzBuzz = new SuperFizzBuzz();
            Assert.Throws<ArgumentOutOfRangeException>(()=> superFizzBuzz.GetSuperFizzBuzz(-5, -10, tokens));
        }
    }
}
