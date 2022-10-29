using System.Collections.Generic;

namespace StockManagerHero
{
    public class GameGrid
    {
        private readonly int[,] grid;
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int this[int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }

        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            grid = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    grid[i, j] = 0;
                }
            }
        }

        private bool IsBlockFull(int blockNbr)
        {
            int firstRow = (blockNbr / 3) * 3;
            int firstCol = blockNbr * 3 % 9;
            for (int i = firstRow; i < firstRow + 3; i++)
            {
                for (int j = firstCol; j < firstCol + 3; j++)
                {
                    if (grid[i, j] == 0) return false;
                }
            }
            return true;
        }

        private bool IsRowFull(int row)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grid[row, i] == 0) return false;
            }
            return true;
        }

        private bool IsColFull(int col)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grid[i, col] == 0) return false;
            }
            return true;
        }

        private void ClearBlock(int blockNbr)
        {
            int firstRow = (blockNbr / 3) * 3;
            int firstCol = blockNbr * 3 % 9;
            for (int i = firstRow; i < firstRow + 3; i++)
            {
                for (int j = firstCol; j < firstCol + 3; j++)
                {
                    grid[i, j] = 0;
                }
            }
        }

        private void ClearRow(int row)
        {
            for (int i = 0; i < 9; i++)
            {
                grid[row, i] = 0;
            }
        }

        private void ClearCol(int col)
        {
            for (int i = 0; i < 9; i++)
            {
                grid[i, col] = 0;
            }
        }

        public int CheckAndClear()
        {
            int score = 0;
            List<int> rowToClear = new List<int>();
            List<int> colToClear = new List<int>();
            List<int> blockToClear = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                if (IsRowFull(i))
                {
                    rowToClear.Add(i);
                }
                for (int j = 0; j < 9; j++)
                {
                    int blockNbr = (i / 3) * 3 + j / 3;
                    if (IsBlockFull(blockNbr) && !blockToClear.Contains(blockNbr))
                    {
                        blockToClear.Add(blockNbr);
                    }
                }
            }
            for (int j = 0; j < 9; j++)
            {
                if (IsColFull(j))
                {
                    colToClear.Add(j);
                }
            }
            foreach (int i in rowToClear)
            {
                ClearRow(i);
                score += 9;
            }

            foreach (int j in colToClear)
            {
                ClearCol(j);
                score += 9;
            }

            foreach (int blockNbr in blockToClear)
            {
                ClearBlock(blockNbr);
                score += 9;
            }

            return score;
        }
    }
}
