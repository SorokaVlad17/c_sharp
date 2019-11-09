using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191109_MadGear
{
    class UI
    {
        public static void Hide(Block b, int offsetY)
        {
            Show(b, offsetY, Console.BackgroundColor);
        }

        public static void Show(Block b, int offsetY, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < b.Heigth; i++)
            {
                for (int j = 0; j < b.Width; j++)
                {                    
                    Console.SetCursorPosition(b.X + j, offsetY - i);
                    Console.Write('*');
                }
            }
        }

    }
}
