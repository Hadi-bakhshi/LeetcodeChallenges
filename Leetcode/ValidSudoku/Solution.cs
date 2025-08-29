namespace Leetcode.ValidSudoku;

public class Solution
{
    /*
     * Each row must contain the digits 1-9 without repetition.
     * Each column must contain the digits 1-9 without repetition.
     * Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
     * Note:
     * A Sudoku board (partially filled) could be valid but is not necessarily solvable.
     * Only the filled cells need to be validated according to the mentioned rules.
     */
    public bool IsValidSudoku(char[][] board)
    {

        // check rows
        for (int i = 0; i < 9; i++)
        {
            var row = board[i];
            var seen = new HashSet<char>();
            var duplicated = new List<char>();
            for (int j = 0; j < 9; j++)
            {
                var cell = row[j];
                if (cell != '.' && !seen.Add(cell))
                {
                    duplicated.Add(cell);
                }
            }
            if (duplicated.Count > 0)
            {
                return false;
            }
        }

        // check columns
        for (int i = 0; i < 9; i++)
        {
            var seen = new HashSet<char>();
            var duplicated = new List<char>();
            for (int j = 0; j < 9; j++)
            {
                var cell = board[j][i];
                if (cell != '.' && !seen.Add(cell))
                {
                    duplicated.Add(cell);
                }
            }
            if (duplicated.Count > 0)
            {
                return false;
            }
        }
        // check 3x3 sub-boxes
        for (int boxRow = 0; boxRow < 3; boxRow++)
        {
            for (int boxCol = 0; boxCol < 3; boxCol++)
            {
                var seen = new HashSet<char>();
                var duplicated = new List<char>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var cell = board[boxRow * 3 + i][boxCol * 3 + j];
                        if (cell != '.' && !seen.Add(cell))
                        {
                            duplicated.Add(cell);
                        }
                    }
                }
                if (duplicated.Count > 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
}
