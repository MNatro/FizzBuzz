namespace StringSum
{
    public class SumCalculator
    {
        public string Sum(string num1, string num2)
        {
            if (string.IsNullOrEmpty(num1) && string.IsNullOrEmpty(num2))
                return "0";
            
            int n1 = int.Parse(num1);
            int n2 = int.Parse(num2);
            return (n1 + n2).ToString();
        }
    }
}
