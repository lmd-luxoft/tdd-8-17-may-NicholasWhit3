namespace TDDKataCalc
{
    public class Calc
    {
        public int Add(string digits)
        {
            if (string.IsNullOrEmpty(digits)) { return 0; }
            
            if(digits.Contains("\n")) { digits = digits.Replace("\n", ","); }

            char[] dividers = { ',' };
            string[] splitNumbers = digits.Split(dividers);

            if (splitNumbers.Length == 1)
            {
                return int.Parse(splitNumbers[0]);
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