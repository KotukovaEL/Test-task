using System;

namespace Task1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив до: ");
            int[] array = Logic.GenerateArray(20, -100, 100);
            Logic.PrintArray(array);

            Console.WriteLine("\nСумма неотрицательных элементов: "+ Logic.FindSum(array));
        }
    }
}
