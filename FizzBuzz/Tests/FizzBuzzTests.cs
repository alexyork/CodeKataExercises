using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzzGame game;

        [SetUp]
        public void SetUp()
        {
            game = new FizzBuzzGame();
        }

        [Test]
        public void Should_print_Fizz_when_number_is_divisible_by_3()
        {
            var result = game.GetResult(3);

            result.ShouldBe("Fizz");
        }

        [Test]
        public void Should_print_Buzz_when_number_is_divisible_by_5()
        {
            var result = game.GetResult(5);

            result.ShouldBe("Buzz");
        }

        [Test]
        public void Should_print_FizzBuzz_when_number_is_divisible_by_3_and_5()
        {
            var result = game.GetResult(15);

            result.ShouldBe("FizzBuzz");
        }

        [Test]
        public void Should_print_the_number_when_it_is_not_divisible_by_3_or_5()
        {
            var result = game.GetResult(1);

            result.ShouldBe("1");
        }
    }

    public static class TestExtensions
    {
        public static void ShouldBe(this object actual, object expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}