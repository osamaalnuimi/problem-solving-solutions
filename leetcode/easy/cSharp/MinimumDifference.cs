public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        Array.Sort(nums);

        int min = nums[nums.Length-1];
        int r =0;
        if (nums.Length == 1 || k == 1)
        {
            return 0;
        }
        for (int i = k-1; i < nums.Length; i++)
        {
        
            min = Math.Min(min, nums[i] - nums[r]);
            r++;
        }
        return min;
    }
}
