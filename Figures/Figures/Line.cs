using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Figures
{
    class Line
    {
        private Point[] _points;
        private double _dX;
        private double _dY;
        private Point _p1;
        public Line(Point p1, Point p2)
        {
            _p1 = new Point(p1.X, p1.Y);
            _dX = p1.X - p2.X;
            _dY = p1.Y - p2.Y;

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

        private void DrawPixel(int x, int y, ConsoleColor color, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void DrawLine()
        {
            if (Math.Abs(_dX) >= Math.Abs(_dY))    // если дельта между Y в разы больше чем дельта X, то меняем X и Y местами
            {
                double koef = (double)_dY / (double)_dX;

                if (_dX > 0)    // если дельта X меньше 0, то график будет перевернут и начинаться стоится с конца 
                {
                    for (int i = 0; i <= _dX; i++)
                    {
                        int x = _p1.X + i;
                        int y = (int)(i * koef) + _p1.Y;
                        AddPoint(new Point(x, y));
                    }
                }
                else
                {
                    for (int i = 0; i >= _dX; i--)
                    {
                        int x = _p1.X + i;
                        int y = (int)(i * koef) + _p1.Y;
                        AddPoint(new Point(x, y));
                    }
                }
            }
            else
            {
                double koef = (double)_dX / (double)_dY;

                if (_dY > 0)
                {
                    for (int i = 0; i <= _dY; i++)
                    {
                        int x = (int)(i * koef) + _p1.X;
                        int y = _p1.Y + i;
                        AddPoint(new Point(x, y));
                    }
                }
                else
                {
                    for (int i = 0; i >= _dY; i--)
                    {
                        int x = (int)(i * koef) + _p1.X;
                        int y = _p1.Y + i;
                        AddPoint(new Point(x, y));
                    }
                }
            }
            foreach (Point p in _points)
            {
                DrawPixel(p.X,p.Y, ConsoleColor.Blue, '*');
            }
        }
    }
}



#endregion































//    public void DrawLine()
//    {
//        int dX;
//        int dY;
//        if(_dX >=0.0 )
//        {
//            dX = -1;
//        }
//        else
//        {
//            dX = 1;
//        }

//        if (_dY >= 0.0)
//        {
//            dY = -1;
//        }
//        else
//        {
//            dY = 1;
//        }
//        int lengthX = Math.Abs((int)_dX);
//        int lengthY = Math.Abs((int)_dY);
//        int length;

//        if (lengthX<lengthY)
//        {
//            length = lengthY;
//        }
//        else
//        {
//            length = lengthX;
//        }

//        if(length == 0)
//        {
//            return;
//        }

//        if (lengthY <= lengthX)
//        {
//            // Начальные значения
//            int x = _p1.X;
//            double y = _p1.Y;
//            int d = -lengthX;

//            // Основной цикл
//            length++;
//            for (int i = 0; i < length + 1; i++)
//            {
//                DrawPixel(x, (int)Math.Round(y), ConsoleColor.Blue, '*');
//                x += dX;
//                d += 2 * lengthY;
//                if (d > 0)
//                {
//                    d -= 2 * lengthX;
//                    y += dY;
//                }
//            }
//           }
//        else
//        {
//            // Начальные значения
//            int x = _p1.X;
//            int y = _p1.Y;
//            int d = -lengthY;

//            // Основной цикл
//            length++;
//            for (int i = 0; i < length + 1; i++)
//            {
//                DrawPixel(x, y, ConsoleColor.Blue, '*');
//                d += 2 * lengthX;
//                if (d > 0)
//                {
//                    d -= 2 * lengthY;
//                    x += dX;
//                }
//            }
//            }
//        }

//    }
//}