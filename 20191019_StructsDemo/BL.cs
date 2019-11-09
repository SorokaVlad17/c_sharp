using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191019_StructsDemo
{
    class BL    // CRUD: Polyline - container, Point - agregat
    {
        #region Create

        public static void Add(ref PolyLine pl, Point newPoint)
        {
            if (pl.Points == null)
	        {
                pl.Points = new Point[] { newPoint };
                return;
	        }

            Array.Resize(ref pl.Points, pl.Points.Length + 1);

            pl.Points[pl.Points.Length - 1] = newPoint;
        }

        public static void Add(PolyLine pl, Point[] newPoints)
        {
            // ...
        }

        #endregion

        #region Read

        public static bool IsExist(PolyLine pl, Point p)
        {
            bool existed = false;

            for (int i = 0; i < pl.Points.Length; i++)
            {
                if ((pl.Points[i].X == p.X) && (pl.Points[i].Y == p.Y))
                {
                    existed = true;
                    break;
                }
            }

            return existed;
        }

        #endregion

        public static PolyLine GetCopy(PolyLine source)
        {
            PolyLine destination = source;    // копирование структуры по полям

            // !!! отдельно обрабатываем поля, являющиеся ссылочными типами данных
            destination.Points = (Point[])source.Points.Clone();

            return destination;
        }
    }
}
