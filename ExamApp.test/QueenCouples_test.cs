using System;
using Xunit;
using ExamApp;

namespace ExamApp.test
{
    public class QueenCouples_test
    {
        [Fact]
        public void TestPlaceNQueenWithPairConflict_4x4Grid_VerifyNumberOfQueens()
        {
            Program program = new Program(4);
            program.PlaceNQueenWithPairConflict();

            int queenCount = program.CountQueen();
            
            Assert.Equal(4, queenCount); 
        }
    }
}