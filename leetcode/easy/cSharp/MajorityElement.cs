public class Solution {
    public int MajorityElement(int[] nums) {
        if(nums.Length == 1) return nums[0];
        return nums.GroupBy(n => n)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;
    }
}
