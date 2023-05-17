public class Solution
{
    public int MySqrt(int x)
    {
        double guess = 2;
        while (true)
        {
            guess = (guess + x / guess) / 2;
            if ((int)guess == (int)(guess + x / guess) / 2) break;
        }
        return (int)guess;
    }
}
