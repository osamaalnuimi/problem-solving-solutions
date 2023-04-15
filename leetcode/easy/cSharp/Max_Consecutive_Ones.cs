public class Solution {
     public int FindMaxConsecutiveOnes(int[] nums) {
          int count = 0; //intitialize count
        int result = 0; //initialize max
     
        for (int i = 0; i < nums.Length; i++)
        {
             
            // Reset count when 0 is found
            if (nums[i] == 1)
                count++;
     
            // If 1 is found, increment count
            // and update result if count
            // becomes more.
            else
            {
                if(result < count) result =count;
                
                if(result >= nums.Length / 2) return result;
                              
                count =0;
            }
             
        }
     
        return Math.Max(result,count);
    }
}