public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val)
            {
                nums[count] = nums[i];
                count++;
            }
        }
        return count;
    }
}

// another solution 

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0;

        for (int i = nums.Length-1; i >=0; i--) {
            if (nums[i] == val)
            {
                var temp = nums[nums.Length-1 - count];
                nums[nums.Length - 1 - count] = nums[i];
                nums[i] = temp;
                count++;
            }
        }
        return (nums.Length - count);
    }
}
