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
        private ChessTeam chessTeam;
        public ChessTeamBuilder(Team team)
        {
            this.team = team;
        }

        private void GetChessTeam()
        {
            chessTeam.King = new King(team);
            chessTeam.Queen = new Queen(team);

            chessTeam.Bishops[0] = new Bishop(team);
            chessTeam.Bishops[1] = new Bishop(team);
            chessTeam.Knights[0] = new Knight(team);
            chessTeam.Knights[1] = new Knight(team);

            chessTeam.Rooks[0] = new Rook(team);
            chessTeam.Rooks[1] = new Rook(team);
            chessTeam.Pawns[0] = new Pawn(team);
            chessTeam.Pawns[1] = new Pawn(team);
            chessTeam.Pawns[2] = new Pawn(team);
            chessTeam.Pawns[3] = new Pawn(team);
            chessTeam.Pawns[4] = new Pawn(team);
            chessTeam.Pawns[5] = new Pawn(team);
            chessTeam.Pawns[6] = new Pawn(team);
            chessTeam.Pawns[7] = new Pawn(team);
            
            
        }

        private void SetDefaultPosition()
        {
            if(team == Team.White)
            {
                SetDefaultPositionWhite();
            }
            else if(team == Team.Black)
            {
                SetDefaultPositionBlack();
            }
        }

        private void SetDefaultPositionWhite()
        {
            chessTeam.Rooks[0].SetPosition(new PiecePosition(PieceColumn.A, 1));
            chessTeam.Knights[0].SetPosition(new PiecePosition(PieceColumn.B, 1));
            chessTeam.Bishops[0].SetPosition(new PiecePosition(PieceColumn.C, 1));
            chessTeam.Queen.SetPosition(new PiecePosition(PieceColumn.D, 1));
            chessTeam.King.SetPosition(new PiecePosition(PieceColumn.E, 1));
            chessTeam.Bishops[1].SetPosition(new PiecePosition(PieceColumn.F, 1));
            chessTeam.Bishops[1].SetPosition(new PiecePosition(PieceColumn.G, 1));
            chessTeam.Bishops[1].SetPosition(new PiecePosition(PieceColumn.H, 1));

            chessTeam.Pawns[0].SetPosition(new PiecePosition(PieceColumn.A, 2));
            chessTeam.Pawns[1].SetPosition(new PiecePosition(PieceColumn.B, 2));
            chessTeam.Pawns[2].SetPosition(new PiecePosition(PieceColumn.C, 2));
            chessTeam.Pawns[3].SetPosition(new PiecePosition(PieceColumn.D, 2));
            chessTeam.Pawns[4].SetPosition(new PiecePosition(PieceColumn.E, 2));
            chessTeam.Pawns[5].SetPosition(new PiecePosition(PieceColumn.F, 2));
            chessTeam.Pawns[6].SetPosition(new PiecePosition(PieceColumn.G, 2));
            chessTeam.Pawns[7].SetPosition(new PiecePosition(PieceColumn.H, 2));
        }
        private void SetDefaultPositionBlack()
        {
            chessTeam.Rooks[0].SetPosition(new PiecePosition(PieceColumn.H, 8));
            chessTeam.Knights[0].SetPosition(new PiecePosition(PieceColumn.G, 8));
            chessTeam.Bishops[0].SetPosition(new PiecePosition(PieceColumn.F, 8));
            chessTeam.Queen.SetPosition(new PiecePosition(PieceColumn.E, 8));
            chessTeam.King.SetPosition(new PiecePosition(PieceColumn.D, 8));
            chessTeam.Bishops[1].SetPosition(new PiecePosition(PieceColumn.C, 8));
            chessTeam.Bishops[1].SetPosition(new PiecePosition(PieceColumn.B, 8));
            chessTeam.Bishops[1].SetPosition(new PiecePosition(PieceColumn.A, 8));

            //
            chessTeam.Pawns[0].SetPosition(new PiecePosition(PieceColumn.A, 7));
            chessTeam.Pawns[1].SetPosition(new PiecePosition(PieceColumn.B, 7));
            chessTeam.Pawns[2].SetPosition(new PiecePosition(PieceColumn.C, 7));
            chessTeam.Pawns[3].SetPosition(new PiecePosition(PieceColumn.D, 7));
            chessTeam.Pawns[4].SetPosition(new PiecePosition(PieceColumn.E, 7));
            chessTeam.Pawns[5].SetPosition(new PiecePosition(PieceColumn.F, 7));
            chessTeam.Pawns[6].SetPosition(new PiecePosition(PieceColumn.G, 7));
            chessTeam.Pawns[7].SetPosition(new PiecePosition(PieceColumn.H, 7));
        }
    }
}
