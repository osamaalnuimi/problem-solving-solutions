public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> rows = new List<IList<int>>();
rows.Add(new List<int>() { 1});
if (numRows > 1)
{
    rows.Add(new List<int>() { 1,1});
}
for (int i = 1; i < numRows-1; i++)
{
    
    int[] row = new int[i+2];
    row[0] = 1;
    row[row.Length-1] = 1;
    for (int j = 0; j <= i -1; j++)
    {
        row[j+1] = rows[i][j] + rows[i][j+1];
    }
    rows.Add(row);
}
return rows;
    }
}
