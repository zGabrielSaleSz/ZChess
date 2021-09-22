using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZChess.Domain.Enumerators;
using ZChess.Domain.Pieces;
using ZChess.Domain.Pieces.Interfaces;

namespace ZChess.Domain
{
    public class ChessTeamBuilder
    {
        private Team team;
        private List<IPiece> pieces;
        public ChessTeamBuilder(Team team)
        {
            this.pieces = new List<IPiece>();
            this.team = team;
        }

        private void BuildPieces()
        {
            //pieces.Add(new King());
        }
    }
}
