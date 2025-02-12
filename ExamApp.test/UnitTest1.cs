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
    }
}
