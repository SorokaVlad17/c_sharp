using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    class Way
    {
        #region ======Private fields======

        private Coordinate _start;
        private Coordinate _end;
        private int _pos;
        private List<Coordinate> _way = new List<Coordinate>();

        #endregion

        #region ======Constructors======

        public Way(Coordinate start, Coordinate end)
        {
            _start = new Coordinate(start.X, start.Y);
            _end = new Coordinate(end.X, end.Y);
            _pos = 0;
            FillWay();
        }
        public Way(Way way)
        {
            _pos = way.Position;
            _start = new Coordinate(way.Start.X, way.Start.Y);
            _end = new Coordinate(way.End.X, way.End.Y);
            for (int i = 0; i < way.Distance; i++)
            {
                _way.Add(way.GetCoordinate(i));
            }
               
        }

        #endregion

        #region ======Properties======

        public int Distance
        {
            get
            {
                return _way.Count;
            }
        }

        public int Position
        {
            get
            {
                return _pos;
            }
            set
            {
                _pos = value;
            }
        }
        private int DeltaX
        {
            get
            {
                return _end.X - _start.X;
            }
        }

        private int DeltaY
        {
            get
            {
                return _end.Y - _start.Y;
            }
        }

        public Coordinate Start
        {
            get
            {
                return _start;
            }
        }

        public Coordinate End
        {
            get
            {
                return _end;
            }
        }
        #endregion

        #region ======Methods======

        private void FillWay()
        {

            if (Math.Abs(DeltaX) >= Math.Abs(DeltaY))
            {


                double koef = (double)DeltaY / (double)DeltaX;

                if (DeltaX > 0)
                {
                    for (int i = 0; i <= DeltaX; i++)
                    {
                        int x = _start.X + i;
                        int y = (int)(i * koef) + _end.Y;

                        _way.Add(new Coordinate(x, y));
                    }
                }
                else
                {
                    for (int i = 0; i >= DeltaX; i--)
                    {
                        int x = _start.X + i;
                        int y = (int)(i * koef) + _start.Y;

                        _way.Add(new Coordinate(x, y));
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
                        int x = (int)(i * koef) + _start.X;
                        int y = _start.Y + i;

                        _way.Add(new Coordinate(x, y));
                    }
                }
                else
                {
                    for (int i = 0; i >= DeltaY; i--)
                    {
                        int x = (int)(i * koef) + _start.X;
                        int y = _start.Y + i;

                        _way.Add(new Coordinate(x, y));
                    }
                }
            }
        }

        public Coordinate GetCoordinate(int pos)
        {

            return _way[pos];
        }

        #endregion
    }
}
