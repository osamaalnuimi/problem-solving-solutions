public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
    var groups = new Dictionary<string, IList<string>>();

    foreach (string str in strs)
    {
        char[] hash = new char[26];
        foreach (char c in str)
        {
            hash[c - 'a']++;
        }
        
        string s = new string(hash);
        if (!groups.ContainsKey(s))
        {
            groups[s] = new List<string>();

        }
        groups[s].Add(str);
    }

    return groups.Values.ToList();

    }
}
