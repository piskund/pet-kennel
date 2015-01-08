using System;
using System.Collections.Generic;
using System.Text;

namespace Mechs.Common.Interfaces
{
    public interface ITimeLine
    {
        event EventHandler OnEndOfTurn;

        void EndOfTurn();

        ulong TurnNumber { get; }
        int Day { get; }
        int DayOfWeek { get; }
        int DayOfYear { get; }
        int Week { get; }
        int Month { get; }
        int Year { get; }
    }
}
