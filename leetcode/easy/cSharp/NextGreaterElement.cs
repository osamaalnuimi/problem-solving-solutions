public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        
        Stack<int> stack = new Stack<int>();
        Dictionary<int,int> map = new Dictionary<int,int>();

        for (int i = nums2.Length-1;i>=0 ; i--)
        {
            
            while (stack.Count >0 && nums2[i] > stack.Peek())
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                map[nums2[i]] = -1;
                stack.Push(nums2[i]);
                continue;
            }

            map[nums2[i]] = stack.Peek();
            stack.Push(nums2[i]);
        }
        int[] results = new int[nums1.Length];

        for (int i = 0; i < nums1.Length; i++)
        {
            if (map.ContainsKey(nums1[i]))
            {
                results[i] = map[nums1[i]];
            }
        }
        return results;
    }
}
