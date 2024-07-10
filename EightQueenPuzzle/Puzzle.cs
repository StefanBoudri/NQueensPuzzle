namespace NQueenPuzzle;

public class Puzzle
{
    public Puzzle(int n)
    {
        int[,] chessBoard = new int[n, n];
        SolutionFinder(n, chessBoard, 0);
    }

    private static bool SolutionFinder(int n, int[,] chessBoard, int row)
    {
        if (row == n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(chessBoard[i, j] + " ");
                }
                Console.WriteLine();
            }
            return true;
        }

        for (int i = 0; i < n; i++)
        {
            if (IsSafe(chessBoard, row, i, n))
            {
                chessBoard[row, i] = 1;
                if (SolutionFinder(n, chessBoard, row + 1))
                {
                    return true;
                }
                chessBoard[row, i] = 0;
            }
        }
        return false;
    }

    private static bool IsSafe(int[,] chessBoard, int row, int col, int n)
    {
        // Check for queen in same row
        for(int y = col; y >= 0; y--)
        {
            if (chessBoard[row, y] == 1)
            {
                return false;
            }
        }

        // Check for queen above
        for (int x = row; x >= 0; x--)
        {
            if (chessBoard[x, col] == 1)
            {
                return false;
            }
        }

        //check for queen diagonally (upper left)
        for (int x = row, y = col; y >= 0 && x >= 0; y--, x--)
        {
            if (chessBoard[x, y] == 1)
            {
                return false;
            }
        }

        // Check for queen diagonally (upper right)
        for (int x = row, y = col; x >= 0 && y < n; x--, y++)
        {
            if (chessBoard[x, y] == 1)
            {
                return false;
            }
        }

        return true;
    }
}
