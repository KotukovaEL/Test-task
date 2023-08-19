using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_3
{
    public class Logic
    {
        public static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', i * 2 - 1));
            }
        }
    }
}
