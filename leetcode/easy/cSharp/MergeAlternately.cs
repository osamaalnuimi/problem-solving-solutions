public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var maxLength = Math.Max(word1.Length, word2.Length);
        StringBuilder sb = new StringBuilder("", word1.Length + word2.Length);
        for (int i = 0; i < maxLength; i++)
        {
            if ( word1.Length > i)
            {
                sb.Append(word1[i]);
            }
            if (word2.Length > i)
            {
                sb.Append(word2[i]);
            }
        }

        return sb.ToString();
    }
}
