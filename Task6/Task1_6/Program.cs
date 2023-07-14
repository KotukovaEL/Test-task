using System;
using System.Collections.Generic;

namespace Task1_6
{
    internal class Program
    {
        public enum DisplayType
        {
            None,
            Bold,
            Italic,
            Underline,
        }
        static void Main(string[] args)
        {
            var displayTypes = new List<DisplayType>();
            Console.WriteLine("Параметры надписи: None");
            while (true)
            {
                Console.WriteLine("Введите: \n\t 1: bold \n\t 2: italic \n\t 3: underline. \n Для выхода из приложения введите любой символ");
             
                if (!TryReadType(out DisplayType type)|| type == DisplayType.None)
                {
                    return;
                }

                if (!displayTypes.Remove(type)) 
                {
                    displayTypes.Add(type);
                }

                PrintList(displayTypes);
            }            
        }

        private static bool TryReadType(out DisplayType type)
        {
            type = DisplayType.None;
            var enteredStr = Console.ReadLine();    

            if (!Enum.TryParse(enteredStr, out type))
            {
                return false;
            }

            if (!Enum.IsDefined(type))
            {
                return false;
            }

            return true;    
        }

        private static void PrintList(List<DisplayType> displayTypes)
        {
            Console.Write("Параметры надписи: ");
            for (int i = 0;i < displayTypes.Count;i++)
            {
                Console.Write(displayTypes[i] + " ");
            }
            Console.WriteLine();
        } 
    }
}
