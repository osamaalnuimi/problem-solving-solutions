public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var hash = nums.ToHashSet();
        IList<int> nums2 = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hash.Contains(i + 1) == false)
            {
                nums2.Add(i + 1);
            }
            if (nums2.Count + hash.Count == nums.Length)
            {
                break;
            }
        }
        return nums2;
    }
}
