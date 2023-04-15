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

          public int[] TwoSum_Optimization(int[] nums, int target)
        {
            int[] arr = new int[] { 3,3 };
            int targetValue = 6;
            // Create an empty dictionary
            Dictionary<int, int> dict = new Dictionary<int, int>();

            // Iterate through the array and add each element to the dictionary
            for (int i = 0; i < arr.Length; i++)
            {
                int diff = targetValue -arr[i];
                if (dict.ContainsKey(diff))
                {
                    return new int[] { dict[diff], i };

                }
                dict[arr[i]] = i;

            }
            return new int[] { 0, 0 };
        }
}
