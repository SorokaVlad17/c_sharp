using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Figure
    {
        #region ======Private fields======

        protected Point[] _points;

        #endregion

        #region ======Constructors======

        public Figure()
        {
           // TODO : PARAMS!
        }

        #endregion

        #region ======Properties======
 
        public int CountPoints
        {
            get
            {
                return _points.Length;
            }
        }

        #endregion

        #region ======Methods======

        public virtual void FillArrayAPoints()
        {

        }

        protected void AddPoint(Point newPoint)
        {

            if (_points == null)
            {
                _points = new Point[] { newPoint };
                return;
            }

            Array.Resize(ref _points, _points.Length + 1);

            _points[_points.Length - 1] = newPoint;
        }

        public Point GetPoint(int index)
        {
            return new Point(_points[index].X, _points[index].Y, _points[index].Color);
        }

        #endregion
    }
}
