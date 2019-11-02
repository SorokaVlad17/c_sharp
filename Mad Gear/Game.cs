using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _20191102_Mad_Gear
{
    class Game
    {
        static public readonly int WIDTH_CONSOLE = 100;
        static public readonly int HEGHT_CONSOLE = 30;
        static public readonly string TITLE_OF_GAME = "Mad Gear";
        static public readonly int MAX_X_POSITION_BALL = 7;
        static public int HeightOfJump = 6;
        static public int SpeedInMiliseconds = 1000;
        static public int Min_Y = 25;
        

        public static void InitilizationConsoleByDefault()
        {
            Console.SetWindowSize(WIDTH_CONSOLE, HEGHT_CONSOLE);
            Console.Title = TITLE_OF_GAME;
        }

        public static bool IsSizeOfWindowCorect()
        {
            bool isCorrect = true;

            if (Console.WindowWidth != WIDTH_CONSOLE
               && Console.WindowHeight != HEGHT_CONSOLE)
            {
                isCorrect = false;
            }

            return isCorrect;
        }

        public static void GameLoop()
        {
            
        }

    }
}
