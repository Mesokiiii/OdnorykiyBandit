using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandit.Logic
{
    public class SlotMachine
    {
        private readonly Random _random = new Random();

        public SlotSymbol[] Spin()
        {
            SlotSymbol[] result = new SlotSymbol[3];

            for (int i = 0; i < 3; i++)
            {

                result[i] = (SlotSymbol)_random.Next(0, 5);
            }

            return result;
        }

        public int CalculateWin(SlotSymbol[] symbols)
        {

           

            // 1. Проверка на ДЖЕКПОТ (Три семерки)

            if (symbols[0] == SlotSymbol.Seven &&
                symbols[1] == SlotSymbol.Seven &&
                symbols[2] == SlotSymbol.Seven)
            {
                return 10; // Самый большой выигрыш 
            }

            // 2. Проверка на любые ТРИ ОДИНАКОВЫХ (Три вишни, три лимона и т.д.)
          
            if (symbols[0] == symbols[1] && symbols[1] == symbols[2])
            {
                return 5; // Коэффициент 5
            }

            // 3. Проверка на ПАРУ (Хотя бы две одинаковые)
   
            if (symbols[0] == symbols[1] || // Первая и вторая
                symbols[1] == symbols[2] || // Вторая и третья
                symbols[0] == symbols[2])   // Первая и третья
            {
                return 2; // Коэффициент 2
            }

            return 0; // Выигрыша нет
        }
    }
}
