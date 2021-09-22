using System;
using Xunit;
using ZChess.Domain;
using ZChess.Domain.Pieces;
using ZChess.Domain.Enumerators;

namespace ZChess.Tests
{
    public class PawnTests : IPieceCommonTests
    {
        

        [Theory]
        [InlineData(Team.White, PieceColumn.D, 4, PieceColumn.D, 5)]
        [InlineData(Team.White, PieceColumn.D, 4, PieceColumn.E, 3)]
        [InlineData(Team.White, PieceColumn.H, 8, PieceColumn.G, 7)]

        [InlineData(Team.Black, PieceColumn.D, 2, PieceColumn.F, 1)]
        [InlineData(Team.Black, PieceColumn.D, 2, PieceColumn.C, 2)]
        [InlineData(Team.Black, PieceColumn.D, 2, PieceColumn.D, 2)]
        public void CanCaptureTo_InvalidPosition_ShouldReturnFalse(Team team, PieceColumn currentColumn, int currentRow, PieceColumn newColumn, int newRow)
        {
            // Arrange
            Pawn pawn = new Pawn(team);
            PiecePosition currentPosition = new PiecePosition(currentColumn, currentRow);
            pawn.SetPosition(currentPosition);

            // Act
            PiecePosition newPosition = new PiecePosition(newColumn, newRow);
            bool result = pawn.CanCaptureTo(newPosition);
            //Assert
            Assert.False(result);
        }
    }
}
