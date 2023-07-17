public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        var textDic = text.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var ballonDic = new Dictionary<char, int>()
{
    {'b', 1 },
    {'a', 1},
    {'l',2 },
    {'o',2 },
    {'n',1 }
};
        int count = text.Length;

        foreach (var item in ballonDic)
        {
            if (textDic.ContainsKey(item.Key))
            {
                count = count > (textDic[item.Key] / item.Value) ? (textDic[item.Key] / item.Value) : count;
            }
            else
            {

                return 0;
            }
        }
        return count;
    }
}
