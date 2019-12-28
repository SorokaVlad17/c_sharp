using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Point : Figure
    {
        #region ======Private fields======

        private int _x;
        private int _y;
        private ConsoleColor _color;

        #endregion

        #region ======Properties======

        public int X
        {
            get
            {
                return _x;
            }

        }

        public int Y
        {
            get
            {
                return _y;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return _color;
            }
        }

        #endregion

        #region ======Constructors======

        public Point(int x, int y, ConsoleColor color) 
        {
            _x = x;
            _y = y;
            _color = color;
        }

        public Point(Point p) 
        {
            _x = p.X;
            _y = p.Y;
            _color = p._color;
        }

        #endregion

        #region ======Methods======

        public override void FillArrayAPoints()
        {
            AddPoint(this);
        }

        #endregion

    }
}