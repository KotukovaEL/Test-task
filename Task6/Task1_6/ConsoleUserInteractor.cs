using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_6
{
    public class ConsoleUserInteractor : IUserInteractor
    {
        public void PrintDisplayTypes(List<DisplayType> displayTypes)
        {
            Console.Write("Параметры надписи: ");
            for (int i = 0; i < displayTypes.Count; i++)
            {
                Console.Write(displayTypes[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintOptions()
        {
            Console.WriteLine("Введите: \n\t 1: bold \n\t 2: italic \n\t 3: underline. \n Для выхода из приложения введите любой символ");
        }

        public string ReadDisplayType()
        {
            return Console.ReadLine();
        }
    }
}
