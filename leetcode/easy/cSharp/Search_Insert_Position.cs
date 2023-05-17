public class Solution {
    public int SearchInsert(int[] nums, int target) {
       int end = nums.Length - 1;
         if (nums[0] > target)
        {
            return 0;
        }
            while (end >= 0)
            {    
                 if (nums[end] == target)
                {
                    return end;
                }
                if (nums[end] < target)
                {
                    return end + 1;
                }
              
                    end--;
              
            }
            return -1;
    }
}

// or built in binary search
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var sortedList = new SortedList<int, int>(nums.ToDictionary(s => s));

        if (sortedList.IndexOfKey(target) == -1) {
            sortedList.Add(target, target);
        }
        return sortedList.IndexOfKey(target);
    }
}
