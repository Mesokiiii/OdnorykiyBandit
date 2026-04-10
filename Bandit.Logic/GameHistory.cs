using System;
using System.Collections.Generic;

namespace Bandit.Logic
{
    public class GameRecord
    {
        public DateTime Time { get; set; }
        public decimal Bet { get; set; }
        public decimal Win { get; set; }
        public decimal BalanceAfter { get; set; }
        public SlotSymbol[] Symbols { get; set; }

        public bool IsWin => Win > 0;
    }

    public class GameHistory
    {
        private List<GameRecord> _records = new List<GameRecord>();
        private const int MaxRecords = 50;

        public void AddRecord(decimal bet, decimal win, decimal balance, SlotSymbol[] symbols)
        {
            var record = new GameRecord
            {
                Time = DateTime.Now,
                Bet = bet,
                Win = win,
                BalanceAfter = balance,
                Symbols = symbols
            };

            _records.Insert(0, record);

            if (_records.Count > MaxRecords)
            {
                _records.RemoveAt(_records.Count - 1);
            }
        }

        public List<GameRecord> GetRecords()
        {
            return new List<GameRecord>(_records);
        }

        public int Count => _records.Count;
    }
}
