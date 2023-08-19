using System;

namespace Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту треугольника: ");
            int n = int.Parse(Console.ReadLine());
            Logic.PrintTriangle(n);
        }
    }
}
