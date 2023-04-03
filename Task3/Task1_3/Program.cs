using System;

namespace Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту треугольника: ");
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(new string('*', i * 2 - 1));
            }

        }
    }
}
