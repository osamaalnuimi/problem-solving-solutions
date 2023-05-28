public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int i = 0, j = 0;
        if (s.Length > t.Length) return false;

        while (i < s.Length)
        {
            if (j >= t.Length)
            {
                return (false);

            }
            while (j < t.Length)
            {
                if (s[i] == t[j])
                {
                    j++;
                    break;
                }
                if (j == t.Length - 1)
                {
                    return (false);
                    break;
                }
                j++;
            }
            i++;
        }
        return true;
    }
}
