using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanModel
{
    class Prey : Cell
    {
        #region ======Private fields======

        protected int _timeToReproduce = 6;

        #endregion

        #region ======Constructors======

        public Prey()
        {
            _image = 'f';
        }

        #endregion
    }
}
