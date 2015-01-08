using System;
using Mechs.Common.Interfaces;

namespace Mechs.BL.BusinessObjects
{
    /// <summary>
    /// Timeline class
    /// </summary>
    public sealed class TimeLine : ITimeLine
    {
        public event EventHandler OnEndOfTurn;

        private ulong counter;

        private static readonly TimeLine instance = new TimeLine();

        /// <summary>
        /// Timeline singleton instance
        /// </summary>
        public static ITimeLine Instance
        {
            get { return TimeLine.instance; }
        } 

        private TimeLine() 
        {
            counter = 0;
        }


        #region ITimeLine Members

        /// <summary>
        /// Number of current turn.
        /// </summary>
        public ulong TurnNumber
        {
            get { return counter; }
        }

        /// <summary>
        /// Process end of turn. Fire EOT event.
        /// </summary>
        public void EndOfTurn()
        {
            counter++;
            if (OnEndOfTurn != null)
            {
                OnEndOfTurn(this, null);
            }
        }

        /// <summary>
        /// Current day.
        /// </summary>
        public int Day
        {
            get 
            { 
                return (int)(counter & 0x1F); 
            }
        }

        /// <summary>
        /// Day in week
        /// </summary>
        public int DayOfWeek
        {
            get 
            {
                return Day - Week * 8;
            }
        }

        /// <summary>
        /// Day in Year
        /// </summary>
        public int DayOfYear
        {
            get 
            {
                return (int)(counter - (ulong)(Year*512));
            }
        }

        /// <summary>
        /// Current week. Contains 8 days
        /// </summary>
        public int Week
        {
            get 
            { 
                return Day/8; 
            }
        }

        /// <summary>
        /// Current month. Contains 32 days
        /// </summary>
        public int Month
        {
            get 
            { 
                return (int)(counter & 0x1E0) >> 5; 
            }
        }

        /// <summary>
        /// Current year. Contains 16 month
        /// </summary>
        public int Year
        {
            get 
            { 
                return (int)(counter >> 9);
            }
        }

        #endregion

        /// <summary>
        /// Increment month (add 32 days)
        /// </summary>
        public void IncrementMonth(byte numOfMonthes = 1)
        {
            this.counter += (ulong)32*numOfMonthes;
        }

        public void IncrementDay(ulong numOfDays = 1)
        {
            this.counter += numOfDays;
        }
    }
}
