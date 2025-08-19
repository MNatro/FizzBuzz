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
    }
}
