public class Solution {
    public string LongestCommonPrefix(string[] strs) {

string shortestString = strs.First(s => s.Length == strs.Min(s => s.Length));


    for (int i = 0; i < shortestString.Length; i++)
    {
    
        for (int j = 0; j < strs.Length; j++)
        {
                if (strs[j][i] != shortestString[i])
                {
                    return shortestString.Substring(0, i);
                }
            }
        }

    return shortestString;
    }
}