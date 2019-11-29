using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Gear
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.InitilizationGameByDefault();
            UI.PrintPlayer();
            
            //Game.EnterKey();
           
            do
            {
                Game.EnterKey();

                if (Game.IsAnyBlockTouchedBall())
                {
                    break;
                }
                Game.GameIteration();
                

            } while (true);
        }
    }
}
