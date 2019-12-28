using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle : Figure
    {
        #region ======Private fields======

        private Point _p1;
        private Point _p2;
        private Point _p3;
        private Line[] _lines;
        private ConsoleColor Color { get; }

        #endregion

        #region ======Constructors======

        public Triangle(Point p1, Point p2, Point p3, ConsoleColor color)
        {
            _p1 = new Point(p1);
            _p2 = new Point(p2);
            _p3 = new Point(p3);
            Color = color;
            _lines = new Line[3];
        }

        #endregion

        #region Methods

        public override void FillArrayAPoints()
        {
            _lines[0] = new Line(_p1, _p2);
            _lines[1] = new Line(_p2, _p3);
            _lines[2] = new Line(_p3, _p1);
            _points = new Point[_lines[0].DistanceBetwwenPoints + _lines[1].DistanceBetwwenPoints + _lines[2].DistanceBetwwenPoints];
            for (int i = 0; i < 3; i++)
            {

            }

        }

        #endregion
    }
}
