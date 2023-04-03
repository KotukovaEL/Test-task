using System;

namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine(new string('*', i));
            }
          
        }
    }
}
