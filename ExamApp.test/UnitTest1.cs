using System;
using Xunit;
using ExamApp;

namespace ExamApp.test
{
    public class UnitTest1
    {
        [Fact]
        public void TestPlaceNQueen_1x1Grid()
        {
            Program program = new Program(1);
            program.PlaceNQueen();
            Assert.Equal('#', program.grid[0, 0]);
        }

        [Fact]
        public void TestPlaceNQueen_2x2Grid_ThrowsInvalidOperationException()
        {
            Program program = new Program(2);
            Assert.Throws<InvalidOperationException>(() => program.PlaceNQueen());
        }

        [Fact]
        public void TestPlaceNQueen_3x3Grid_ThrowsInvalidOperationException()
        {
            Program program = new Program(3);
            Assert.Throws<InvalidOperationException>(() => program.PlaceNQueen());
        }

        // ==================TESTS pour 4x4======================
        [Fact]
        public void TestPlaceNQueen_4x4Grid_VerifyQueensNumber()
        {
            Program program = new Program(4);
            program.PlaceNQueen();
            int queenCount = program.CountQueen();
            Assert.Equal(4, queenCount);
        }

        [Fact]
        public void TestPlaceNQueen_4x4Grid_VerifyQueensAreNotOnSameRow()
        {
            Program program = new Program(4);
            program.PlaceNQueen();

            for (int row = 0; row < 4; row++)
            {
                int queenCountInRow = 0;
                for (int col = 0; col < 4; col++)
                {
                    if (program.grid[row, col] == '#')
                    {
                        queenCountInRow++;
                    }
                }
                Assert.True(queenCountInRow <= 1, $"More than one queen found on row {row}");
            }
        }

        [Fact]
        public void TestPlaceNQueen_4x4Grid_VerifyQueensAreNotOnSameColumn()
        {
            Program program = new Program(4);
            program.PlaceNQueen();

            for (int col = 0; col < 4; col++)
            {
                int queenCountInColumn = 0;
                for (int row = 0; row < 4; row++)
                {
                    if (program.grid[row, col] == '#')
                    {
                        queenCountInColumn++;
                    }
                }
                Assert.True(queenCountInColumn <= 1, $"More than one queen found in column {col}");
            }
        }

    }
}
