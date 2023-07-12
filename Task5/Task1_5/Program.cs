using System;

namespace Task1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int count = 0;
            for (int i = 1; i < n; i++) 
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    count+=i;
                }
                
            }
            Console.WriteLine("Сумма чисел: " + count);
        }
    }
}
