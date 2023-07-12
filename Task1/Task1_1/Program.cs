using System;

namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону прямоугольника: ");
            int a = ReadInt(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника: ");
            int b = ReadInt(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                throw new Exception("Вы ввели 0 или отрицательное число");
            }

            int result = a * b;
            Console.WriteLine("Площадь прямоугольника: " + result);
        }

        static int ReadInt(string str)
        {
            if (!int.TryParse(str, out int value)) 
            {
                throw new Exception($"Некорректное целое значение '{value}'.");
            }

            return value;
        } 
    }
}
