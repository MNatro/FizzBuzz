using Xunit;
using LeapYear;

namespace LeapYearTests
{
    public class YearCheckerTests
    {
        [Theory]
        [InlineData(1996, true)]
        [InlineData(2001, false)]
        [InlineData(1900, false)]
        [InlineData(2000, true)]
        public void IsLeap_ReturnsExpectedResult(int year, bool expected)
        {
            var checker = new YearChecker();
            var result = checker.IsLeap(year);
            Assert.Equal(expected, result);
        }
    }
}
