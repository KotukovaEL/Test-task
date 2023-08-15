using System;
using System.Collections.Generic;

namespace Task1_6
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            var displayTypes = new List<DisplayType>();
            Console.WriteLine("Параметры надписи: None");
            
            while (true)
            {
                Console.WriteLine("Введите: \n\t 1: bold \n\t 2: italic \n\t 3: underline. \n Для выхода из приложения введите любой символ");
                var enteredStr = Console.ReadLine();
                if (!Logic.TryReadType(enteredStr, out DisplayType type)|| type == DisplayType.None)
                {
                    return;
                }

                if (!displayTypes.Remove(type)) 
                {
                    displayTypes.Add(type);
                }

                Logic.PrintList(displayTypes);
            }            
        }
    }
}
