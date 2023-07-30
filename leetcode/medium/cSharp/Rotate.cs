public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        Array.Reverse(nums);
        int right = k - 1;
        int left = 0;
        while (left < right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            right--;
            left++;
        }
        right = nums.Length - 1;
        left = k;
        while (left < right)
        {

            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            right--;
            left++;
        }

    }
}
