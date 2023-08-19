using System;

namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону прямоугольника: ");
            int a = Logic.ReadInt(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника: ");
            int b = Logic.ReadInt(Console.ReadLine());

            Console.WriteLine("Площадь прямоугольника: " + Logic.CalculateSquare(a, b));
        }
    }
}
