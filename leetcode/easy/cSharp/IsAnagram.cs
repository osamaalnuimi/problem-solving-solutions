public class Solution {
    public bool IsAnagram(string s, string t) {
        var sLookUp = s.ToLookup(s => s);
        var tLookUp = t.ToLookup(t=>t);

        return sLookUp.Count == tLookUp.Count && sLookUp.All(g => g.Count() == tLookUp[g.Key].Count());
    }
}
