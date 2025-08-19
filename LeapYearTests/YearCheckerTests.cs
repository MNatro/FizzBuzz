using Xunit;
using LeapYear;

namespace LeapYearTests
{
    public class YearCheckerTests
    {
        [Fact]
        public void IsLeap_WithRegularYear_ReturnsFalse()
        {
            // Arrange
            var checker = new YearChecker();
            
            // Act
            var result = checker.IsLeap(2001);
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsLeap_WithYearDivisibleBy4_ReturnsTrue()
        {
            // Arrange
            var checker = new YearChecker();
            
            // Act
            var result = checker.IsLeap(1996);
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsLeap_WithCenturyYear_ReturnsFalse()
        {
            // Arrange
            var checker = new YearChecker();
            
            // Act
            var result = checker.IsLeap(1900);
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsLeap_WithYearDivisibleBy400_ReturnsTrue()
        {
            // Arrange
            var checker = new YearChecker();
            
            // Act
            var result = checker.IsLeap(2000);
            
            // Assert
            Assert.True(result);
        }
    }
}
