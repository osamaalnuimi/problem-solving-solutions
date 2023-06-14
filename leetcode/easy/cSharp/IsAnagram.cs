public class Solution {
    public bool IsAnagram(string s, string t) {
        var sLookUp = s.ToLookup(s => s);
        var tLookUp = t.ToLookup(t=>t);

        return sLookUp.Count == tLookUp.Count && sLookUp.All(g => g.Count() == tLookUp[g.Key].Count());
    }
    
    public bool IsAnagram_Optimization(string s, string t)
    {
        if (s == t) return true;
        if (t.Length != s.Length) return false;

        Dictionary<char,int> sDic = new Dictionary<char,int>();
        Dictionary<char,int> tDic = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++)
        {
            sDic[s[i]] = 1 + (sDic.ContainsKey(s[i]) ? sDic[s[i]]: 0 );
            tDic[t[i]] = 1 + (tDic.ContainsKey(t[i]) ? tDic[t[i]]: 0 );
        }
        foreach (char item in sDic.Keys)
        {

            if (!tDic.ContainsKey(item) ||  sDic[item] != tDic[item])
            {
                return false;
            }
        }
        return true;
    }
    
}
