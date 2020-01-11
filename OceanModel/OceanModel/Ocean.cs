using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanModel
{
    class Ocean
    {
        #region ======Private fields======

        private Cell[] cells;
        private int _numCols = 75;
        private int _numRow = 25;
        private int _numPrey = 150;
        private int _numPredators = 20;
        private int _numObstacles = 75;
        private static Random _rnd = new Random();

        #endregion

        #region ======Properties======

        public int Size
        {
            get
            {
                return _numCols * _numRow;
            }
        }

        #endregion

        #region ======Methods======



        #endregion
    }
}
