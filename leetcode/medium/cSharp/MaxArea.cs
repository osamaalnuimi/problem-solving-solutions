public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int max = 0;
        while (left < right)
        {
            var temp = (right - left) * Math.Min(height[right], height[left]);
            if (temp > max) max = temp;
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return max;
    }
}
