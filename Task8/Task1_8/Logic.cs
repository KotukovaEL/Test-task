using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_8
{
    public class Logic
    {
        public static int[,,] GenerateArray(int minValue, int MaxValue)
        {
            int[,,] array = new int[4, 3, 5];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(minValue, MaxValue);
                    }
                }

            }
            return array;
        }
        public static void PrintArray(int[,,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("Page #: " + (i + 1));

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public static void ReplaceArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            int temp = array[i, j, k];
                            array[i, j, k] = 0;
                        }
                    }
                }

            }
        }
    }
}
