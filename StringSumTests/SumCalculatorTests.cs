using Xunit;
using StringSum;

namespace StringSumTests
{
    public class SumCalculatorTests
    {
        [Fact]
        public void Sum_WithEmptyStrings_ReturnsZero()
        {
            // Arrange
            var calculator = new SumCalculator();
            
            // Act
            var result = calculator.Sum("", "");
            
            // Assert
            Assert.Equal("0", result);
        }
    }
}
