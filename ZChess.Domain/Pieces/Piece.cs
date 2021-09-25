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
        public PiecePosition Position { get; private set; }
        public bool Captured { get; private set; }
        public int Movements { get; private set; }
        public Piece(Team team)
        {
            this.team = team;
            this.Captured = false;
            Position = null;
        }

        public void SetPosition(PiecePosition position)
        {
            if (position == null)
                throw new ArgumentNullException(nameof(position));

            if (Position != null && (Position.Column != position.Column || Position.Row != position.Row))
                Movements++;
            this.Position = position;
        }

        public void MoveTo(PiecePosition position)
        {
            if (!CanMoveTo(position))
                throw new ArgumentException($"Can't move the piece to the new position", nameof(position));
            SetPosition(position);
        }

        public void SetCaptured()
        {
            this.Captured = true;
        }

        public abstract bool CanMoveTo(PiecePosition newPosition);
        public abstract bool CanCaptureTo(PiecePosition newPosition);
    }
}
