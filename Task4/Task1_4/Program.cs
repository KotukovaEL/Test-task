using System;

namespace Task1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            int n = ReadInt(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                PrintTriangle(i, n);
            }
            
        }
        static void PrintTriangle(int n, int nMax)
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
        static int ReadInt(string str) 
        {
            if (!int.TryParse(str, out int value))
            {
                throw new Exception($"Некорректное целое значение '{str}'.");
            }

            return value;
        }
    }
}
