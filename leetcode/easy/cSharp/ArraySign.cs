public class Solution
{


    public int ArraySign(int[] nums)
    {
        if (nums.Any(x => x == 0)) return 0;

        int negative = nums.Count(x => x < 0);

        return negative % 2 == 0 ? 1 : -1;
    }
    public int ArraySign_2(int[] nums)
    {
        int product = 1;

        foreach (int value in nums)
        {
            if (value == 0) return 0;
            product = product * value > 0 ? 1 : product * value < 0 ? -1 : 0;
        }
        return product;
    }
}