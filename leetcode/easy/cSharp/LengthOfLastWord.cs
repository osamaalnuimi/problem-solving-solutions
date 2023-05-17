public class Solution {
    public int LengthOfLastWord(string s) {
        string[] sarray = s.Trim().Split();
        return sarray[sarray.Length-1].Length;
    }
}
