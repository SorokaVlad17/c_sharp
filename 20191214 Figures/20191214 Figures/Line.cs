using System;
using System.Collections.Generic;
using System.Text;

namespace _20191214_Figures
{
    class Line
    {
        private Point[] _points;
        //private int _dX;
        //private int _dY;
        private Point _p1;
        private Point _p2;

        public Line(Point p1, Point p2)
        {
            _p1 = new Point(p1);
            _p2 = new Point(p2);
            //_dX = p2.X - p1.X;
            //_dY = p2.Y - p1.Y;

        }

        // ToDo: public Line(x1, y1, x2, y2)

        protected int DeltaX
        {
            get 
            {
                //return Math.Abs(_p2.X - _p1.X); 
                return _p2.X - _p1.X;
            }        
        }

        protected int DeltaY    // ToDo: ??? public --> protected
        {
            get
            {
                //return Math.Abs(_p2.X - _p1.X); 
                return _p2.Y - _p1.Y;
            }
        }


        #region Methods


        private void AddPoint(Point newPoint)
        {

            if (_points == null)
            {
                _points = new Point[] { newPoint };
                return;
            }

            Array.Resize(ref _points, _points.Length + 1);

            _points[_points.Length - 1] = newPoint;
        }

        public void DrawPixel(int x, int y, ConsoleColor color, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        public Point[] DrawLine(ConsoleColor color,char symbol)
        {
            // ToDo: + points array

            int pointsCount = DeltaY;
            if (DeltaX > DeltaY)
            {
                pointsCount = DeltaX;
            }

            int lastPointIndex = 0;
            Point[] result = new Point[pointsCount];

            if (Math.Abs(DeltaX) >= Math.Abs(DeltaY))    // если дельта между Y в разы больше чем дельта X, то меняем X и Y местами
            {


                double koef = (double)DeltaY / (double)DeltaX;

                if (DeltaX > 0)    // если дельта X меньше 0, то график будет перевернут и начинаться стоится с конца 
                {
                    for (int i = 0; i <= DeltaX; i++)
                    {
                        int x = _p1.X + i;
                        int y = (int)(i * koef) + _p1.Y;

                        result[lastPointIndex++] = new Point(x, y);
                        //AddPoint(new Point(x, y));
                    }
                }
                else
                {
                    for (int i = 0; i >= DeltaX; i--)
                    {
                        int x = _p1.X + i;
                        int y = (int)(i * koef) + _p1.Y;
                        //AddPoint(new Point(x, y));

                        result[lastPointIndex++] = new Point(x, y);
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
                        //AddPoint(new Point(x, y));

                        result[lastPointIndex++] = new Point(x, y);
                    }
                }
                else
                {
                    for (int i = 0; i >= DeltaY; i--)
                    {
                        int x = (int)(i * koef) + _p1.X;
                        int y = _p1.Y + i;
                        //AddPoint(new Point(x, y));

                        result[lastPointIndex++] = new Point(x, y);
                    }
                }
            }

            // ToDo: ---> UI
            foreach (Point p in _points)
            {
                DrawPixel(p.X, p.Y, color, symbol);
            }

            return result;
        }
    }
}



#endregion
