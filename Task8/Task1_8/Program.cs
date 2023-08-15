using System;

namespace Task1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = Logic.GenerateArray(-100,100);
            Console.WriteLine("Массив до преобразований: ");
            Logic.PrintArray(array);

            Console.WriteLine("Массив после преобразований: ");
            Logic.ReplaceArray(array);
            Logic.PrintArray(array);
        }        
    }
}
