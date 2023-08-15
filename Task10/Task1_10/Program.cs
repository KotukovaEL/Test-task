using System;

namespace Task1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив: ");
            int[,] array = Logic.GenerateArray(4, 3, 0, 100);
            Logic.PrintArray(array);

            Console.WriteLine("\nСумма элементов, стоящих на четных позициях: " + Logic.FindSum(array));
        }
        

    }
}
