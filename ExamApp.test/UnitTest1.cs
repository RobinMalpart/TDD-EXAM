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
            ChessGrid chessGrid = new ChessGrid(1);
            chessGrid.PlaceNQueen();
            Assert.Equal('#', chessGrid.GetCell(0, 0));
        }
    }
}