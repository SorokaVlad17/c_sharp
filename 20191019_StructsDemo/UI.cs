using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191019_StructsDemo
{
    class UI
    {
        public static void ShowPoint(int x, int y, ConsoleColor c = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = c;
            Console.Write('*');
        }

        public static void Show(Point p)
        {
            Console.SetCursorPosition(p.X, p.Y);
            Console.ForegroundColor = p.Color;
            Console.Write('*');
        }

        public static void ShowPoints(int[] xCoords, int[] yCoords, ConsoleColor[] colors)
        {
            for (int i = 0; i < 100; i++)
            {
                UI.ShowPoint(xCoords[i], yCoords[i], colors[i]);
            }
        }

        public static void Show(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                UI.Show(points[i]);
            }
        }


        public static void Show(PolyLine pl)
        {
            for (int i = 0; i < pl.Points.Length; i++)
            {
                Show(pl.Points[i]);
            }
        }        
    }

}
