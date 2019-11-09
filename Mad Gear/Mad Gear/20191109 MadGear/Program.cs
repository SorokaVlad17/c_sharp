using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191109_MadGear
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.InitilizationConsoleByDefault();

            EventOfMap.PrintMap();

            Game.JumpAndFall();


            Block[] blocks = new Block[]
            {
                new Block() { X = 75, Width = 4, Heigth = 4 },
                new Block() { X = 55, Width = 4, Heigth = 6 }
            };

            do
            {
                Game.GameIteration(blocks);

                System.Threading.Thread.Sleep(1000);
            } while (true);
        }
    }
}
