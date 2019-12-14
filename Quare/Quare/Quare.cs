using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quare
{
    class Quare
    {
        #region Private fields

        private object[] _quare;
        private int _sizeQuare;
        private int _positionWrite;
        private int _positionRead;

        #endregion
        public Quare(int count)
        {
            _sizeQuare = count;
            _positionWrite = 0;
            _positionRead = 0;
            _quare = new object[count];
        }

        #region Methods
        
        public bool IsFull()
        {
            bool isFull = false;
            if (_positionWrite == _sizeQuare)
            {
                isFull = true;
            }

            return isFull;
        }

        public bool IsEmpty()
        {
            bool isEmpty = false;
            if(_quare.Length == 0)
            {
                isEmpty = true;
            }

            return isEmpty;
        }

        public void Euquare(object item)
        {
            if(IsFull())
            {
                return;
            }

            _quare[_positionWrite] = item;
            ++_positionWrite;
        }

        public object Dequare()
        {
            if(IsEmpty())
            {
                return null;
            }
            ++_positionRead;
          
            return _quare[_positionRead - 1];
        }


    }
    #endregion
}
