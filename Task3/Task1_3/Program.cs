﻿using System;

namespace Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
           
                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            
        }
    }
}