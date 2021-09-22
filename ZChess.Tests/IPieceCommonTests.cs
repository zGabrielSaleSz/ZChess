using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZChess.Domain.Enumerators;

namespace ZChess.Tests
{
    public interface IPieceCommonTests
    {
        void CanCaptureTo_InvalidPosition_ShouldReturnFalse(Team team, PieceColumn currentColumn, int currentRow, PieceColumn newColumn, int newRow);
    }
}
