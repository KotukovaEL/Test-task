using System;

namespace Task1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив: ");
            int[,] array = GenerateArray(0, 100);
            PrintArray(array);

            Console.WriteLine("\nСумма элементов, стоящих на четных позициях: " + FindSum(array));
        }
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");                    
                }
                Console.WriteLine();
            }
        }
        static int[,] GenerateArray(int minValue, int MaxValue)
        {
            int[,] array = new int[4, 3];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, MaxValue);
                }

            }
            return array;
        }
        static int FindSum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i+j)%2== 0)
                    {
                        sum += array[i,j];
                    }
                }
               
            }
            return sum;
        }

    }
}
