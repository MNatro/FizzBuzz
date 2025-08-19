namespace StringSum
{
    public class SumCalculator
    {
        public string Sum(string num1, string num2)
        {
            int n1 = GetNumericValue(num1);
            int n2 = GetNumericValue(num2);
            return (n1 + n2).ToString();
        }

        private int GetNumericValue(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;
                
            if (int.TryParse(input, out int value) && value >= 0)
                return value;
                
            return 0;
        }
    }
}
