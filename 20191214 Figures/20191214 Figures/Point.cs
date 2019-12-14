using System;
using System.Collections.Generic;
using System.Text;

namespace _20191214_Figures
{
    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(Point source)
        {
            X = source.X;
            Y = source.Y;
        }
    }
}
