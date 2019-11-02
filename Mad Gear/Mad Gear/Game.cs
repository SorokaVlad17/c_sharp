using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Gear
{
    class Game
    {
        static public readonly int WIDTH_CONSOLE = 100;
        static public readonly int HEGHT_CONSOLE = 30;
        static public readonly string TITLE_OF_GAME = "Mad Gear";

        public static void InitilizationConsoleByDefault()
        {
            Console.SetWindowSize(WIDTH_CONSOLE,HEGHT_CONSOLE);
            Console.Title = TITLE_OF_GAME;
        }

        public static bool IsSizeOfWindowCorect()
        {
            bool isCorrect = true;

            if(Console.WindowWidth != WIDTH_CONSOLE
               && Console.WindowHeight != HEGHT_CONSOLE)
            {
                isCorrect = false;
            }

            return isCorrect;
        }
    }
}
