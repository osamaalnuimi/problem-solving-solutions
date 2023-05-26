public class Solution {
    public int NumUniqueEmails(string[] emails) {
return emails.Select(email => email.Split('@')).Select(e => e[0].Split('+')[0].Replace(".", "") + '@' + e[1]).Distinct().Count();
    }
}

// or 
public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<string> test = new HashSet<string>();
for (int i = 0; i < emails.Length; i++)
{
    string[] email = emails[i].Split('@');
    test.Add(email[0].Replace(".", "").Split("+")[0] +'@'+ email[1]);
}
return test.Count;
    }
}
