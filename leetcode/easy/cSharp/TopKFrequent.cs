public class Solution {
    /* the overall time complexity of the code is O(N + k log k) */
     public int[] TopKFrequent(int[] nums, int k)
  {
    var items=    nums.ToLookup(n => n).OrderByDescending(n => n.Count()).Take(k).Select(s=>s.Key).ToArray();
    return items;
  }
    
    /* O(n) */
    public int[] TopKFrequent_optimization(int[] nums, int k) {
    if (nums.Length == k)
    {
        return nums;
    }
    var items = nums.ToLookup(n => n);
    int[][] groups = new int[nums.Length+1][];
    IList<int> result = new List<int>();
    foreach (var item in items)
    {
        if (groups[item.Count()] != null)
        {
            groups[item.Count()] = groups[item.Count()].Append(item.Key).ToArray();
        }
        else
        {
            groups[item.Count()] = new int[]{item.Key};
        }
    }
    for (int i = groups.Length-1;i>=0; i--)
    {
       
        if (groups[i] != null  &&groups[i].Length >= 1)
        {
            foreach (var item in groups[i])
            {
                k--;
                result.Add( item );
                if (k == 0)
                {
                    return result.ToArray();
                }
            }
        } 
    }
    return result.ToArray();
    }
}
