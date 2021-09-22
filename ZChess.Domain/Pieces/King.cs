using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZChess.Domain.Enumerators;
using ZChess.Domain.Pieces.Interfaces;

namespace ZChess.Domain.Pieces
{
    public class King : Piece
    {
        public King(Team team) : base(team) { }
        public override bool CanCaptureTo(PiecePosition newPosition)
        {
            throw new NotImplementedException();
        }
        public override bool CanMoveTo(PiecePosition newPosition)
        {
            throw new NotImplementedException();
        }
    }
}
