public class Solution {
    public int FindNumbers(int[] nums) {
         int evenNumber = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (((int)Math.Floor(Math.Log10(nums[i])) + 1) % 2 == 0)  evenNumber++; 
            }
            return evenNumber;
    }
}