public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        IDictionary<char, char> keyValuePairs = new Dictionary<char, char>();
        IDictionary<char, char> keyValuePairs2 = new Dictionary<char, char>();
        int index = 0;
        foreach (char key in t)
        {
            if (keyValuePairs.ContainsKey(s[index]) == false)
            {
                keyValuePairs.Add(s[index], key);

            }
            else
            {
                if (keyValuePairs[s[index]] != key) return (false);
            }
            if (keyValuePairs2.ContainsKey(key) == false)
            {
                keyValuePairs2.Add(key, s[index]);
            }
            else
            {
                if (keyValuePairs2[key] != s[index])
                {
                    return (false);
                }
            }
            index++;
        }
        return true;
    }
}
