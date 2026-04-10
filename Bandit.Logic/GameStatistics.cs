using System;

namespace Bandit.Logic
{
    public class GameStatistics
    {
        public int TotalGames { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public decimal TotalWinnings { get; private set; }
        public decimal TotalLosses { get; private set; }
        public decimal MaxWin { get; private set; }
        public decimal LastWin { get; private set; }
        public DateTime StartTime { get; private set; }

        public GameStatistics()
        {
            StartTime = DateTime.Now;
        }

        public void RecordGame(decimal bet, decimal win)
        {
            TotalGames++;
            
            if (win > 0)
            {
                Wins++;
                TotalWinnings += win;
                LastWin = win;
                
                if (win > MaxWin)
                {
                    MaxWin = win;
                }
            }
            else
            {
                Losses++;
                TotalLosses += bet;
            }
        }

        public double WinRate
        {
            get
            {
                if (TotalGames == 0) return 0;
                return (double)Wins / TotalGames * 100;
            }
        }

        public decimal NetProfit
        {
            get { return TotalWinnings - TotalLosses; }
        }

        public TimeSpan PlayTime
        {
            get { return DateTime.Now - StartTime; }
        }
    }
}
