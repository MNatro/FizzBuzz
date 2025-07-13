using Xunit;
using StringSum;

namespace StringSumTests
{
    public class SumCalculatorTests
    {
        [Theory]
        [InlineData("1", "2", "3")]
        [InlineData("0", "0", "0")]
        [InlineData("", "5", "5")]
        [InlineData("abc", "5", "5")]
        public void Sum_ReturnsExpectedResult(string a, string b, string expected)
        {
            var calculator = new SumCalculator();
            var result = calculator.Sum(a, b);
            Assert.Equal(expected, result);
        }
    }
}
