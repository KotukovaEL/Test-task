using System;

namespace Task1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив до: ");
            int[] array = GenerateArray(20, -100, 100);
            PrintArray(array);

            Console.WriteLine("\nСумма неотрицательных элементов: "+ FindSum(array));
           
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static int[] GenerateArray(int length, int minValue, int MaxValue)
        {
            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, MaxValue);
            }
            return array;
        }
        static int FindSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) 
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
