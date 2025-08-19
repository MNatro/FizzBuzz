using Xunit;
using FizzBuzz;

namespace FizzBuzzTests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void GetValue_WithNumber1_Returns1()
        {
            // Arrange
            var fizzBuzz = new FizzBuzzGenerator();
            
            // Act
            var result = fizzBuzz.GetValue(1);
            
            // Assert
            Assert.Equal("1", result);
        }
    }
}
