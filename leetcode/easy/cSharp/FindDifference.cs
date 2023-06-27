public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        List<List<int>> result = new()
    {
        new List<int>(),
        new List<int>()
    };

        var nums1Hash = nums1.ToHashSet();
        var nums2Hash = nums2.ToHashSet();

        foreach (var item in nums1Hash)
        {
            if (!nums2Hash.Contains(item))
            {
                result[0].Add(item);
            }
        }
        foreach (var item in nums2Hash)
        {
            if (!nums1Hash.Contains(item))
            {
                result[1].Add(item);
            }
        }

        return result.ToArray();
    }
}