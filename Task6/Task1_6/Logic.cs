using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task1_6.Program;

namespace Task1_6
{
    public class Logic
    {
        public static bool TryReadType(string enteredStr, out DisplayType type)
        {
            type = DisplayType.None;
            

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

        public static void PrintList(List<DisplayType> displayTypes)
        {
            Console.Write("Параметры надписи: ");
            for (int i = 0; i < displayTypes.Count; i++)
            {
                Console.Write(displayTypes[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
