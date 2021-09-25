using System;
using Xunit;
using ZChess.Domain;
using ZChess.Domain.Pieces;
using ZChess.Domain.Enumerators;

namespace ZChess.Tests
{
    public class PieceTest
    {
        [Theory]
        [InlineData(Team.White, PieceColumn.D, 4, PieceColumn.D, 3)]
        [InlineData(Team.Black, PieceColumn.D, 4, PieceColumn.D, 5)]
        [InlineData(Team.White, PieceColumn.D, 2, PieceColumn.E, 5)]
        [InlineData(Team.Black, PieceColumn.D, 2, PieceColumn.E, 5)]
        public void MoveTo_InvalidPosition_ShouldThrowArgumentException(Team team, PieceColumn currentColumn, int currentRow, PieceColumn newColumn, int newRow)
        {
            // Arrange
            Pawn pawn = new Pawn(team);
            PiecePosition currentPosition = new PiecePosition(currentColumn, currentRow);
            pawn.SetPosition(currentPosition);

            // Act
            Action action = () => pawn.MoveTo(new PiecePosition(newColumn, newRow));

            // Assert
            Assert.Throws<ArgumentException>("position", action);
            Assert.Equal(currentPosition, pawn.Position);
        }

        //[Theory]
        //[InlineData(Team.White, PieceColumn.D, 4, PieceColumn.D, 4)]
        //public void MoveTo_ValidPosition_ShouldBeTheSameReference(Team team, PieceColumn currentColumn, int currentRow, PieceColumn newColumn, int newRow)
        //{
        //    // Arrange
        //    Pawn pawn = new Pawn(team);
        //    PiecePosition currentPosition = new PiecePosition(currentColumn, currentRow);
        //    pawn.SetPosition(currentPosition);

        //    // Act
        //    pawn.MoveTo(new PiecePosition(newColumn, newRow));
 
        //    // Assert
        //    Assert.Equal(currentPosition, pawn.Position);
        //}
    }
}
