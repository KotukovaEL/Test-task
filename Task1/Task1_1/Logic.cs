using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    public static class Logic
    {
        public static int ReadInt(string str)
        {
            if (!int.TryParse(str, out int value)) 
            {
                throw new Exception($"Некорректное целое значение '{value}'.");
            }

            return value;
        } 

        public static int CalculateSquare(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new Exception("Вы ввели 0 или отрицательное число");
            }

            return a * b;
        }
    }
}
