public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var  list = new List<IList<int>>();
        for (int i = 0;i< nums.Length - 1; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int left = i + 1;
            int right = nums.Length - 1;
            while (left< right)
            {
                int sum = nums[i] + nums[right] + nums[left];
                if (sum > 0)
                {
                    right--;
                }else if (sum < 0)
                {
                    left++;
                }else
                {
                    list.Add( new List<int>{ nums[i], nums[left] , nums[right]});
                    left++;
                    while (nums[left] == nums[left - 1] && left < right)
                    {
                        left += 1;
                    }
                }
            }
        }
    return  list;
    }
}
