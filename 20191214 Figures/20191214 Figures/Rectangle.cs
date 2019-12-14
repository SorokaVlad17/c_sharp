using System;
using System.Collections.Generic;
using System.Text;

namespace _20191214_Figures
{
    class Rectangle : VolumeFigure
    {
        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            _lines = new Line[4];
            _lines[0] = new Line(p1, p2);
            _lines[1] = new Line(p2, p3);
            _lines[2] = new Line(p3, p4);
            _lines[3] = new Line(p4, p1);
        }

    }
}
