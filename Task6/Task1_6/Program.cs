using System;
using System.Collections.Generic;

namespace Task1_6
{
    internal class Program
    {
        public enum DisplayType
        {
            bold = 1,
            italic,
            underline,
        }
        static void Main(string[] args)
        {
            var displayTypes = new List<DisplayType>();
            var enteredType = DisplayType.bold;
            Console.WriteLine("Параметры надписи: None");
            while (true)
            {
                
                Console.WriteLine("Введите: \n\t 1: bold \n\t 2: italic \n\t 3: underline");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    enteredType = DisplayType.bold;
                    if (!displayTypes.Remove(enteredType))
                    {
                        displayTypes.Add(enteredType);
                    }
                    Console.WriteLine("Параметры надписи: ");
                    for (int i = 0; i < displayTypes.Count; i++)
                    {
                        Console.WriteLine(displayTypes[i]);
                    }
                    
                }

                else if (n == 2)
                {
                    enteredType = DisplayType.italic;
                    if (!displayTypes.Remove(enteredType))
                    {
                        displayTypes.Add(enteredType);
                    }
                    Console.WriteLine("Параметры надписи: ");
                    for (int i = 0; i < displayTypes.Count; i++)
                    {
                        Console.WriteLine(displayTypes[i]);
                    }
                }

                else if (n == 3)
                {
                    enteredType = DisplayType.underline;
                    if (!displayTypes.Remove(DisplayType.underline))
                    {
                        displayTypes.Add(DisplayType.underline);
                    }
                    Console.WriteLine("Параметры надписи: ");
                    for (int i = 0; i < displayTypes.Count; i++)
                    {
                        Console.WriteLine(displayTypes[i]);
                    }
                }
            }


        }

    }
}
