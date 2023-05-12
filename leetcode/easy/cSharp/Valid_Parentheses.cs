public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0) return false;
       Stack<char> stack = new Stack<char>();
char[] buffer = s.ToCharArray();

for (int i = 0; i< buffer.Length; i++)
{
    if (buffer[i] =='(' || buffer[i] == '{'||buffer[i] == '[')
    {
        stack.Push(buffer[i]);
    }else 
    {
        if(stack.Count == 0) return false;
        char parenthes = stack.Pop();
        if (parenthes != '(' && buffer[i] == ')')
        {
            return false;
        }
        if (parenthes != '{' && buffer[i] == '}')
        {
            return false;
        }
        if (parenthes != '[' && buffer[i] == ']')
        {
            return false;
        }
    }
}


if (stack.Count > 0) return false;
return true;
    }
}
