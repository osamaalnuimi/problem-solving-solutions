public class Solution
{
    public bool WordPattern(string pattern, string s)
    {

        string[] sArray = s.Split(' ');
        if (sArray.Length != pattern.Length)
        {
            return (false);
        }
        var map = new Dictionary<char, string>();
        int index = 0;
        foreach (var item in pattern)
        {
            if (map.ContainsKey(item) == false)
            {
                if (map.ContainsValue(sArray[index]) == true)
                {
                    return (false);
                }
                if (map.ContainsValue(sArray[index]) == false) { map[item] = sArray[index]; }

            }
            if (map[item] != sArray[index])
            {
                return (false);

            }
            index++;
        }
        return (true);
    }
}
