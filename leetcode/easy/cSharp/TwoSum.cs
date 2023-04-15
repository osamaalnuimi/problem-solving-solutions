public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            int pointer = 0;
            for (int i = pointer + 1; i < nums.Length; i++)
            {
                if (nums[pointer] + nums[i] == target)
                {
                    return new int[] { pointer, i };

                }
                if (i == nums.Length - 1)
                {
                    pointer++;
                    i = pointer;
                }
            }
            return new int[] { pointer, 0 };
        }
}