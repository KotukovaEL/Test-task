﻿using System;

namespace Task1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            int n = Logic.ReadInt(Console.ReadLine());
            Logic.PrintTriangle(n);
        }
    }
}
