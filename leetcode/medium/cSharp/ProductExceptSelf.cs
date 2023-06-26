public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
     int postfix = 1, prefix = 1;
    int[] result = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = prefix;
        prefix *= nums[i];
    }
    for (int i = nums.Length-1;i>= 0 ; i--) {
        result[i] *= postfix;
        postfix *= nums[i];
    }
    return result;
    }
}
