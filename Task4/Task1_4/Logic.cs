using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_4
{
    public class Logic
    {
        public static void PrintTriangle(int n, int nMax)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = nMax; j >= i; j--)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(new string('*', i * 2 - 1));
            }
        }
        public static int ReadInt(string str)
        {
            if (!int.TryParse(str, out int value))
            {
                throw new Exception($"Некорректное целое значение '{str}'.");
            }

            return value;
        }
    }
}
