public class Solution {
    public int RomanToInt(string s) {
            char[] ss = s.ToCharArray();

            Dictionary<char, int> result = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000,
            };
            int temp = result[ss[0]],value =0;

            foreach (var item in ss)
            {
                if (temp < result[item])
                {
                    value += (result[item] - temp * 2);

                }
                else
                {
                    value += result[item];
                }
                temp = result[item];
            }

         
            
            return value;
    }
}