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
            program.PlaceNQueen();
            program.DisplayGrid();
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
            }
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
