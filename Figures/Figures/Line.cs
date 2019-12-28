using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Figures
{
    class Line : Figure
    {

        #region ======Private fields======

        private Point _p1;
        private Point _p2;
        private ConsoleColor Color { get; }

        #endregion

        #region ======Constructors======

        public Line(Point p1, Point p2)
        {
            _p1 = new Point(p1);
            _p2 = new Point(p2);
            Color = p1.Color;
        }

        public Line(int x1, int y1, int x2, int y2, ConsoleColor color)
        {
            _p1 = new Point(x1, y1, color);
            _p2 = new Point(x2, y2, color);
            Color = color;
        }

        #endregion

        #region ======Properties======s

        private int DeltaX
        {
            get
            {
                return _p2.X - _p1.X;
            }
        }

        private int DeltaY
        {
            get
            {
                return _p2.Y - _p1.Y;
            }
        }

        public int DistanceBetwwenPoints
        {
            get
            {
                return (int)Math.Sqrt(Math.Pow(_p2.X - _p1.X,2) + Math.Pow(_p2.Y - _p1.Y, 2));
            }
        }
        #endregion

        #region ======Methods======

        public override void FillArrayAPoints()
        {

            if (Math.Abs(DeltaX) >= Math.Abs(DeltaY))    
            {


                double koef = (double)DeltaY / (double)DeltaX;

                if (DeltaX > 0)
                { 
                    for (int i = 0; i <= DeltaX; i++)
                    {
                        int x = _p1.X + i;
                        int y = (int)(i * koef) + _p1.Y;

                        AddPoint(new Point(x, y, Color));
                    }
                }
                else
                {
                    for (int i = 0; i >= DeltaX; i--)
                    {
                        int x = _p1.X + i;
                        int y = (int)(i * koef) + _p1.Y;

                        AddPoint(new Point(x, y, Color));
                    }
                }
            }
            else
            {
                double koef = (double)DeltaX / (double)DeltaY;

                if (DeltaY > 0)
                {
                    for (int i = 0; i <= DeltaY; i++)
                    {
                        int x = (int)(i * koef) + _p1.X;
                        int y = _p1.Y + i;

                        AddPoint(new Point(x, y, Color));
                    }
                }
                else
                {
                    for (int i = 0; i >= DeltaY; i--)
                    {
                        int x = (int)(i * koef) + _p1.X;
                        int y = _p1.Y + i;

                        AddPoint(new Point(x, y, Color));
                    }
                }
            }


        }

        
        
        #endregion
    }
}
   