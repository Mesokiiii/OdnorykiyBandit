using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandit.Logic
{
    public class Player
    {
        private decimal _balance;
        public decimal Balance => _balance;

        public Player(decimal initialBalanace)
        {
            _balance = initialBalanace;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Сумма пополнения не может быть отрицательной");
            }
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Сумма снятия не может быть отрицательной");
            }
            
            if (amount > _balance) 
            {
                throw new InvalidOperationException($"Недостаточно средств. Ваш баланс: {_balance:F2} руб., попытка снять: {amount:F2} руб.");
            }
            
            _balance -= amount;
        }

    }
}
