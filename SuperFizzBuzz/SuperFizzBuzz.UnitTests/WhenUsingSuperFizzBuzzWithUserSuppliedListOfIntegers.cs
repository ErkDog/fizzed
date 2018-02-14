using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace SuperFizzBuzz.UnitTests
{
    [TestFixture]
    public class WhenUsingSuperFizzBuzzWithUserSuppliedListOfIntegers
    {
        [Test]
        public void ShouldReturn2_Fizz_4_Buzz_FizzBuzz_FizzBuzz_2_Fizz()
        {
            var superFizzBuzz = new SuperFizzBuzz();
            var userSuppliedListOfIntegers = new List<int> { 2,3,4,15,30,2,9};
            var tokens = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz")
            };
            var expected = new List<string> { "2", "Fizz", "4", "FizzBuzz", "FizzBuzz", "2", "Fizz" };
            var actual = superFizzBuzz.GetSuperFizzBuzz(userSuppliedListOfIntegers, tokens);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ShouldReturnThePropperSequenceEvenWithMixedPossitiveAndNegativeNumbersAndDups()
        {
            var superFizzBuzz = new SuperFizzBuzz();
            var userSuppliedListOfIntegers = new List<int> { -2, 3, 4, -15, 30, 2, -9, -9, 4 };
            var tokens = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz")
            };
            var expected = new List<string> { "-2", "Fizz", "4", "FizzBuzz", "FizzBuzz", "2", "Fizz", "Fizz", "4" };
            var actual = superFizzBuzz.GetSuperFizzBuzz(userSuppliedListOfIntegers, tokens);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("UnitTest")]
        public void ShouldThrowExceptionWithNullList()
        {
            var superFizzBuzz = new SuperFizzBuzz();
            Assert.Throws<ArgumentOutOfRangeException>(() => superFizzBuzz.GetSuperFizzBuzz(null, null));
        }
        [Test]
        [Category("UnitTest")]
        public void ShouldThrowExceptionWithEmptyList()
        {
            var superFizzBuzz = new SuperFizzBuzz();
            Assert.Throws<ArgumentOutOfRangeException>(() => superFizzBuzz.GetSuperFizzBuzz(new List<int>(), null));
        }

    }
}
