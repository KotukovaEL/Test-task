using System;

namespace Task1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                Triangle(i, n);
            }
            
        }
        static void Triangle(int n, int nMax)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = nMax; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
