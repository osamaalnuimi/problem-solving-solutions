public class Solution {
    public bool IsPalindrome(string s) {
        char[] arr = s.ToCharArray();

arr = Array.FindAll<char>(s.ToCharArray(), (c => (char.IsLetterOrDigit(c))));
		string str = new string(arr).ToLower();
 Array.Reverse(arr);
		return
		str == new string(arr).ToLower();
		
}
}
