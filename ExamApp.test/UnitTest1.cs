using System;
using Xunit;
using ExamApp;

namespace ExamApp.test
{
    public class UnitTest1
    {
        // Test size one grid
        [Fact]
        public void TestPlaceNQueen_1x1Grid()
        {
            Program program = new Program(1);
            program.PlaceNQueen();
            Assert.Equal('#', program.grid[0, 0]);
        }

        // Test size two grid

        //Test size three grid

        //Test size four grid
        
    }
}