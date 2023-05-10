namespace TDDKataCalc
{
    public class Calc
    {
        public int Add(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return 0;
            }

            char[] dividers = { ',' };
            string[] splitNumbers = digits.Split(dividers);

            if (splitNumbers.Length == 1)
            {
                return int.Parse(splitNumbers[0]);
            }

            if (splitNumbers.Length == 2)
            {
                return int.Parse(splitNumbers[0]) + int.Parse(splitNumbers[1]);
            }

            // Handle more than two numbers
            int sum = 0;
            foreach (string numStr in splitNumbers)
            {
                sum += int.Parse(numStr);
            }

            return sum;
        }
    }
}