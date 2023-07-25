public class Solution
{
    public int LeastBricks(IList<IList<int>> wall)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>
{
    {0,0 }
};
        for (int i = 0; i < wall.Count; i++)
        {
            var index = 0;
            for (int j = 0; j < wall[i].Count - 1; j++)
            {
                index += wall[i][j];


                if (keyValuePairs.ContainsKey(index))
                {

                    keyValuePairs[index] += 1;
                }
                else
                {
                    keyValuePairs[index] = 1;
                }


            }
        }
        return (wall.Count - keyValuePairs.Values.Max());
    }
}
