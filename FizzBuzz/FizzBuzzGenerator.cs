namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public string GetValue(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
                
            return number.ToString();
        }
    }
}
