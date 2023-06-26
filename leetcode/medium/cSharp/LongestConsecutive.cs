int LongestConsecutive(int[] nums)
{
    if (nums.Length < 2) return nums.Length;
    var numSet = nums.ToHashSet();
    var longest = 1;

    foreach (var item in numSet)
    {
        if (numSet.Contains(item - 1)) continue;
        
        var count = 0;
        while (numSet.Contains(item+count))
        {
            count++;
            longest = Math.Max(longest, count);
        }
    }
    return longest;
}
