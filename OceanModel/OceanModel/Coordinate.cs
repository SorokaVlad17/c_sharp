using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanModel
{
    class Coordinate
    {
        #region ======Private fields======

        private int _x;
        private int _y;

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


        #endregion
    }
}
