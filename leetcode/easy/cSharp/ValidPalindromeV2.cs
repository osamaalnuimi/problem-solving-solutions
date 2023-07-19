public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length-1;
        while (left < right)
        {
            
            if (s[right] != s[left])
            {
                return (isPalindrome(s, left+1, right)|| isPalindrome(s, left, right-1));
            }

            right--;
            left++;
        }
        return true;

    }
    public bool isPalindrome(string s, int left,int right) {

        while (left < right)
        {
            if (s[left] != s[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}
