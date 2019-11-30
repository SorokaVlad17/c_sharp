using System;

namespace _20191130_Mad_Gear
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.InitilizationGameByDefault();
            UI.PrintPlayer();
            
            do
            {
                if (Game.IsAnyBlockTouchedBall())
                {
                    break;
                }
                Game.GameIteration();
            } while (true);
        }
    }
}
