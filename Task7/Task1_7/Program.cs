using System;

namespace Task1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Массив до сортировки: "+ );
            int[] massiv = Random(20, 1, 10);
            Console.WriteLine("\nМассив после сортировки: ");
            Sorting(massiv);
            for (int i = 0;i < massiv.Length; i++)
            {
                Console.Write(massiv[i]+" ");
            }
            Console.WriteLine("\nМинимальное значение массива: " + massiv[0]);
            Console.WriteLine("\nМаксимальное значение массива: " + massiv[massiv.Length-1]);

            static int[] Random(int length, int minValue, int MaxValue)
            {
                int[] array = new int[length];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(minValue, MaxValue);
                    //Console.Write(massiv[i] + " ");
                }
                return array;
            }

            static int[] Sorting(int[] massiv)
            {
                int leftBorder = 0;
                
                for (int i = 0; i < massiv.Length; i++)
                {
                    for (int j = i; j<massiv.Length; j++)
                    {
                        if (massiv[i] > massiv[j])
                        {
                            leftBorder = massiv[i];
                            massiv[i] = massiv[j];
                            massiv[j] = leftBorder;
                        }
                    }
                }
                
                
                return massiv;
            }
        }
    }
}
