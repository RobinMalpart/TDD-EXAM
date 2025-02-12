using System;

namespace ExamApp
{
    public class Program
    {
        public char[,] grid;
        public int size;

        static void Main(string[] args)
        {
            Program program = new Program(10);
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
            if (size == 1)
            {
                grid[0, 0] = '#';
                return;
            }

            if (size == 2 || size == 3)
            {
                throw new InvalidOperationException($"No solution exists for a {size}x{size} grid.");
            }

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
