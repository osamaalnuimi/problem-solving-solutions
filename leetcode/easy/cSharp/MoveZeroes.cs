public class Solution {
    public void MoveZeroes(int[] nums) {
        int left = 0;
        int right = 0;

        while (right < nums.Length)
        {
           
            if (nums[right] != 0)
            {
                int temp = nums[left]; nums[left] = nums[right]; nums[right] = temp;
            }
            if (nums[left] != 0) left++;
            right++;
        }
    }
}
