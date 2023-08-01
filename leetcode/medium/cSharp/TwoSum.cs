public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int right = numbers.Length - 1;
        int left = 0;

        while (left < right)
        {
            if (numbers[left] + numbers[right] == target)
            {
                return new int[] { left + 1, right + 1 };
            }

            if (numbers[left] + numbers[right] > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return new int[] { 0, 0 };
    }
}
