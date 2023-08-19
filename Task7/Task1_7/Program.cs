using System;

namespace Task1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив до сортировки: ");
            //int[] array = Logic.GenerateArray(20, 1, 100);
            int[] array = new int[] {1, 10, 8, 2, 3, 6, 5, 9, 7};
            Logic.PrintArray(array);

            Console.WriteLine("\nМассив после сортировки: ");
            Logic.Sort(array, 0, array.Length-1);
            Logic.PrintArray(array);

            Console.WriteLine("\nМинимальное значение массива: " + Logic.FindMin(array));
            Console.WriteLine("\nМаксимальное значение массива: " + Logic.FindMax(array));
        }
    }
}
