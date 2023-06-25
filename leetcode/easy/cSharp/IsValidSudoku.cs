public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var seen = new HashSet<string>();

        for (int i = 0; i < 9; ++i)
        {
            for (int j = 0; j < 9; ++j)
            {
                if (board[i][j] == '.') continue;

                if (seen.Contains($"{board[i][j]} in row {i}")||
                    seen.Contains($"{board[i][j]} in col {j}") ||
                    seen.Contains($"{board[i][j]} in block {i/3} - {j/3}")
                    )
                {
                    return false;
                }
                seen.Add($"{board[i][j]} in row {i}");
                seen.Add($"{board[i][j]} in col {j}");
                seen.Add($"{board[i][j]} in block {i/3} - {j/3}");
            }
        }
        return true;
    }
}

public class Solution {
    public bool IsValidSudoku(char[][] board) {
         var rows = new Dictionary<int, HashSet<char>>();
    var columns = new Dictionary<int, HashSet<char>>();
    var squares = new Dictionary<(int, int),HashSet<char>>();

    for (int r = 0; r < board.Length; r++)
    {
        rows[r] = new HashSet<char>();
        for (int c = 0; c < board[r].Length; c++)
        {
            if (!columns.ContainsKey(c)) columns[c] = new HashSet<char>();
            if (!squares.ContainsKey((r/3,c/3)))
            {
                squares[(r / 3, c / 3)] = new HashSet<char>();
            }
            if (board[r][c] == '.') continue;

            if (rows[r].Contains(board[r][c]) ||
                 columns[c].Contains(board[r][c]) ||
                 squares[(r / 3, c / 3)].Contains(board[r][c]))
                return false;

            rows[r].Add(board[r][c]);
            columns[c].Add(board[r][c]);
            squares[(r / 3, c / 3)].Add(board[r][c]);
        }
    }
    return true;
    }
}
