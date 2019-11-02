using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Gear
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.InitilizationConsoleByDefault();

            EventOfMap.LoadMap();

            do
            {
                if(Game.IsSizeOfWindowCorect())
                {

                }

                else
                {

                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
