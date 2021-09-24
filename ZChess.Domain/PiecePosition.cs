using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZChess.Domain.Enumerators;

namespace ZChess.Domain
{
    public class PiecePosition
    {
        public int Row { get; set; }
        public PieceColumn Column { get; set; }
        public PiecePosition(PieceColumn pieceColumn, int pieceRow)
        {
            if (!BoardValidator.IsValidRow(pieceRow))
                throw new ArgumentException("Row should be between 1 and 8", "pieceRow");

            this.Row = pieceRow;
            this.Column = pieceColumn;
        }
        public PiecePosition GetPositionByDislocation(int dislocationColumn, int dislocationRow)
        {
            int newColumnPosition = GetColumnAsInteger() + dislocationColumn;
            int newRowPosition = Row + dislocationRow;
            if (!BoardValidator.IsValidColumn(newColumnPosition) || !BoardValidator.IsValidColumn(newRowPosition))
                throw new Exception("Invalid position for this dislocation");
            return new PiecePosition((PieceColumn)newColumnPosition, newRowPosition);
        }

        public int GetColumnAsInteger()
        {
            return (int)Column;
        }
    }
}
