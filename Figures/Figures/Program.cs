using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, ConsoleColor.Red);
            Point p2 = new Point(1, 5, ConsoleColor.Red);
            Point p3 = new Point(8, 5, ConsoleColor.Red);



            UI.DrawPoint(p1);
            UI.DrawFigure(p2);

           Line l1 = new Line(5,6,2,9,ConsoleColor.Blue);
            Line l2 = new Line(10, 10, 12, 12, ConsoleColor.Cyan);

            UI.DrawFigure(l1);
            UI.DrawFigure(l2);

            Circle c1 = new Circle(30, 15, 8, ConsoleColor.DarkGreen);

            UI.DrawFigure(c1);

            Triangle tr = new Triangle(p1, p2, p3, ConsoleColor.Yellow);
            UI.DrawFigure(tr);

            Console.ReadKey();
        }
    }
}
