using System;
using System.Collections.Generic;

namespace Task1_6
{
    internal class Program
    {
        public enum DisplayType
        {
            Bold = 1,
            Italic,
            Underline,
        }
        static void Main(string[] args)
        {
            var displayTypes = new List<DisplayType>();
            var enteredType = DisplayType.Bold;
            Console.WriteLine("Параметры надписи: None");
            while (true)
            {

                Console.WriteLine("Введите: \n\t 1: bold \n\t 2: italic \n\t 3: underline");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    enteredType = DisplayType.Bold;
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
                    enteredType = DisplayType.Italic;
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
                    enteredType = DisplayType.Underline;
                    if (!displayTypes.Remove(DisplayType.Underline))
                    {
                        displayTypes.Add(DisplayType.Underline);
                    }
                    Console.WriteLine("Параметры надписи: ");
                    for (int i = 0; i < displayTypes.Count; i++)
                    {
                        Console.WriteLine(displayTypes[i]);
                    }
                }
            }
            static void OutPutType(DisplayType enteredType)
            {
                while (true)
                {
                    var enteredStr = Console.ReadLine();
                    if (!Enum.TryParse<DisplayType>(enteredStr, out enteredType))
                    {
                        PrintList();
                        break;
                    }
                    if (!Enum.IsDefined(enteredType))
                    {
                        break;
                    }
                }
            }
            static void PrintList(List<DisplayType> list)
            {
                foreach (DisplayType item in list)
                {
                    Console.WriteLine("Параметры надписи: " + item);
                }
                Console.WriteLine();
            }
        }
    }
}
