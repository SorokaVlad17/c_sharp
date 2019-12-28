using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class UI
    {
        public static void DrawPoint(Point p)
        {
            Console.SetCursorPosition(p.X, p.Y);
            Console.ForegroundColor = p.Color;
            Console.Write("*");
        }

        public static void DrawFigure(Figure fig)
        {
            fig.FillArrayAPoints();
            for (int i = 0; i < fig.CountPoints; i++)
            {
                DrawPoint(fig.GetPoint(i));
            }
        }


    }
}
