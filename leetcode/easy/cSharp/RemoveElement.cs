public class Solution {
    public int RemoveElement(int[] nums, int val) {
         int n = nums.Length;
            int pointer = 0;
            while( pointer < n)
            {
                if (nums[pointer] == val)
                {
                    
                    
                    nums[pointer] = nums[n -1];
                    n--;
                }
                else
                {
                    pointer++;
                }


            }

            //Console.WriteLine("[{0}]", string.Join(", ", nums));
            
            return n;
    }
}