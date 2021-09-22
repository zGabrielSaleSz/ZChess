using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZChess.Domain.Enumerators;

namespace ZChess.Domain
{
    public class BoardValidator
    {
        public static bool IsValidRow(int row)
        {
            return row > 0 && row < 9;
        }
        public static bool IsValidColumn(PieceColumn pieceColumn)
        {
            return IsValidColumn((int)pieceColumn);
        }
        public static bool IsValidColumn(int column)
        {
            return column > 0 && column < 9;
        }
    }
}
