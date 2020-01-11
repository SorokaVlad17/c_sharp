using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanModel
{
    class Predator : Prey
    {
        #region ======Private fields======

        private int _timeToFeed = 6;

        #endregion

        #region ======Constructors======

        public Predator()
        {
            _image = 'S';
        }

        #endregion
    }
}
