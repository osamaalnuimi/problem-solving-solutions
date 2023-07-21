public class Solution {
    public void ReverseString(char[] s) {
        int i = 0, l = s.Length - 1;
        char temp;
        while (i < l)
        {
            temp = s[i];
            s[i] = s[l];
            s[l] = temp;
            i++;
            l--;
        }
    }
}
