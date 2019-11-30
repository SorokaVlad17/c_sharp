using System;
using System.Collections.Generic;
using System.Text;

namespace _20191130_Mad_Gear
{
    class UI
    {
        public static void DrawWalls()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("■");
            }
            for (int i = 1; i < 30; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
            }
            for (int i = 26; i < 30; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write("■");
                }
            }
        }

        public static void ShowScore(int score, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(Game.POSITION_X_OF_SCORE, Game.POSITION_Y_OF_SCORE);
            Console.Write(score);
        }

        public static void Hide(Block b, int offsetY)
        {
            Show(b, offsetY, Console.BackgroundColor, ' ');
        }

        public static void HidePlayer(int offsetY)
        {
            Hide(Game.Player, offsetY);
        }

        public static void PrintPlayer()
        {
            Show(Game.Player, 0, ConsoleColor.Red, '0');
        }

        public static void Show(Block b, int offsetY = 0, ConsoleColor color = ConsoleColor.Green, char symbol = '*')
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < b.Height; i++)
            {
                ++Game.Score;
                for (int j = 0; j < b.Width; j++)
                {
                    ++Game.Score;
                    Console.SetCursorPosition(b.X + j, b.Y - i - offsetY);
                    Console.Write(symbol);
                }
            }
        }
    }
}
