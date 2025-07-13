namespace LeapYear
{
    public class YearChecker
    {
        public bool IsLeap(int year)
        {
            return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
        }
    }
}
