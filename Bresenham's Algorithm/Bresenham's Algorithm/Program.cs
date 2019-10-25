using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bresenham_s_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;

            UI.EnterCords(ref x1, ref y1, ref x2, ref y2);

            Point p1 = new Point() { X = x1, Y = y1 };
            Point p2 = new Point() { X = x2, Y = y2 };

            UI.DrawLine(p1, p2);

            Console.ReadKey();
        }
    }
}
