public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int firstPointer = m > 0 ? m - 1 : 0;
        int secondPointer = nums2.Length - 1;

        if (m == 0) Array.Copy(nums2, nums1, nums1.Length);

        if (m > 0 && n > 0)
        {


            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if (firstPointer < 0)
                {
                    nums1[i] = nums2[secondPointer];
                    secondPointer--;
                }
                else if (secondPointer >= 0 && nums1[firstPointer] <= nums2[secondPointer])
                {
                    nums1[i] = nums2[secondPointer];
                    secondPointer--;
                }
                else
                {
                    nums1[i] = nums1[firstPointer];
                    firstPointer--;
                }

            }
        }
    }
}
