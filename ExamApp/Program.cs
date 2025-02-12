using System;

namespace ExamApp
{
    public class Program
    {
        public char[,] grid;
        public int size;

        static void Main(string[] args)
        {
            Program program = new Program(4);
            try
            {
                program.PlaceNQueen();
                program.DisplayGrid();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Program(int n)
        {
            size = n;
            grid = new char[n, n];
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j] = '0';
                }
            }
        }

        public void PlaceNQueen()
        {
            if (size == 2 || size == 3)
            {
                throw new InvalidOperationException($"No solution exists for a {size}x{size} grid.");
            }

            SolveNQueen(0);
        }

        private bool SolveNQueen(int row)
        {
            if (row >= size)
                return true;

            for (int col = 0; col < size; col++)
            {
                if (IsSafe(row, col))
                {
                    grid[row, col] = '#';
                    if (SolveNQueen(row + 1))
                        return true;  
                    grid[row, col] = '0';
                }
            }
            return false;
        }

        private bool IsSafe(int row, int col)
        {
            for (int i = 0; i < row; i++)
                if (grid[i, col] == '#')
                    return false;

            //=====================Check diagonals========================
            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
                if (grid[i, j] == '#')
                    return false;


            for (int i = row - 1, j = col + 1; i >= 0 && j < size; i--, j++)
                if (grid[i, j] == '#')
                    return false;

            return true;
        }

        public int CountQueen()
        {
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (grid[i, j] == '#')
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public void PlaceNQueenWithPairConflict()
        {
        }

        public void DisplayGrid()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
