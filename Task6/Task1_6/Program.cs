using System;
using System.Collections.Generic;

namespace Task1_6
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            var consoleUserInteractor = new ConsoleUserInteractor();
            var logic = new Logic(consoleUserInteractor);
            logic.Run();
        }
    }
}
