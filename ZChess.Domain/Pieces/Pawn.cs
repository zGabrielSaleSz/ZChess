using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZChess.Domain.Enumerators;
using ZChess.Domain.Pieces.Interfaces;

namespace ZChess.Domain.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Team team) : base(team) { }
        public override bool CanCaptureTo(PiecePosition newPosition)
        {
            if (position.Column == newPosition.Column)
                return false;
            var availableMovementFound = GetAvailableMovementsToCapture().Where(m => m.Row == newPosition.Row && m.Column == newPosition.Column).FirstOrDefault();
            return availableMovementFound != null;
        }
        public override bool CanMoveTo(PiecePosition newPosition)
        {
            bool isValidColumn = this.position.Column == newPosition.Column;
            if (!isValidColumn)
                return false;

            if(team == Team.White)
                return newPosition.Row - position.Row == 1;
            
            else
                return position.Row - newPosition.Row == 1;
        }

        private IEnumerable<PiecePosition> GetAvailableMovementsToCapture()
        {
            List<PiecePosition> availablePositions = new List<PiecePosition>();
            if(team == Team.White)
            {
                AddPositionToListIfNotNull(availablePositions, GetPositionByDislocationIfIsValid(-1, 1));
                AddPositionToListIfNotNull(availablePositions, GetPositionByDislocationIfIsValid(1, 1));
            }
            else
            {
                AddPositionToListIfNotNull(availablePositions, GetPositionByDislocationIfIsValid(-1, -1));
                AddPositionToListIfNotNull(availablePositions, GetPositionByDislocationIfIsValid(1, -1));
            }
            return availablePositions;
        }

        private void AddPositionToListIfNotNull(List<PiecePosition> positions, PiecePosition newPosition)
        {
            if (newPosition != null)
                positions.Add(newPosition);
        }
        private PiecePosition GetPositionByDislocationIfIsValid(int dislocationColumn, int dislocationRow)
        {
            try
            {
                return position.GetPositionByDislocation(dislocationColumn, dislocationRow);
            }
            catch
            {
                return null;
            }
        }

     
    }
}
