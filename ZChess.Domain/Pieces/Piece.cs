using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZChess.Domain.Enumerators;
using ZChess.Domain.Pieces.Interfaces;

namespace ZChess.Domain.Pieces
{
    public abstract class Piece 
    {
        public Team team { get; private set; }
        private bool captured { get; set; }
        public PiecePosition position { get; set; }
        public Piece(Team team)
        {
            this.team = team;
            this.captured = false;
        }

        public void SetPosition(PiecePosition position)
        {
            this.position = position;
        }

        public void MoveTo(PiecePosition position)
        {
            if (CanMoveTo(position))
                SetPosition(position);
            else
                throw new ArgumentException($"Can't move the piece to the new position", "position");
        }

        public void SetCaptured()
        {
            this.captured = true;
        }

        public bool IsCaptured()
        {
            return this.captured;
        }
        public abstract bool CanMoveTo(PiecePosition newPosition);
        public abstract bool CanCaptureTo(PiecePosition newPosition);
    }
}
