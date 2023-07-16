public class Solution {
    public int PivotIndex(int[] nums) {
       int totalSum = nums.Sum();
        int leftSum = 0;
      for (int i = 0; i < nums.Length; i++)
      {
  
      if (  totalSum - nums[i] - leftSum ==leftSum)
      {
          return i;
      }
      leftSum += nums[i];
      }
      return -1;
    }
}
