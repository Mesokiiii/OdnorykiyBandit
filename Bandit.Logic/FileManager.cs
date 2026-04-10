using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bandit.Logic
{
    public class FileManager
    {
        private readonly string _filePath = "history.txt";

        public void SaveResult(decimal bet, decimal win, decimal balance)
        {
            string logEntry = $"[{DateTime.Now}] Ставка: {bet}, Выигрыш: {win}, Баланс: {balance}{Environment.NewLine}";

            File.AppendAllText(_filePath, logEntry);
        }
    }
}