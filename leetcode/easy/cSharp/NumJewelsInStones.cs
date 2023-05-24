public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
      int count =0;
      var j = jewels.ToArray().ToHashSet();
      foreach(var item in stones){
          if(j.Contains(item)){
            count++;
        }
      }
      return count;
    }
}
