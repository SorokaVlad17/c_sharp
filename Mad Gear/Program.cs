using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191102_Mad_Gear
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.InitilizationConsoleByDefault();

            EventOfMap.PrintMap();

            do
            {
                if (Game.IsSizeOfWindowCorect())
                {
                    
                }

                else
                {
                  
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
