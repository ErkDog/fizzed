using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace SuperFizzBuzz.UnitTests
{
    [TestFixture]
    public class WhenUsingSuperFizzBuzzWithTokensOtherThanFizzAndBuzz
    {
        /// <summary>
        /// Can generate tokens other than “Fizz” and “Buzz” and can evaluate division by numbers other than 3 and 5. Maybe a user wants to test division by 4, 13, and 9, and output “Frog”, “Duck,” and “Chicken” for them (e.g., in this case, 52 would ouput “FrogDuck”, 36 would output “FrogChicken”, 468 would output “FrogDuckChicken”, etc.)
        /// </summary>
        [Test]
        public void ShouldReturn11_FrogDuck_10001_FrogChicken_1234567_FrogDuckChicken__DuckChicken()
        {
            var superFizzBuzz = new SuperFizzBuzz();
            var userSuppliedListOfIntegers = new List<int> { -11, 52, -10001, 36, 1234567, 468, 117};
            var tokens = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(4, "Frog"),
                new Tuple<int, string>(13, "Duck"),
                new Tuple<int, string>(9, "Chicken")
            };

            var expected = new List<string> { "-11", "FrogDuck", "-10001", "FrogChicken", "1234567", "FrogDuckChicken", "DuckChicken" };
            var actual = superFizzBuzz.GetSuperFizzBuzz(userSuppliedListOfIntegers, tokens);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
