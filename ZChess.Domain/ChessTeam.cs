using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZChess.Domain.Enumerators;
using ZChess.Domain.Pieces;

namespace ZChess.Domain
{
    public class ChessTeam
    {
        public ChessTeam()
        {
            CastlingAvailable = false;
        }
        public King King { get; set; }
        public Queen Queen { get; set; }
        public Bishop[] Bishops { get; private set; } = new Bishop[2];
        public Rook[] Rooks { get; private set; } = new Rook[2];
        public Knight[] Knights { get; private set; } = new Knight[2];
        public Pawn[] Pawns { get; private set; } = new Pawn[8];

        public bool CastlingAvailable { get; set; }
        public bool IsCompleted()
        {
            return King != null && Queen != null && Bishops.Count() == 2 && Rooks.Count() == 2 && Knights.Count() == 2 && Pawns.Count() == 8;
        }
    }
}
