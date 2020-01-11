using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Mykola
{
    static class UI
    {
        public static void EnterData(out int width, out int height)
        {
            Console.Write("Enter width of map : ");
            width = int.Parse(Console.ReadLine());
            Console.Write("Enter height of map :");
            height = int.Parse(Console.ReadLine());
            Console.Clear();

        }
        public static void DrawPixel(Pixel pixel)
        {
            Console.SetCursorPosition(pixel.X, pixel.Y);
            Console.ForegroundColor = pixel.Clothing.Color;
            Console.Write(pixel.Clothing.Symbol);
        }
        public static void DrawUpadateMap(Map map)
        {
            for (int i = 0; i < map.Height; i++)
            {
                for (int j = 0; j < map.Width; j++)
                {
                    if (map[i, j] != map.GetBoofElement(i, j))
                    {
                        Thread.Sleep(300);
                        DrawPixel(map[i, j]);
                        map.SetBoofElement(map[i, j]);
                        
                    }
                }
            }
        }

        public static void DrawMap(Map map)
        {
            for (int i = 0; i < map.Height; i++)
            {
                for (int j = 0; j < map.Width; j++)
                {
                        DrawPixel(map[i, j]);
                }
            }
        }
    }
}
