using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle : Figure
    {
        public Triangle(Point p1, Point p2, Point p3)
        {
            _lines = new Line[3];
            _lines[0] = new Line(p1, p2);
            _lines[1] = new Line(p2, p3);
            _lines[2] = new Line(p3, p1);

        }
            
    }
}
