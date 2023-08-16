using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_4
{
    public class Logic
    {
        public static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int k = n; k >= j; k--)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine(new string('*', j * 2 - 1));
                }
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
