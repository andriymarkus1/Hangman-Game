using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шибениця_2._0
{
    static class DifficultyLevel
    {
        public static int difficulty;
        private static Random random = new Random();
        public static int GetNumbOfLetters()
        {
            int a, b;
            switch (difficulty)
            {
                case 0: a = 5; b = 6; break;
                case 1: a = 7; b = 10; break;
                case 2: a = 11; b = 13; break;
                default: a = 7; b = 10; break;
            }
            int length = random.Next(a, b);
            return length;
        }
    }
}
