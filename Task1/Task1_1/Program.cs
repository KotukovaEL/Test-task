using System;

namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону прямоугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника: ");
            double b = double.Parse(Console.ReadLine());
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Вы ввели 0 или отрицательное число");
            }
            else
            {
                double result = a * b;
                Console.WriteLine("Площадь прямоугольника: " + result);
            }

        }
    }
}
