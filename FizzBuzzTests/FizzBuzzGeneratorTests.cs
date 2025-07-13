using Xunit;
using FizzBuzz;

namespace FizzBuzzTests
{
    public class FizzBuzzGeneratorTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void GetValue_ReturnsExpectedResult(int input, string expected)
        {
            var fizzBuzz = new FizzBuzzGenerator();
            var result = fizzBuzz.GetValue(input);
            Assert.Equal(expected, result);
        }
    }
}
