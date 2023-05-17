using System.Numerics;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        if ((digits[digits.Length - 1] + 1) <= 9)
        {
            digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
            return digits;
        }
        else
        {
            // Convert array of digits to string
            string numberString = string.Concat(digits);

            // Parse the string to BigInteger
            BigInteger number = BigInteger.Parse(numberString);

            // Perform the calculation
            BigInteger result = number + 1;

            // Convert result back to string
            string resultString = result.ToString();

            // Convert string to array of digits
            return resultString.Select(c => int.Parse(c.ToString())).ToArray();
        }
    }
}
