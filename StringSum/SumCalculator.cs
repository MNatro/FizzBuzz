namespace StringSum
{
    public class SumCalculator
    {
        public string Sum(string num1, string num2)
        {
            int n1 = int.TryParse(num1, out var a) && a >= 0 ? a : 0;
            int n2 = int.TryParse(num2, out var b) && b >= 0 ? b : 0;
            return (n1 + n2).ToString();
        }
    }
}
