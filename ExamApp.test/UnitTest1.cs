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

        // Test for 4x4 grid

    }
}
